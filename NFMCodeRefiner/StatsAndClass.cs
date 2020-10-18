using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFMCodeRefiner {
    class StatsAndClass {
        // the summary of the 5 stats gives the class, but it has to be exactly the category's predefined number (the combination doesn't matter)
        // example: stat(198,198,140,67,77)

        // ! min and max values are almost meaningless here, the game only accepts these values if their sum matches a possible clas
        public int Speed { get; set; } // minimum: 16 maximum: 200
        public int Accel { get; set; } // minimum: 16 maximum: 200
        public int Stunts { get; set; } // minimum: 16 maximum: 200 
        public int Strength { get; set; } // minimum: 16 maximum: 200
        public int Endurance { get; set; } // minimum: 16 maximum: 200
        public int[] PossibleClasses { get; set; } // [C: 520 points] [B and C: 560 points] [B: 600 points] [A and B: 640 points] [A: 680 points]

        public StatsAndClass(string row) {
            // pass anything other than "stat(" in the row to use example stats
            if(row.StartsWith("stat(")) {
                PossibleClasses = new int[] { 520, 560, 600, 640, 680 };
                string[] stats = row.Split('(', ')')[1].Split(','); // extracts the content of the parentheses, then splits that by the ',' character to get the stats seperately
                Speed = Int32.Parse(stats[0]);
                Accel = Int32.Parse(stats[1]);
                Stunts = Int32.Parse(stats[2]);
                Strength = Int32.Parse(stats[3]);
                Endurance = Int32.Parse(stats[4]);
            }
            else { // fill up stats with the example if input isn't correct
                Speed = 198;
                Accel = 198;
                Stunts = 140;
                Strength = 67;
                Endurance = 77;
            }
        }

        public int GetClass => Speed+Accel+Stunts+Strength+Endurance; // returns the current class number
    }
}
