using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFMCodeRefiner {
    // the physics of the car in the right order   example: physics(100,100,100,22,50,0,0,0,0,78,100,636,6,0,1,39461)
    class Physics {
        public int Handbrake { get; set; } // 0-100 by default
        public int TurningSens { get; set; } // 0-100 by default
        public int TireGrip { get; set; } // 0-100 by default
        public int Bouncing { get; set; } // 0-100 by default
        public int Unknown1 { get; set; } // unknown value, set to 0 by the game (maybe an indicator of something)
        public int LiftsOthers { get; set; } // 0-100 by default
        public int GetsLifted { get; set; } // 0-100 by default
        public int PushesOthers { get; set; } // 0-100 by default
        public int GetsPushed { get; set; } // 0-100 by default
        public int AerialRotationSpeed { get; set; } // 0-100 by default
        public int AerialControlGliding { get; set; } // 0-100 by default
        public int CrashRadius { get; set; } // 0-100 by default
        public int CrashMagnitude { get; set; } // 0-100 by default
        public int RoofDestruiction { get; set; } // 0-100 by default
        public int EngineType { get; set; } // Engine type:  0: Normal   1: V8   2: Retro   3: Power   4: Diesel   (could be byte, but for simplicity I use int)
        public int Health { get; set; } // last value, appears to be the health, but I'm not sure (minimum 1, maximum unknown)

        public Physics(string row) {
            int[] physics = row.StartsWith("physics(") ? row.Split('(',')')[1].Split(',').Select(s => int.Parse(s)).ToArray() : new int[16]{100,100,100,22,50,0,0,0,0,78,100,626,6,0,1,39461};
            Handbrake = physics[0];
            TurningSens = physics[1];
            TireGrip = physics[2];
            Bouncing = physics[3];
            Unknown1 = physics[4];
            LiftsOthers = physics[5];
            GetsLifted = physics[6];
            PushesOthers = physics[7];
            GetsPushed = physics[8];
            AerialRotationSpeed = physics[9];
            AerialControlGliding = physics[10];
            CrashRadius = physics[11];
            CrashMagnitude = physics[12];
            RoofDestruiction = physics[13];
            EngineType = physics[14];
            Health = physics[15];
        }
    }
}
