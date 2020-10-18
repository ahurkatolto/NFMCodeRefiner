using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NFMCodeRefiner {
    // each polygon's code structure   example: <p> c(R,G,B) p(x,y,z) p(x,y,z) p(x,y,z) ... p(x,y,z) </p>
    class Polygon {
        public Color PolyColor { get; set; } // color of the poly: R,G,B (if non-defined in the code, RGB(0,0,0) black in-game)
        public List<int[]> PolyPoints { get; set; } // list of the polygon's points (each point: [x,y,z])   example: p(-119,-78,388)
        public bool GrBool { get; set; } // does the poly contain gr()?
        public int Gr { get; set; } // gr() - defines grounding (takes integer arguements)                  example: gr(100)
        public bool FsBool { get; set; } // does the poly contain fs()?
        public int Fs { get; set; } // fs() - defines face shading (takes integer arguements)               example: fs(10)
        public bool NoOutline { get; set; } // noOutline() - hides polygon outline (takes no arguments)

        public Polygon(List<string> rows) {
            // predefine values
            GrBool = false;
            FsBool = false;
            NoOutline = false;
            Gr = 0;
            Fs = 0;
            PolyColor = Color.FromArgb(0,0,0);
            // set variable to merge them later with the properties
            List<int[]> polypoints = new List<int[]>();
            // scan each line within the <p></p> tags sent by Car.cs
            foreach(string line in rows) {
                // if it's a color line, set the color
                if(line.StartsWith("c(")) {
                    string[] RGBColors = line.Split('(',')')[1].Split(',');
                    PolyColor = Color.FromArgb( Int32.Parse(RGBColors[0]), Int32.Parse(RGBColors[1]), Int32.Parse(RGBColors[2]) );
                }
                // if not, check if it's a point of the polygon
                else if(line.StartsWith("p(")) {
                    string[] pointCoordinates = line.Split('(',')')[1].Split(',');
                    polypoints.Add( new int[] { Int32.Parse(pointCoordinates[0]), Int32.Parse(pointCoordinates[1]), Int32.Parse(pointCoordinates[2]) } );
                }
                // if still not, check if it's an fs() value
                else if (line.StartsWith("fs(")) {
                    Fs = Int32.Parse(line.Split('(',')')[1]);
                    FsBool = true;
                }
                // if still not, check if it's a gr() value
                else if (line.StartsWith("gr(")) {
                    Gr = Int32.Parse(line.Split('(',')')[1]);
                    GrBool = true;
                }
                // if still not, check if it's a noOutline() statement
                else if(line.StartsWith("noOutline()")) {
                    NoOutline = true;
                }
                // if the line was none of these, skip it
            }
            PolyPoints = polypoints;
        }
    }
}
