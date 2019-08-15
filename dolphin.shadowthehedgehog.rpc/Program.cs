using System;
using System.Diagnostics;
using Reloaded.Mod.Interfaces;
using Reloaded.Mod.Interfaces.Internal;

namespace Dolphin.ShadowTheHedgehog.RPC
{
    public class Program : IMod
    {
        public static string ModDirectory;

        private IModLoader _modLoader;
        private ShadowRpc _shadowRpc;

        public void Start(IModLoaderV1 loader)
        {
            _modLoader = (IModLoader)loader;
            
            ModDirectory = _modLoader.GetDirectoryForModId("dolphin.shadowthehedgehog.rpc");

            var settings = Settings.GetSettings();
            settings.ToFile();

            _shadowRpc = new ShadowRpc(Process.GetCurrentProcess(), settings);
        }

        /* Mod loader actions. */
        public void Suspend()
        {
            _shadowRpc.Suspend();
        }

        public void Resume()
        {
            _shadowRpc.Resume();
        }

        public void Unload()
        {
            Suspend();
            _shadowRpc.Dispose();
        }

        public bool CanUnload()  => true;
        public bool CanSuspend() => true;

        /* Automatically called by the mod loader when the mod is about to be unloaded. */
        public Action Disposing { get; }
    }
}
