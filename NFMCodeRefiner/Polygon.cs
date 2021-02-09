using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NFMCodeRefiner {
    class Polygon {                                  // each polygon's code structure                           example: <p> p(-42,19,-13) p(-48,23,-11) p(-48,26,47) p(-45,23,43) </p>
        public Color Color { get; set; }             // color of the poly: R,G,B (RGB(0,0,0) in-game default)   example: c(166,208,248)
        public List<int[]> PolyPoints { get; set; }  // list of the polygon's points (each point: [x,y,z])      example: p(-119,-78,388)
        public bool HasGr { get; set; }
        public int Gr { get; set; }                  // defines grounding (takes integer arguements)            example: gr(100)
        public bool HasFs { get; set; }
        public int Fs { get; set; }                  // defines face shading (takes integer arguements)         example: fs(10)
        public bool NoOutline { get; set; }          // hides polygon outline (takes no arguments)              example: noOutline()
        
        public Polygon(List<string> rows) {
            HasGr = rows.Where(s => s.StartsWith("gr(")).Count() > 0;
            Gr = HasGr ? int.Parse( rows.Where(s => s.StartsWith("gr(")).First().Split('(',')')[1] ) : 0;

            HasFs = rows.Where(s => s.StartsWith("fs(")).Count() > 0;
            Fs = HasFs ? int.Parse( rows.Where(s => s.StartsWith("fs(")).First().Split('(',')')[1] ) : 0;

            NoOutline = rows.Where(s => s.StartsWith("noOutline()")).Count() > 0;

            int[] color = rows.Where(s => s.StartsWith("c(")).Count()>0 ? rows.Where(s => s.StartsWith("c(")).First().Split('(',')')[1].Split(',').Select(s => int.Parse(s)).ToArray() : new int[3];
            Color = Color.FromArgb(color[0],color[1],color[2]);

            PolyPoints = rows.Where(line => line.StartsWith("p(")).Select( p => p.Split('(',')')[1].Split(',').Select(i => int.Parse(i)).ToArray() ).ToList();
        }
    }
}
