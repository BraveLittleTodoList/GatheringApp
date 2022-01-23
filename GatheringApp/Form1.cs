using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GatheringApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        //Logic to set gathering area
        public string GetArea()
        {
            int area = cbGatheringSelect.SelectedIndex;
            string currentArea;
            switch (area)
            {
                case 0:
                    pbGatheringImage.Image = Image.FromFile(@"C:\Users\cchap\source\repos\GatheringApp\GatheringApp\img\Forest.jpg");
                    currentArea = "Forest";
                    break;
                case 1:
                    pbGatheringImage.Image = Image.FromFile(@"C:\Users\cchap\source\repos\GatheringApp\GatheringApp\img\Desert.png");
                    currentArea = "Desert";
                    break;
                case 2:
                    pbGatheringImage.Image = Image.FromFile(@"C:\Users\cchap\source\repos\GatheringApp\GatheringApp\img\Grasslands.jpg");
                    currentArea = "Grasslands";
                    break;
                case 3:
                    pbGatheringImage.Image = Image.FromFile(@"C:\Users\cchap\source\repos\GatheringApp\GatheringApp\img\Marsh.jpg");
                    currentArea = "Marsh";
                    break;
                case 4:
                    pbGatheringImage.Image = Image.FromFile(@"C:\Users\cchap\source\repos\GatheringApp\GatheringApp\img\Mountain.jpg");
                    currentArea = "Mountain";
                    break;
                
                default:
                    currentArea = null;
                    break;
            }
            return currentArea;
        }
        //Controller to set gathering area
        private void cbGatheringSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            GetArea();
        }
         
        //Logic for reseiveing gatheringRewards
        public void gatheringAreaRewards()
        {
            int currentRoll = D100DiceRoll();
            int supRoll = D4DiceRoll();
            bool ForestArea = GetArea().ToString() == "Forest";
            bool Desert = GetArea().ToString() == "Desert";
            bool Grasslands = GetArea().ToString() == "Grasslands";
            bool Marsh = GetArea().ToString() == "Marsh";
            bool Mountian = GetArea().ToString() == "Mountain";


            #region MountiansArea
            if (Mountian == true && InBetween(currentRoll, 1, 20))
            {
                infoLog.Text = $"You failed to gather anything";
            }
            else if (Mountian == true && InBetween(currentRoll, 21, 40))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Mountian == true && InBetween(currentRoll, 21, 40))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Mountian == true && InBetween(currentRoll, 21, 40))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Mountian == true && InBetween(currentRoll, 21, 40))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Mountian == true && InBetween(currentRoll, 21, 40))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Mountian == true && InBetween(currentRoll, 21, 40))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Mountian == true && InBetween(currentRoll, 21, 40))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Mountian == true && InBetween(currentRoll, 21, 40))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Mountian == true && InBetween(currentRoll, 21, 40))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            #endregion

            #region MarshArea
            if (Marsh == true && InBetween(currentRoll, 11, 20))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Marsh == true && InBetween(currentRoll, 21, 40))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            #endregion


            #region GrasslandsArea
            if (Grasslands == true && InBetween(currentRoll, 11, 20))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Grasslands == true && InBetween(currentRoll, 21, 40))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            #endregion

            #region DesertArea Rewards
            if (Desert == true && InBetween(currentRoll, 11, 20))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (Desert == true && InBetween(currentRoll, 21, 40))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            #endregion


            #region ForestArea Rewards
            //ForestArea Rewards Bug with statting numbers ex 41,51,21
            if (ForestArea == true && InBetween(currentRoll, 11, 20))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if(ForestArea == true && InBetween(currentRoll, 21, 40))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (ForestArea == true && InBetween(currentRoll, 41, 50))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (ForestArea == true && InBetween(currentRoll, 50+1, 60) && InBetween(supRoll,1,4))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered {supRoll} common reactive reagent ";
            }
            else if (ForestArea == true && InBetween(currentRoll, 61, 70))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (ForestArea == true && InBetween(currentRoll, 71, 80))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (ForestArea == true && InBetween(currentRoll, 81, 90))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (ForestArea == true && InBetween(currentRoll, 91, 95))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent";
            }
            else if (ForestArea == true && InBetween(currentRoll, 96, 100))
            {
                infoLog.Text = $"Rolled {currentRoll} You successfully gathered Common Curative Reagent!";
            }
            else if (ForestArea == true && InBetween(currentRoll, 1, 10))
            {
                infoLog.Text = $"Rolled {currentRoll} Bad Luck, you failed to gather anything";
            }
        }
        #endregion 


        


//Dice Rolls Logic & InBetween Function 
public int D100DiceRoll()
        {
            Random rnd = new Random();
            int roll = rnd.Next(0, 99);
            return roll;

        }

        public int D4DiceRoll()
        {
            Random rnd = new Random();
            int roll = rnd.Next(1, 4);
            return roll;
        }
        public static bool InBetween(int roll, int low, int high)
        {
            return roll > low && roll < high;

        }
        //Controller for gathering. DiceRoll and rewards. 
        private void button1_Click(object sender, EventArgs e)
        {
            gatheringAreaRewards();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
