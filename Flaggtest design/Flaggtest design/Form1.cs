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


namespace Flaggtest_design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Vanskelighetsgrad" || comboBox2.Text == "Verdensdel")
            {
                MessageBox.Show("Du må velge en verdensdel og en vanskelighetsgrad");
            }

            if (comboBox2.Text == "Europa" && comboBox1.Text == "Lett")
            {
                this.Hide();
                Europa_Lett EuroL = new Europa_Lett();
                EuroL.ShowDialog();
            }

            if (comboBox2.Text == "Europa" && comboBox1.Text == "Middel")
            {
                this.Hide();
                Europa_Middel EuroM = new Europa_Middel();
                EuroM.ShowDialog();
            }

            if (comboBox2.Text == "Europa" && comboBox1.Text == "Vanskelig")
            {
                this.Hide();
                Europa_Vanskelig EuroV = new Europa_Vanskelig();
                EuroV.ShowDialog();
            }
        }
    }
}
