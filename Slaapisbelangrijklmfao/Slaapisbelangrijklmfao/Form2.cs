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
    public partial class Form2 : Form
    {
        public Form2()
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
                "Nick",
                "Dion",
                "Sophie",
                "Carmen",
                "Mika",
                "Jochem",
                "",
            };
            if(TeunsImput.Text == Namelist[0])
            {
                TeunSpreekt.Text = "Wiebol je stinkt";
            } else if (TeunsImput.Text == Namelist[1])
            {
                TeunSpreekt.Text = "Kleine dwerg";
            }
            else if (TeunsImput.Text == Namelist[2])
            {
                TeunSpreekt.Text = "Nogsteeds zin in chips";
            }
            else if (TeunsImput.Text == Namelist[3])
            {
                TeunSpreekt.Text = "Omundigen boer";
            }
            else if (TeunsImput.Text == Namelist[4])
            {
                TeunSpreekt.Text = "Klein aapken uut Beltrum";
            }
            else if (TeunsImput.Text == Namelist[5])
            {
                TeunSpreekt.Text = "onwies kakker";
            }
            else if (TeunsImput.Text == Namelist[6])
            {
                TeunSpreekt.Text = "HOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOONYAAAAAAAAAAA generaal manager de 5e";
            }
            else if (TeunsImput.Text == Namelist[7])
            {
                TeunSpreekt.Text = "Onmundigen kneus kan nergens overnadenken en denkt dat gamen belangrijkst is";
            }
            else if (TeunsImput.Text == Namelist[8])
            {
                TeunSpreekt.Text = "Trommelen is het enige waar je goed in bent";
            }
            else if (TeunsImput.Text == Namelist[9])
            {
                TeunSpreekt.Text = "";
            }


            else
            {
                TeunSpreekt.Text = "Wtf";
            }
        }
    }
}
