using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Gade_Assignment_1
{
    class Map 
    {
        public Map()
        {
            rangedUnits = new List<RangedUnit>();
            meleeUnits = new List<MeleeUnit>();
        }

        public enum Direction
        {
            North,
            South,
            East,
            West
        }

        public string[,] map1 = new string[20,20];


        public List<Unit> units = new List<Unit>();
        public List<RangedUnit> rangedUnits;
        public List<MeleeUnit> meleeUnits;
        public Random r = new Random();
        //variables storying how many units to spawn.
        int ranged_unit_amount= 10;
        int melee_unit_amount= 10;
 
        public void UnitGeneration()
        {
            int randomXposition;
            int randomYposition;
            for (int i = 0; i < melee_unit_amount; i++)
            {
                randomXposition = r.Next(1,19);
                randomYposition = r.Next(1,19);
                MeleeUnit M = new MeleeUnit(randomXposition, randomYposition, 50, 10, 1, 1, "o/*", false);
                meleeUnits.Add(M);
                units.Add(M);
            }
            for (int i = 0; i < ranged_unit_amount; i++)
            {
                randomXposition = r.Next(1, 19);
                randomYposition = r.Next(1, 19);
                RangedUnit R = new RangedUnit(randomXposition, randomYposition, 50, 10, 5, 1, "o|}", false);
                rangedUnits.Add(R);
                units.Add(R);
            }
        }
        public string DisplayMap()
        {
            string text = "";

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    map1[i, j] = "o";
                }
            }

            foreach (RangedUnit R in rangedUnits)
            {
               
                map1[R.XPos, R.YPos] = R.Symbol;
            }
            foreach (MeleeUnit M in meleeUnits)
            {
                
                map1[M.XPos, M.YPos] = M.Symbol;
            }

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    text+=map1[i, j];
                }
                text += Environment.NewLine;
            }
            return text;


            //groupBox.Controls.Clear();

            //foreach (MeleeUnit M in meleeUnits)
            //{
            //    Label newLabel1 = new Label();
            //    newLabel1.Width = 20;
            //    newLabel1.Height = 20;
            //    newLabel1.Text = M.Symbol;
            //    newLabel1.Location = new Point(M.XPos * 20, M.YPos * 20);
            //    groupBox.Controls.Add(newLabel1);
            //}

            //foreach (RangedUnit R in rangedUnits)
            //{
            //    Label newRangedUnit = new Label();
            //    newRangedUnit.Width = 20;
            //    newRangedUnit.Height = 20;
            //    newRangedUnit.Text = R.Symbol;
            //    newRangedUnit.Location = new Point(R.XPos * 20, R.YPos * 20);
            //    groupBox.Controls.Add(newRangedUnit);
            //}
        }
    }
}
