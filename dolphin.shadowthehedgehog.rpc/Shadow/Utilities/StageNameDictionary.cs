using System.Collections.Generic;

namespace Dolphin.ShadowTheHedgehog.RPC.Shadow.Utilities
{
    public class StageNameDictionary
    {
        /// <summary>
        /// Translates a Shadow The Hedgehog stage id to stage name.
        /// </summary>
        public static Dictionary<Definitions.StageID, string> Dictionary = new Dictionary<Definitions.StageID, string>(128);

        static StageNameDictionary()
        {
            Dictionary[Definitions.StageID.TestLevel]               = "Test Level";
            Dictionary[Definitions.StageID.TestLevelSkatePark]      = "Test Level (Skate Park)";
            Dictionary[Definitions.StageID.TestLevelUVTextureMap]   = "Test Level (UV Test)";
            Dictionary[Definitions.StageID.TestLevelSurfaceTest]    = "Test Level (Surface Test)";
            Dictionary[Definitions.StageID.TestLevelCutsceneTest]   = "Test Level (Cutscene Test)";

            Dictionary[Definitions.StageID.Westopolis]              = "Westopolis";

            Dictionary[Definitions.StageID.DigitalCircuit]          = "Digital Circuit";
            Dictionary[Definitions.StageID.GlyphicCanyon]           = "Glyphic Canyon";
            Dictionary[Definitions.StageID.LethalHighway]           = "Lethal Highway";

            Dictionary[Definitions.StageID.LethalHighwayBlackBull]  = "Black Bull (Lethal Highway)";

            Dictionary[Definitions.StageID.CrypticCastle]           = "Cryptic Castle";
            Dictionary[Definitions.StageID.PrisonIsland]            = "Prison Island";
            Dictionary[Definitions.StageID.CircusPark]              = "Circus Park";

            Dictionary[Definitions.StageID.CrypticCastleEggBreaker] = "Egg Breaker (Cryptic Castle)";

            Dictionary[Definitions.StageID.CentralCity]             = "Central City";
            Dictionary[Definitions.StageID.TheDoom]                 = "The Doom";
            Dictionary[Definitions.StageID.SkyTroops]               = "Sky Troops";
            Dictionary[Definitions.StageID.MadMatrix]               = "Mad Matrix";
            Dictionary[Definitions.StageID.DeathRuins]              = "Death Ruins";

            Dictionary[Definitions.StageID.HeavyDog]                = "Heavy Dog";
            Dictionary[Definitions.StageID.MadMatrixEggBreaker]     = "Egg Breaker (Mad Matrix)";
            Dictionary[Definitions.StageID.DeathRuinsBlackBull]     = "Black Bull (Death Ruins)";

            Dictionary[Definitions.StageID.TheARK]                  = "The ARK";
            Dictionary[Definitions.StageID.AirFleet]                = "Air Fleet";
            Dictionary[Definitions.StageID.IronJungle]              = "Iron Jungle";
            Dictionary[Definitions.StageID.SpaceGadget]             = "Space Gadget";
            Dictionary[Definitions.StageID.LostImpact]              = "Lost Impact";

            Dictionary[Definitions.StageID.BlueFalcon]              = "Blue Falcon";
            Dictionary[Definitions.StageID.IronJungleEggBreaker]    = "Egg Breaker (Iron Jungle)";

            Dictionary[Definitions.StageID.GUNFortress]             = "GUN Fortress";
            Dictionary[Definitions.StageID.BlackComet]              = "Black Comet";
            Dictionary[Definitions.StageID.LavaShelter]             = "Lava Shelter";
            Dictionary[Definitions.StageID.CosmicFall]              = "Cosmic Fall";
            Dictionary[Definitions.StageID.FinalHaunt]              = "Final Haunt";

            Dictionary[Definitions.StageID.GUNFortressBlackDoom]    = "Black Doom (GUN Fortress)";
            Dictionary[Definitions.StageID.GUNFortressDiablon]      = "Diablon (GUN Fortress)";
            Dictionary[Definitions.StageID.BlackCometEggDealer]     = "Egg Dealer (Black Comet)";
            Dictionary[Definitions.StageID.BlackCometDiablon]       = "Diablon (Black Comet)";
            Dictionary[Definitions.StageID.LavaShelterEggDealer]    = "Egg Dealer (Lava Shelter)";
            Dictionary[Definitions.StageID.CosmicFallEggDealer]     = "Egg Dealer (Cosmic Fall)";
            Dictionary[Definitions.StageID.CosmicFallBlackDoom]     = "Black Doom (Cosmic Fall)";
            Dictionary[Definitions.StageID.FinalHauntBlackDoom]     = "Black Doom (Final Haunt)";
            Dictionary[Definitions.StageID.FinalHauntDiablon]       = "Diablon (Final Haunt)";

            Dictionary[Definitions.StageID.TheLastWay]              = "The Last Way";
            Dictionary[Definitions.StageID.DevilDoom]               = "Devil Doom";

            Dictionary[Definitions.StageID.TwoPlayerStageOne]       = "2P GUN Fortress A";
            Dictionary[Definitions.StageID.TwoPlayerStageTwo]       = "2P GUN Fortress B";
            Dictionary[Definitions.StageID.TwoPlayerStageThree]     = "2P Lava Shelter";

            Dictionary[Definitions.StageID.RemovedTestLevelSTG6000] = "Removed/Empty Test Level [STG6000]";
            Dictionary[Definitions.StageID.HeroesAssetsLevel]       = "Heroes Assets Test Level [STG9900] (GameCube Only)";
            Dictionary[Definitions.StageID.ProtoShadowCreationRoom] = "Prototype Shadow Creation Room [STG9901]";
        }
    }
}
