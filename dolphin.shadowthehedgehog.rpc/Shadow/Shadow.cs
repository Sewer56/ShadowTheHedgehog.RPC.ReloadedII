using System.IO.Pipes;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using Dolphin.ShadowTheHedgehog.RPC.Dolphin;
using Dolphin.ShadowTheHedgehog.RPC.Shadow.Definitions;
using Dolphin.ShadowTheHedgehog.RPC.Shadow.Utilities;

namespace Dolphin.ShadowTheHedgehog.RPC.Shadow
{
    /// <summary>
    /// Utility methods for Shadow the Hedgehog Dolphin game process.
    /// </summary>
    public unsafe class Shadow
    {
        /* Pointers */
        private const long GameIdPtr    = 0x80000000;
        private const string GameId     = "GUPE8P";

        public DolphinPointer<StageID>          StageId;
        public DolphinPointer<MenuState>        MenuState;
        public DolphinPointer<Modes>            CurrentMode;
        public DolphinPointer<CurrentMission>   CurrentMission;
        public DolphinPointer<byte>             IsWatchingCutscene;
        public DolphinPointer<byte>             IsGameplayFrozen;
        public DolphinPointer<float>            StageTimer;

        private Memory.Access.Dolphin _dolphin;

        /*
            ------------
            Construction
            ------------
        */

        public Shadow(Memory.Access.Dolphin dolphin)
        {
            _dolphin = dolphin;
            var currentProcess = Reloaded.Memory.Sources.Memory.CurrentProcess;

            StageId   = new DolphinPointer<StageID>(0x805EF958, _dolphin, currentProcess);
            MenuState = new DolphinPointer<MenuState>(0x80583ACC, _dolphin, currentProcess);
            CurrentMode = new DolphinPointer<Modes>(0x805EC170, _dolphin, currentProcess);
            CurrentMission = new DolphinPointer<CurrentMission>(0x80575F1F, _dolphin, currentProcess);
            IsWatchingCutscene = new DolphinPointer<byte>(0x8057FA85, _dolphin, currentProcess);
            IsGameplayFrozen = new DolphinPointer<byte>(0x8057D768, _dolphin, currentProcess);
            StageTimer = new DolphinPointer<float>(0x8057D734, _dolphin, currentProcess);
        }

        /*
            ---------------
            Utility Methods
            ---------------
        */

        [HandleProcessCorruptedStateExceptions]
        public bool IsPlayingShadow()
        {
            if (_dolphin.TryGetAddress(GameIdPtr, out var realAddress))
            {
                var gameId = Marshal.PtrToStringAnsi(realAddress, 6);
                if (gameId == GameId)
                    return true;
            }

            return false;
        }

        public string GetStageName()
        {
            if (StageId.TryGetValue(out var value))
                if (StageNameDictionary.Dictionary.TryGetValue(value, out string stageName))
                    return stageName;
            
            return "Cutscene or Unknown Stage";
        }

        public string GetMenuStateName()
        {
            if (MenuState.TryGetValue(out var value))
                if (MenuNameDictionary.Dictionary.TryGetValue(value, out string menuState))
                    return menuState;
            
            return "Unknown Menu State";
        }

        public string GetModeName()
        {
            if (CurrentMode.TryGetValue(out var value))
                if (ModeNameDictionary.Dictionary.TryGetValue(value, out string modeState))
                    return modeState;
            
            return "Unknown Mode";
        }

        public string GetCurrentMission()
        {
            return CurrentMission.TryGetValue(out var value) ? value.ToString("G") 
                                                             : "Unknown Mission";
        }
    }
}
