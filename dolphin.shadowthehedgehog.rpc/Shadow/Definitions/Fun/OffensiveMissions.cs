namespace Dolphin.ShadowTheHedgehog.RPC.Shadow.Definitions.Fun
{
    /// <summary>
    /// List of offensive mission descriptions.
    /// Setting disabled by default for obvious reasons.
    /// </summary>
    public static class OffensiveMissions
    {
        // 100
        public static MissionDescription Westopolis = new MissionDescription()
        {
            Dark    = "Exterminating the FUCKING humans",
            Neutral = "FUCK'EM ALL, I WANT JEWELS",
            Hero    = "Removing ILLEGAL Aliens from City"
        };

        // 200
        public static MissionDescription DigitalCircuit = new MissionDescription()
        {
            Dark = "FUCKING up the CORE program.",
            Hero = "I like BATS with TITS"
        };

        public static MissionDescription GlyphicCanyon = new MissionDescription()
        {
            Dark    = "What the FUCK is THIS temple for!?",
            Neutral = "SHINY PRECIOUS JEWELS...",
            Hero    = "Removing ILLEGAL Aliens from TEMPLE (& KNUCKLES)",
        };

        public static MissionDescription LethalHighway = new MissionDescription()
        {
            Dark = "Escaping city like a PUSSY",
            Hero = "FUCKING ALIEN needs his PARKING TICKET"
        };

        // 300
        public static MissionDescription CrypticCastle = new MissionDescription()
        {
            Dark    = "Nani da foc u need Lanternz For!?",
            Neutral = "This place is SPOOPY, Gotta GTFO!",
            Hero    = "Showing AFFECTION to FEMALE HEDGEHOG (Gone Sexual)",
        };

        public static MissionDescription PrisonIsland = new MissionDescription()
        {
            Dark    = "FUCKING-OVER HUMANS",
            Neutral = "Adding CHAOS TITTY to collection.",
            Hero    = "Collecting TOP SECRET DICKS",
        };

        public static MissionDescription CircusPark = new MissionDescription()
        {
            Dark    = "FUCKING over GUN geeks.",
            Neutral = "D.A.M.N. FOURTH CHAOS EMERALD",
            Hero    = "Making EGGHEAD BANKRUPT",
        };

        // 400
        public static MissionDescription CentralCity = new MissionDescription()
        {
            Dark    = "7/7 London but Better!",
            Hero    = "And the fuck I do with Big Bombs!?"
        };

        public static MissionDescription TheDoom = new MissionDescription()
        {
            Dark    = "EXTERMINATING FUCKING humans in SPACE",
            Neutral = "THIS VIRGIN'S MINE",
            Hero    = "SAVING WEAK RESEARCHER PUSSIES",
        };

        public static MissionDescription SkyTroops = new MissionDescription()
        {
            Dark    = "BLOWING FUCKING battleships is FUN",
            Neutral = "Have I seen this FUCKING sky before!?",
            Hero    = "DESTROYING GLOWING BALLZ",
        };

        public static MissionDescription MadMatrix = new MissionDescription()
        {
            Dark    = "DESTROYING HENTAI STASH in TERMINALS",
            Neutral = "FUCKING the HENTAI STASH",
            Hero    = "EXTRACTING HENTAI STASH from TERMINALS"
        };

        public static MissionDescription DeathRuins = new MissionDescription()
        {
            Dark    = "DOOM'S A PUSSY WHEN PINNED",
            Hero    = "REMOVING ILLEGAL Aliens from JUNGLE"
        };

        // 500
        public static MissionDescription TheArk = new MissionDescription()
        {
            Dark    = "Preparing EARTH for INDEPENDENCE DAY",
            Hero    = "THIS LEVEL IS FUCKING EASY"
        };

        public static MissionDescription AirFleet = new MissionDescription()
        {
            Dark    = "FUCKING KILLING WORLD LEADER",
            Neutral = "COLLECTING CHAOS TITTY",
            Hero    = "REMOVING ILLEGAL ALIENS FROM SHIP"
        };

        public static MissionDescription IronJungle = new MissionDescription()
        {
            Dark    = "GUN are a FUCKING PISS in the ARSE",
            Neutral = "PENETRATING outer perimeter of BASE",
            Hero    = "THIS AIRSHIP SUCKS ASS"
        };
        
        public static MissionDescription SpaceGadget = new MissionDescription()
        {
            Dark    = "FUCKING DESTROYING THE ARK",
            Neutral = "FUCK THIS DUDE; I WANT CHAOS TITTY",
            Hero    = "RACING THAT FUCKING SLOWPOKE"
        };

        public static MissionDescription LostImpact = new MissionDescription()
        {
            Dark    = "I DON'T NEED ANY MORE RULE34",
            Hero    = "Ejaculating Gerald's BLUE JIZZ from ARK"
        };

        // 600
        public static MissionDescription GunFortress = new MissionDescription()
        {
            Dark = "FUCK THESE FUCKING HUMANS",
            Hero = "BAT TITS > REST OF WORLD"
        };

        public static MissionDescription BlackComet = new MissionDescription()
        {
            Dark = "FUCKING GUN COCKSUCKERS",
            Hero = "ESCAPING JIZZ FILLED COMET"
        };

        public static MissionDescription LavaShelter = new MissionDescription()
        {
            Dark = "BITCH there's no FUCKING GUN benchods here",
            Hero = "CYKA BLYAT you inferior METAL SHIT"
        };

        public static MissionDescription CosmicFall = new MissionDescription()
        {
            Dark = "WHO THE FUCK CARES",
            Hero = "THE COMPUTER ROOM!!"
        };

        public static MissionDescription FinalHaunt = new MissionDescription()
        {
            Dark = "GIVING THIS PUSSY HIS SHIELDS",
            Hero = "FINDING BLACK ILLEGAL ALIEN"
        };

        /// <summary>
        /// This method is quite ugly. The quality of it is the same as the edginess of this class.
        /// </summary>
        public static string GetDescription(StageID stageId, CurrentMission mission)
        {
            switch (stageId)
            {
                // 100
                case StageID.Westopolis:
                    return Westopolis.GetDescription(mission);
                
                // 200
                case StageID.DigitalCircuit:
                    return DigitalCircuit.GetDescription(mission);
                case StageID.GlyphicCanyon:
                    return GlyphicCanyon.GetDescription(mission);
                case StageID.LethalHighway:
                    return LethalHighway.GetDescription(mission);

                // 300
                case StageID.CrypticCastle:
                    return CrypticCastle.GetDescription(mission);
                case StageID.PrisonIsland:
                    return PrisonIsland.GetDescription(mission);
                case StageID.CircusPark:
                    return CircusPark.GetDescription(mission);

                // 400
                case StageID.CentralCity:
                    return CentralCity.GetDescription(mission);
                case StageID.TheDoom:
                    return TheDoom.GetDescription(mission);
                case StageID.SkyTroops:
                    return SkyTroops.GetDescription(mission);
                case StageID.MadMatrix:
                    return MadMatrix.GetDescription(mission);
                case StageID.DeathRuins:
                    return DeathRuins.GetDescription(mission);

                // 500
                case StageID.TheARK:
                    return TheArk.GetDescription(mission);
                case StageID.AirFleet:
                    return AirFleet.GetDescription(mission);
                case StageID.IronJungle:
                    return IronJungle.GetDescription(mission);
                case StageID.SpaceGadget:
                    return SpaceGadget.GetDescription(mission);
                case StageID.LostImpact:
                    return LostImpact.GetDescription(mission);

                // 600
                case StageID.GUNFortress:
                    return GunFortress.GetDescription(mission);
                case StageID.BlackComet:
                    return BlackComet.GetDescription(mission);
                case StageID.LavaShelter:
                    return LavaShelter.GetDescription(mission);
                case StageID.CosmicFall:
                    return CosmicFall.GetDescription(mission);
                case StageID.FinalHaunt:
                    return FinalHaunt.GetDescription(mission);
            }

            return "";
        }
    }
}
