using System;
using System.Collections.Generic;
using System.Text;

namespace Dolphin.ShadowTheHedgehog.RPC.Shadow.Definitions.Fun
{
    public class MissionDescription
    {
        public const string Default = "";

        public string Dark = Default;
        public string Neutral = Default;
        public string Hero = Default;

        public string GetDescription(CurrentMission mission)
        {
            switch (mission)
            {
                case CurrentMission.Dark:
                    return Dark;
                case CurrentMission.Neutral:
                    return Neutral;
                case CurrentMission.Hero:
                    return Hero;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mission), mission, null);
            }
        }
    }
}
