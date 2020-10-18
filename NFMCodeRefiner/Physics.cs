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
            if(row.StartsWith("physics(")) {
                string[] physics = row.Split('(', ')')[1].Split(',');
                Handbrake = Int32.Parse(physics[0]);
                TurningSens = Int32.Parse(physics[1]);
                TireGrip = Int32.Parse(physics[2]);
                Bouncing = Int32.Parse(physics[3]);
                Unknown1 = Int32.Parse(physics[4]);
                LiftsOthers = Int32.Parse(physics[5]);
                GetsLifted = Int32.Parse(physics[6]);
                PushesOthers = Int32.Parse(physics[7]);
                GetsPushed = Int32.Parse(physics[8]);
                AerialRotationSpeed = Int32.Parse(physics[9]);
                AerialControlGliding = Int32.Parse(physics[10]);
                CrashRadius = Int32.Parse(physics[11]);
                CrashMagnitude = Int32.Parse(physics[12]);
                RoofDestruiction = Int32.Parse(physics[13]);
                EngineType = Int32.Parse(physics[14]);
                Health = Int32.Parse(physics[15]);
            }
            else { // example fill up if input isn't correct
                Handbrake = 100;
                TurningSens = 100;
                TireGrip = 100;
                Bouncing = 22;
                Unknown1 = 50;
                LiftsOthers = 0;
                GetsLifted = 0;
                PushesOthers = 0;
                GetsPushed = 0;
                AerialRotationSpeed = 78;
                AerialControlGliding = 100;
                CrashRadius = 636;
                CrashMagnitude = 6;
                RoofDestruiction = 0;
                EngineType = 1;
                Health = 39461;
            }
        }
    }
}
