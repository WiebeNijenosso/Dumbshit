using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slaapisbelangrijklmfao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Namelist =
             {
                "Wiebe",
                "Nina",
                "Gijs",
                "Teun",
                "Dion",
                "Sophie",
                "Carmen",
                "Mika",
                "Jochem",
                "",
            };
            if(nickInput.Text == Namelist[0])
            {
                NicksMeeeeeeeeeeeeeeeeeening.Text = "Ga slapen kankermongool";
            }
            else if(nickInput.Text == Namelist[1])
            {
                NicksMeeeeeeeeeeeeeeeeeening.Text = "Sow ey, jij bent klein";
            } else if (nickInput.Text == Namelist[2])
            {
                NicksMeeeeeeeeeeeeeeeeeening.Text = "HA! GAYYYYY";
            } else if (nickInput.Text == Namelist[3])
            {
                NicksMeeeeeeeeeeeeeeeeeening.Text = "Je stinkt lol";
            } else if (nickInput.Text == Namelist[4])
            {
                NicksMeeeeeeeeeeeeeeeeeening.Text = "Ruim de kots bij Tunes op";
            } else if (nickInput.Text == Namelist[5])
            {
                NicksMeeeeeeeeeeeeeeeeeening.Text = "Blief van mien af";
            } else if (nickInput.Text == Namelist[6])
            {
                NicksMeeeeeeeeeeeeeeeeeening.Text = "Meer roken die stem klinkt nargens noa";
            }
            else if (nickInput.Text == Namelist[7])
            {
                NicksMeeeeeeeeeeeeeeeeeening.Text = "Meer CSGO wins als totale sociale interacties met mensen van het andere geslacht";
            } 
            else if (nickInput.Text == Namelist[8])
            {
                NicksMeeeeeeeeeeeeeeeeeening.Text = "Door ow wil ik snapchat verwijderen chef";
            }
            else if (nickInput.Text == Namelist[9])
            {
                NicksMeeeeeeeeeeeeeeeeeening.Text = "";
            }


            else
            {
                NicksMeeeeeeeeeeeeeeeeeening.Text = "Ik zou voor god nie wetn wie ej bunt";
            }
        }

        private void Switcharoo_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();
            this.Hide();
        }
    }
}