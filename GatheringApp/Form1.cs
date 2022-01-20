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
            int currentRoll = diceRoll();
            string CurrentArea = GetArea().ToString();
            
            diceRoll();


            switch (true)
            {
                // populate switch statements with rewards 
            }



        }
        
        //Dice Roll Logic & InBetween Function 
        public int diceRoll()
        {
            Random rnd = new Random();
            int roll = rnd.Next(1, 100);
            infoLog.Text = $"you rolled {roll}";
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
