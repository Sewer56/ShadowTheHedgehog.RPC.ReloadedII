using System.Collections.Generic;

namespace Dolphin.ShadowTheHedgehog.RPC.Shadow.Utilities
{
    public class ImageNameDictionary
    {
        /// <summary>
        /// Translates a Shadow The Hedgehog stage id to stage image.
        /// </summary>
        public static Dictionary<Definitions.StageID, string> Dictionary = new Dictionary<Definitions.StageID, string>(128);

        static ImageNameDictionary()
        {
            Dictionary[Definitions.StageID.TestLevel]               = "stg0000";
            Dictionary[Definitions.StageID.TestLevelSkatePark]      = "stg0001";
            Dictionary[Definitions.StageID.TestLevelUVTextureMap]   = "stg0003";
            Dictionary[Definitions.StageID.TestLevelSurfaceTest]    = "stg0002";
            Dictionary[Definitions.StageID.TestLevelCutsceneTest]   = "stg0005";

            Dictionary[Definitions.StageID.Westopolis]              = "westopolis";

            Dictionary[Definitions.StageID.DigitalCircuit]          = "digitalcircuit";
            Dictionary[Definitions.StageID.GlyphicCanyon]           = "glyphiccanyon";
            Dictionary[Definitions.StageID.LethalHighway]           = "lethalhighway";

            Dictionary[Definitions.StageID.LethalHighwayBlackBull]  = "lethalhighwayblackbull";

            Dictionary[Definitions.StageID.CrypticCastle]           = "crypticcastle";
            Dictionary[Definitions.StageID.PrisonIsland]            = "prisonisland";
            Dictionary[Definitions.StageID.CircusPark]              = "circuspark";

            Dictionary[Definitions.StageID.CrypticCastleEggBreaker] = "crypticcastleeggdealer";

            Dictionary[Definitions.StageID.CentralCity]             = "centralcity";
            Dictionary[Definitions.StageID.TheDoom]                 = "thedoom";
            Dictionary[Definitions.StageID.SkyTroops]               = "skytroops";
            Dictionary[Definitions.StageID.MadMatrix]               = "madmatrix";
            Dictionary[Definitions.StageID.DeathRuins]              = "deathruins";

            Dictionary[Definitions.StageID.HeavyDog]                = "thedoombluefalcon";
            Dictionary[Definitions.StageID.MadMatrixEggBreaker]     = "madmatrixeggbreaker";
            Dictionary[Definitions.StageID.DeathRuinsBlackBull]     = "deathruinsblackbull";

            Dictionary[Definitions.StageID.TheARK]                  = "theark";
            Dictionary[Definitions.StageID.AirFleet]                = "airfleet";
            Dictionary[Definitions.StageID.IronJungle]              = "ironjungle";
            Dictionary[Definitions.StageID.SpaceGadget]             = "spacegadget";
            Dictionary[Definitions.StageID.LostImpact]              = "lostimpact";

            Dictionary[Definitions.StageID.BlueFalcon]              = "thearkbluefalcon";
            Dictionary[Definitions.StageID.IronJungleEggBreaker]    = "ironfleeteggbreaker";

            Dictionary[Definitions.StageID.GUNFortress]             = "gunfortress";
            Dictionary[Definitions.StageID.BlackComet]              = "blackcomet";
            Dictionary[Definitions.StageID.LavaShelter]             = "lavashelter";
            Dictionary[Definitions.StageID.CosmicFall]              = "cosmicfall";
            Dictionary[Definitions.StageID.FinalHaunt]              = "finalhaunt";

            Dictionary[Definitions.StageID.GUNFortressBlackDoom]    = "gunfortressdoom";
            Dictionary[Definitions.StageID.GUNFortressDiablon]      = "gunfortressdiablon";
            Dictionary[Definitions.StageID.BlackCometEggDealer]     = "blackcometeggdealer";
            Dictionary[Definitions.StageID.BlackCometDiablon]       = "blackcometdiablon";
            Dictionary[Definitions.StageID.LavaShelterEggDealer]    = "lavasheltereggdealer";
            Dictionary[Definitions.StageID.CosmicFallEggDealer]     = "cosmicfalleggdealer";
            Dictionary[Definitions.StageID.CosmicFallBlackDoom]     = "cosmicfallblackdoom";
            Dictionary[Definitions.StageID.FinalHauntBlackDoom]     = "finalhauntdoom";
            Dictionary[Definitions.StageID.FinalHauntDiablon]       = "finalhauntdiablon";

            Dictionary[Definitions.StageID.TheLastWay]              = "thelastway";
            Dictionary[Definitions.StageID.DevilDoom]               = "devildoom";
            Dictionary[Definitions.StageID.HeroesAssetsLevel]       = "stg9900";
        }
    }
}
