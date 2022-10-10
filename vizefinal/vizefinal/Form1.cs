using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizefinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ortalama, vize, final;
            try
            {
                vize = Convert.ToDouble(numericUpDown1.Value);
                final = Convert.ToDouble(numericUpDown2.Value);
                ortalama = vize * 0.4 + final * 0.6;
                label3.Text = ortalama.ToString();
                if (ortalama >= 50)
                {
                    label4.Text = "Geçti";
                    
                }
                else
                {
                    label4.Text = "Kaldı";
                }
                if (ortalama < 0){
                    label5.Text = "F";
                }
                if (ortalama >= 0 && ortalama < 50)
                {
                    label5.Text = "D";
                }
                if (ortalama >= 50 && ortalama < 70)
                {
                    label5.Text = "C";
                }
                if (ortalama >= 70 && ortalama < 85)
                {
                    label5.Text = "B";
                }
                if (ortalama >= 85)
                {
                    label5.Text = "A";
                }

            }
            catch (Exception)
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
