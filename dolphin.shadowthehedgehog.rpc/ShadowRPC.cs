using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Text;
using DiscordRPC;
using Dolphin.ShadowTheHedgehog.RPC.Shadow.Definitions;
using Dolphin.ShadowTheHedgehog.RPC.Shadow.Definitions.Fun;
using Dolphin.ShadowTheHedgehog.RPC.Shadow.Utilities;

namespace Dolphin.ShadowTheHedgehog.RPC
{
    public class ShadowRpc : IDisposable
    {
        private Memory.Access.Dolphin _dolphin;
        private Shadow.Shadow _shadow;
        private System.Threading.Timer _timer;
        private DiscordRpcClient _rpcClient;
        private Settings _settings;

        private bool _suspended = false;

        /* Initialization / Teardown */
        public ShadowRpc(Process process, Settings settings)
        {
            _settings = settings;
            _dolphin = new Memory.Access.Dolphin(process);
            _shadow  = new Shadow.Shadow(_dolphin);
            _rpcClient = new DiscordRpcClient("493507183749627907"); // It's not like you could just extract this using a decompiler. Obfuscation? Screw that!
            _rpcClient.Initialize();
            _timer = new System.Threading.Timer(Tick, null, new TimeSpan(0), new TimeSpan(0, 0, 0, 5));
        }

        public void Dispose()
        {
            _timer?.Dispose();
            _rpcClient?.Dispose();
        }

        public void Suspend()
        {
            _suspended = true;
        }

        public void Resume()
        {
            _suspended = false;
        }

        private void Tick(object state)
        {
            if (_shadow.IsPlayingShadow() && !_suspended)
            {
                var richPresence = new RichPresence();

                // Details
                if (_shadow.IsWatchingCutscene.GetValue() == 1)
                    richPresence.Details = "Watching Cutscene";
                else if (_shadow.CurrentMode.GetValue() == Modes.Menu)
                    richPresence.Details = "Navigating Menu";
                else
                    richPresence.Details = _shadow.GetStageName();

                // Game State
                if (_settings.OffensiveCaptions && _shadow.CurrentMode.GetValue() != Modes.ExpertMode)
                {
                    // Offensive Mode
                    if (_shadow.StageId.TryGetValue(out var stageId) && _shadow.CurrentMission.TryGetValue(out var currentMission))
                    {
                        richPresence.State = OffensiveMissions.GetDescription(stageId, currentMission);
                    }
                }
                else
                {
                    // Normal Game
                    if (_shadow.IsWatchingCutscene.GetValue() == 0 && _shadow.CurrentMode.GetValue() != Modes.Menu)
                        richPresence.State = $"[{_shadow.GetModeName()}] {_shadow.GetCurrentMission()}";

                    // Expert Mode
                    if (_shadow.IsWatchingCutscene.GetValue() == 0 && _shadow.CurrentMode.GetValue() == Modes.ExpertMode)
                        richPresence.State = $"{_shadow.GetModeName()}";

                    // Menus
                    if (_shadow.CurrentMode.GetValue() == Modes.Menu)
                        richPresence.State = $"{_shadow.GetMenuStateName()}";

                    // Paused
                    if (_shadow.IsGameplayFrozen.GetValue() == 1)
                        richPresence.State = "Paused";
                }

                // Set Timestamp.
                if (_shadow.MenuState.GetValue() == MenuState.InGame)
                {
                    var timestamps = new Timestamps();
                    var assets = new Assets();

                    if (_shadow.IsGameplayFrozen.GetValue() == 0)
                    {
                        var stageStartTime = DateTime.UtcNow.Subtract(new TimeSpan(0, 0, 0, (int)_shadow.StageTimer.GetValue().Value));
                        timestamps.Start = stageStartTime;
                        richPresence.Timestamps = timestamps;
                    }

                    if (ImageNameDictionary.Dictionary.TryGetValue(_shadow.StageId.GetValue().Value, out string value))
                    {
                        assets.LargeImageKey = value;
                        richPresence.Assets = assets;
                    }
                }

                _rpcClient.SetPresence(richPresence);
            }
        }
    }
}
