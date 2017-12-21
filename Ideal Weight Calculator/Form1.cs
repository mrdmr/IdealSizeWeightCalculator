using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ideal_Weight_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy = Convert.ToDouble(textsize.Text) * Convert.ToDouble(textsize.Text);
            int kilo = Convert.ToInt32(textweight.Text);
            double oran = kilo / boy;
            labelrate.Text = Convert.ToString(oran);
            if (oran < 18.5)
            {
                labelresult.Text = "weak";
            }
            else if (oran < 25)
            {
                labelresult.Text = "normal";
            }
            else if (oran < 30)
            {
                labelresult.Text = "overweight";
            }
            else
            {
                labelresult.Text = "obez";
            }
        }
    }
}
