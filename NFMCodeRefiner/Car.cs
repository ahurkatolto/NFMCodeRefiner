using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NFMCodeRefiner {
    // The main code structure of a car's 3D model code (later mentioned as "car codes")
    // car codes also have comments, just like here
    class Car {
        public bool NewStone { get; set; } // hides all polygons' outlines which are placed after this statement
        public int[] Scale { get; set; } // scale of the model in dimensions: [x,y,z] - default: 100 (=1,00) min: 0 (=0,00)     examples:   ScaleZ(100)   ScaleY(100)   ScaleX(100)
        public Color FirstColor { get; set; } // defines 1 of the 2 editable colors for the game     example: 1stColor(142,142,142)
        public Color SecondColor { get; set; } // defines 1 of the 2 editable colors for the game    example: 2ndColor(58,58,58)
        public List<Polygon> Polygons { get; set; } // each polygon's code structure                 example: <p> c(R,G,B) p(x,y,z) p(x,y,z) p(x,y,z) ... p(x,y,z) </p>
        public Physics Physics { get; set; } // the physics of the car in the right order            example: physics(100,100,100,22,50,0,0,0,0,78,100,636,6,0,1,39461)
        public int Handling { get; set; } // handling, default range: 50-200                         example: handling(198)
        public StatsAndClass StatsAndClass { get; set; } // the car's stats                          example: stat(198,198,140,67,77)
        public Rims Rims { get; set;}
        // wheels
        public Car(List<string> rows) {
            // set defaults
            NewStone = false;
            Scale = new int[] {100,100,100};
            FirstColor = Color.FromArgb(142,142,142);
            SecondColor = Color.FromArgb(58,58,58);
            Physics = new Physics("none");
            Handling = 198;
            StatsAndClass = new StatsAndClass("none");
            List<string> noneList = new List<string>() {"none"};
            Rims = new Rims(noneList);
            // predefine variables to merge them later
            List<Polygon> polygons = new List<Polygon>();
            // some useful variables for later, and a list for grouping lines together to send them to constructors later (!needs emptying after each send)
            bool caching = false;
            int wheelCount = 0;
            List<string> cachedLines = new List<string>();
            // scanning lines
            foreach(string line in rows) {
                // check for newStone()
                if(line.StartsWith("newstone()")) {
                    NewStone = true;
                }
                // check for scales
                else if(line.StartsWith("Scale")) {
                    string[] splitLine = line.Split('(', ')');
                    switch(splitLine[0]) {
                        case "ScaleZ": Scale[0] = Int32.Parse(splitLine[1]); break;
                        case "ScaleY": Scale[1] = Int32.Parse(splitLine[1]); break;
                        case "ScaleX": Scale[2] = Int32.Parse(splitLine[1]); break;
                    }
                }
                // check for 1stColor line
                else if(line.StartsWith("1stColor")) {
                    string[] splitLine = line.Split('(', ')')[1].Split(',');
                    FirstColor = Color.FromArgb(Int32.Parse(splitLine[0]), Int32.Parse(splitLine[1]), Int32.Parse(splitLine[2]));
                }
                // check for 2ndColor line
                else if(line.StartsWith("2ndColor")) {
                    string[] splitLine = line.Split('(', ')')[1].Split(',');
                    SecondColor = Color.FromArgb(Int32.Parse(splitLine[0]), Int32.Parse(splitLine[1]), Int32.Parse(splitLine[2]));
                }
                // check for handling line
                else if(line.StartsWith("handling")) {
                    string[] splitLine = line.Split('(', ')')[1].Split(',');
                    Handling = Int32.Parse(splitLine[0]);
                }
                // check for physics
                else if (line.StartsWith("physics")) {
                    Physics = new Physics(line);
                }
                // check for stats and class
                else if (line.StartsWith("stat")) {
                    StatsAndClass = new StatsAndClass(line);
                }


                //// CONFUSING PART - caching into [List<string> cachedLines], then emptying it after the final value returned!
                if (wheelCount == 4) {
                    caching = false;
                    wheelCount = 0;
                    Rims = new Rims(cachedLines);
                    cachedLines.Clear();
                }
                //// check for Polygon starts, and if found, start caching
                else if (line.StartsWith("<p>")) {
                    caching = true;
                }
                else if (line.StartsWith("</p>")) {
                    // send cache to Polygon constructor, and stop caching
                    caching = false;
                    polygons.Add(new Polygon(cachedLines));
                    cachedLines.Clear();
                }
                //// check for the wheels
                else if (line.StartsWith("gwgr") || line.StartsWith("rims")) { caching = true; }
                else if (line.StartsWith("w(")) { wheelCount++; }
                if (caching) { cachedLines.Add(line); }
            }
            Polygons = polygons;
        }

        public void Import() {
            
        }
        public void Export() {
            
        }
    }
}
