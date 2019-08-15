using System.Collections.Generic;

namespace Dolphin.ShadowTheHedgehog.RPC.Shadow.Utilities
{
    public class MenuNameDictionary
    {
        /// <summary>
        /// Translates a Shadow The Hedgehog stage id to stage name.
        /// </summary>
        public static Dictionary<Definitions.MenuState, string> Dictionary = new Dictionary<Definitions.MenuState, string>(128);

        static MenuNameDictionary()
        {
            Dictionary[Definitions.MenuState.InGame]                = "In-Game";
            Dictionary[Definitions.MenuState.MainMenu]              = "Main Menu";
            Dictionary[Definitions.MenuState.Options]               = "Adjusting Options";

            Dictionary[Definitions.MenuState.StoryAndLibrary]       = "Story Menu";
            Dictionary[Definitions.MenuState.LibraryMusic]          = "Chillin' in the Library";
            Dictionary[Definitions.MenuState.StoryRecap]            = "Looking at Boring Shadow Monologue";

            Dictionary[Definitions.MenuState.SelectMode]            = "Picking a Stage!";
            Dictionary[Definitions.MenuState.TwoPlayer]             = "Setting up Two Player with a Buddy!";

            Dictionary[Definitions.MenuState.OpeningMovie]          = "Watching Movie";
            Dictionary[Definitions.MenuState.BootMessage]           = "Message Dialog";
            Dictionary[Definitions.MenuState.Logos]                 = "Looking at Cool Logos";
        }
    }
}
