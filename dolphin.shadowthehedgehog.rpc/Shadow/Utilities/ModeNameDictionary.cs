using System.Collections.Generic;

namespace Dolphin.ShadowTheHedgehog.RPC.Shadow.Utilities
{
    public class ModeNameDictionary
    {
        /// <summary>
        /// Translates a Shadow The Hedgehog stage id to stage name.
        /// </summary>
        public static Dictionary<Definitions.Modes, string> Dictionary = new Dictionary<Definitions.Modes, string>(128);

        static ModeNameDictionary()
        {
            Dictionary[Definitions.Modes.Menu]                = "In-Menu";
            Dictionary[Definitions.Modes.ExpertMode]          = "Expert Mode";
            Dictionary[Definitions.Modes.StoryMode]           = "Story Mode";
            Dictionary[Definitions.Modes.TwoPlayer]           = "Two Player";
            Dictionary[Definitions.Modes.SelectMode]          = "Select Mode";
        }
    }
}
