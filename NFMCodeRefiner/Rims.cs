using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NFMCodeRefiner {
    /* --- OLD RIMS: ---
    rims([color],size,depth)   example: rims(214,228,255,24,10)
    gwgr(int)                  example: gwgr(40)
    w(cx,cy,cz,rotates,w,h)    example: w(-48,20,67,11,19,14)
    w(cx,cy,cz,rotates,w,h)
    w(cx,cy,cz,rotates,w,h)    (wheel order doesn't matter)
    w(cx,cy,cz,rotates,w,h)

       --- NEW RIMS: ---
    FRONT PAIR:
    gwgr(40)
    rims(230,230,230,22,10)   front pair's (R,G,B,size,depth)
    w(-68,3,130,11,26,21)     front-left rim    w(x,y,z,rotates,width,height)
    w(68,3,130,11,-26,21)     front-right rim   w(x,y,z,rotates,width,height)

    REAR PAIR:
    gwgr(40)
    rims(230,230,230,24,10)   rear pair's (R,G,B,size,depth)
    w(-66,4,-84,0,35,23)      rear-left rim     w(x,y,z,rotates,width,height)
    w(66,4,-84,0,-35,23)      rear-right rim    w(x,y,z,rotates,width,height)
    */
    class Rims {
        public bool NewRimFormat { get; set; } //   false: old (original cars)   true: new (custom cars)   (look above for differences between the formats)
        public List<int> Hide { get; set; } // contains 1 or 2 gwgr values, depending on NewRimFormat
        public List<RimDesign> RimDesigns { get; set; } // contains 1 or 2 rim designs, depending on NewRimFormat
        public List<Wheel> Wheels { get; set; } // contains 4 wheels
        public Rims(List<string> rows) {
            // check if there are any wheel codes at all, if not, add examples
            if(rows[0]=="none") {
                NewRimFormat = true;
                Hide = new List<int>() {40,40};
                RimDesigns = new List<RimDesign>() {
                    new RimDesign("rims(230,230,230,22,10)"),
                    new RimDesign("rims(230,230,230,24,10)")
                };
                Wheels = new List<Wheel>() {
                    new Wheel("w(-68,3,130,11,26,21)"),
                    new Wheel("w(68,3,130,11,-26,21)"),
                    new Wheel("w(-66,4,-84,0,35,23)"),
                    new Wheel("w(66,4,-84,0,-35,23)")
                };
            }
            else {
                List<Wheel> wheels = new List<Wheel>();
                List<RimDesign> rimdesigns = new List<RimDesign>();
                List<int> hide = new List<int>();
                byte gwgrCount = 0;
                byte rimsCount = 0;
                foreach (string line in rows) {
                    // check for rim design line
                    if (line.StartsWith("rims(")) {
                        rimdesigns.Add(new RimDesign(line));
                        rimsCount++;
                    }
                    // if not, check for wheel declaration line
                    else if (line.StartsWith("w(")) {
                        wheels.Add(new Wheel(line));
                    }
                    // if not, check for gwgr value
                    else if (line.StartsWith("gwgr")) {
                        hide.Add(Int32.Parse(line.Split('(',')')[1]));
                        gwgrCount++;
                    }
                    // if not, check the line isn't useful, skip to the next
                }
                NewRimFormat = rimsCount>1 || gwgrCount>1 ? true : false; // if there's more than one gwgr or rims line in the code, the rims are in new format
                Wheels = wheels;
                RimDesigns = rimdesigns;
                Hide = hide;
            }
        }
    }

    class Wheel {
        public int[] Pos { get; set; } // X,Y,Z
        public int Rotates { get; set; } // whatever it does...
        public int Width { get; set; }
        public int Height { get; set; }
        public Wheel(string row) {
            // FORMAT: w(x,y,z,rotates,width,height)
            string[] parsedRow = row.Split('(',')')[1].Split(',');
            int[] pos = new int[] { Int32.Parse(parsedRow[0]) , Int32.Parse(parsedRow[1]) , Int32.Parse(parsedRow[2]) };
            Rotates = Int32.Parse(parsedRow[3]);
            Width = Int32.Parse(parsedRow[4]);
            Height = Int32.Parse(parsedRow[5]);
            Pos = pos;
        }
    }

    class RimDesign {
        public Color Color { get; set; }
        public int Size { get; set; }
        public int Depth { get; set; }
        public RimDesign(string row) {
            // FORMAT: rims(R,G,B,size,depth)
            string[] parsedRow = row.Split('(',')')[1].Split(',');
            Color = Color.FromArgb(Int32.Parse(parsedRow[0]), Int32.Parse(parsedRow[1]), Int32.Parse(parsedRow[2]));
            Size = Int32.Parse(parsedRow[3]);
            Depth = Int32.Parse(parsedRow[4]);
        }
    }
}
