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
    class Petter
    {
        private void buttonsjekksvar_click(object sender, EventArgs e)
            if (pictureBox1.Bounds.IntersectsWith(label1.Bounds))
            label1.BackColor = System.Drawing.Color.Chartreuse;
            else
            label1.BackColor = System.Drawing.Color.OrangeRed;

            if (pictureBox2.Bounds.IntersectsWith(label2.Bounds))
            label2.BackColor = System.Drawing.Color.Chartreuse;
            else
            label2.BackColor = System.Drawing.Color.OrangeRed;
            
            if (pictureBox3.Bounds.IntersectsWith(label3.Bounds))
            label3.BackColor = System.Drawing.Color.Chartreuse;
            else
            label3.BackColor = System.Drawing.Color.OrangeRed;
            
            if (pictureBox4.Bounds.IntersectsWith(label4.Bounds))
            label4.BackColor = System.Drawing.Color.Chartreuse;
            else
            label4.BackColor = System.Drawing.Color.OrangeRed;
            
            if (pictureBox5.Bounds.IntersectsWith(label5.Bounds))
            label5.BackColor = System.Drawing.Color.Chartreuse;
            else
            label5.BackColor = System.Drawing.Color.OrangeRed;
    }
}
