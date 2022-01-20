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

        public void getArea()
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
            }
        }

        private void cbGatheringSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            getArea();
        }
         

      
        
        private void button1_Click(object sender, EventArgs e)
        {
          
            Random rnd = new Random();
            int roll = rnd.Next(1, 100);
            infoLog.Text = roll.ToString();


            
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
