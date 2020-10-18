using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NFMCodeRefiner
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            Testing();
            // Plans: Mirroring polygons, editing each poly, bulk adding/removing poly effects, stat editing, etc...
            // 10 hours wasted from my life, for a game no one's playing, but honestly, I don't care...
        }

        static void Testing() {
            // get the car code processed
            List<string> raw = new List<string>();
            foreach(string line in File.ReadAllLines("testcar.rad")) {
                raw.Add(line);
            }
            Car car = new Car(raw);
            raw.Clear();
            // write the test result (building the car code again, but differently to see potential errors)
            StreamWriter wr = new StreamWriter("testOutput.txt");
            wr.WriteLine($"// Car scale:   X: {car.Scale[0]}  Y: {car.Scale[1]}  Z: {car.Scale[2]}");
            wr.WriteLine($"// Car colors:   1st: {car.FirstColor}   2nd: {car.SecondColor}");
            wr.WriteLine($"// Rim format:   {(car.Rims.NewRimFormat ? "new" : "old")}");
            wr.WriteLine($"// Car handbrake:   {car.Physics.Handbrake}");
            wr.WriteLine($"// Car TurningSens:   {car.Physics.TurningSens}");
            wr.WriteLine($"// Car TireGrip:   {car.Physics.TireGrip}");
            wr.WriteLine($"// Car Bouncing:   {car.Physics.Bouncing}");
            wr.WriteLine($"// Car Unknown1:   {car.Physics.Unknown1}");
            wr.WriteLine($"// Car LiftsOthers:   {car.Physics.LiftsOthers}");
            wr.WriteLine($"// Car GetsLifted:   {car.Physics.GetsLifted}");
            wr.WriteLine($"// Car PushesOthers:   {car.Physics.PushesOthers}");
            wr.WriteLine($"// Car GetsPushed:   {car.Physics.GetsPushed}");
            wr.WriteLine($"// Car AerialRotationSpeed:   {car.Physics.AerialRotationSpeed}");
            wr.WriteLine($"// Car CrashRadius:   {car.Physics.CrashRadius}");
            wr.WriteLine($"// Car CrashMagnitude:   {car.Physics.CrashMagnitude}");
            wr.WriteLine($"// Car RoofDestruction:   {car.Physics.RoofDestruiction}");
            wr.WriteLine($"// Car Engine type:   {car.Physics.EngineType}");
            wr.WriteLine($"// Car Health:   {car.Physics.Health}");
            wr.WriteLine();
            // polys
            foreach(Polygon item in car.Polygons) {
                wr.WriteLine("\n<p>");
                wr.WriteLine($"c({item.PolyColor.R},{item.PolyColor.G},{item.PolyColor.B})");
                foreach(int[] points in item.PolyPoints) {
                    wr.WriteLine($"p({points[0]},{points[1]},{points[2]})");
                }
                wr.WriteLine("</p>");
            }
            // wheels
            wr.WriteLine();
            if(car.Rims.NewRimFormat) {
                // new structure, divided into wheelpairs (front --> rear)
                // front pair
                wr.WriteLine($"gwgr({car.Rims.Hide[0]})");
                wr.WriteLine($"rims({car.Rims.RimDesigns[0].Color.R},{car.Rims.RimDesigns[0].Color.G},{car.Rims.RimDesigns[0].Color.B},{car.Rims.RimDesigns[0].Size},{car.Rims.RimDesigns[0].Depth}");
                wr.WriteLine($"w({car.Rims.Wheels[0].Pos[0]},{car.Rims.Wheels[0].Pos[1]},{car.Rims.Wheels[0].Pos[2]},{car.Rims.Wheels[0].Rotates},{car.Rims.Wheels[0].Width},{car.Rims.Wheels[0].Height})");
                wr.WriteLine($"w({car.Rims.Wheels[1].Pos[0]},{car.Rims.Wheels[1].Pos[1]},{car.Rims.Wheels[1].Pos[2]},{car.Rims.Wheels[1].Rotates},{car.Rims.Wheels[1].Width},{car.Rims.Wheels[1].Height})");
                // rear pair
                wr.WriteLine($"gwgr({car.Rims.Hide[1]})");
                wr.WriteLine($"rims({car.Rims.RimDesigns[1].Color.R},{car.Rims.RimDesigns[1].Color.G},{car.Rims.RimDesigns[1].Color.B},{car.Rims.RimDesigns[1].Size},{car.Rims.RimDesigns[1].Depth}");
                wr.WriteLine($"w({car.Rims.Wheels[2].Pos[0]},{car.Rims.Wheels[2].Pos[1]},{car.Rims.Wheels[2].Pos[2]},{car.Rims.Wheels[2].Rotates},{car.Rims.Wheels[2].Width},{car.Rims.Wheels[2].Height})");
                wr.WriteLine($"w({car.Rims.Wheels[3].Pos[0]},{car.Rims.Wheels[3].Pos[1]},{car.Rims.Wheels[3].Pos[2]},{car.Rims.Wheels[3].Rotates},{car.Rims.Wheels[3].Width},{car.Rims.Wheels[3].Height})");
            }
            else {
                // old structure, rims-gwgr-4wheels under each other
                wr.WriteLine($"rims({car.Rims.RimDesigns[0].Color.R},{car.Rims.RimDesigns[0].Color.G},{car.Rims.RimDesigns[0].Color.B},{car.Rims.RimDesigns[0].Size},{car.Rims.RimDesigns[0].Depth}");
                wr.WriteLine($"gwgr({car.Rims.Hide[0]})");
                wr.WriteLine($"w({car.Rims.Wheels[0].Pos[0]},{car.Rims.Wheels[0].Pos[1]},{car.Rims.Wheels[0].Pos[2]},{car.Rims.Wheels[0].Rotates},{car.Rims.Wheels[0].Width},{car.Rims.Wheels[0].Height})");
                wr.WriteLine($"w({car.Rims.Wheels[1].Pos[0]},{car.Rims.Wheels[1].Pos[1]},{car.Rims.Wheels[1].Pos[2]},{car.Rims.Wheels[1].Rotates},{car.Rims.Wheels[1].Width},{car.Rims.Wheels[1].Height})");
                wr.WriteLine($"w({car.Rims.Wheels[2].Pos[0]},{car.Rims.Wheels[2].Pos[1]},{car.Rims.Wheels[2].Pos[2]},{car.Rims.Wheels[2].Rotates},{car.Rims.Wheels[2].Width},{car.Rims.Wheels[2].Height})");
                wr.WriteLine($"w({car.Rims.Wheels[3].Pos[0]},{car.Rims.Wheels[3].Pos[1]},{car.Rims.Wheels[3].Pos[2]},{car.Rims.Wheels[3].Rotates},{car.Rims.Wheels[3].Width},{car.Rims.Wheels[3].Height})");
            }
            // stats
            wr.WriteLine($"\n//Speed:   {car.StatsAndClass.Speed}");
            wr.WriteLine($"//Accel:   {car.StatsAndClass.Accel}");
            wr.WriteLine($"//Stunts:   {car.StatsAndClass.Stunts}");
            wr.WriteLine($"//Strength:   {car.StatsAndClass.Strength}");
            wr.WriteLine($"//Endurance:   {car.StatsAndClass.Endurance}");
            wr.WriteLine($"//Class:   {car.StatsAndClass.GetClass}");
            wr.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) {

        }
    }
}
