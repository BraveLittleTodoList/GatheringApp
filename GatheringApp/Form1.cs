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

        private void cbGatheringSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selct = cbGatheringSelect.SelectedIndex;
            switch (selct)
            {
                case 0:
                    pbGatheringImage.Image = Image.FromFile(@"C:\Users\cchap\source\repos\GatheringApp\GatheringApp\img\Forest.jpg");
                    break;
                case 1:
                    pbGatheringImage.Image = Image.FromFile(@"C:\Users\cchap\source\repos\GatheringApp\GatheringApp\img\Desert.png");
                    break;
                case 2:
                    pbGatheringImage.Image = Image.FromFile(@"C:\Users\cchap\source\repos\GatheringApp\GatheringApp\img\Grasslands.jpg");
                    break;
                case 3:
                    pbGatheringImage.Image = Image.FromFile(@"C:\Users\cchap\source\repos\GatheringApp\GatheringApp\img\Marsh.jpg");
                    break;
                case 4:
                    pbGatheringImage.Image = Image.FromFile(@"C:\Users\cchap\source\repos\GatheringApp\GatheringApp\img\Mountain.jpg");
                    break;
            }
                 
        }
    }
}
