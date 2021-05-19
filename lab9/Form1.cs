using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            Random rnd = new Random();
            int N = 0;
            int k = 1;
            int i = 0;
            double[] p = new double[5];
            double[] Frenquesy = new double[5]; ;
            double[] Statistic = new double[5];
            p[0] = Convert.ToDouble(textBox1.Text);
            p[1] = Convert.ToDouble(textBox2.Text);
            p[2] = Convert.ToDouble(textBox3.Text);
            p[3] = Convert.ToDouble(textBox4.Text);
            p[4] = 1 - (p[0] + p[1] + p[2] + p[3]);
            N = Convert.ToInt32(textBox6.Text);
            while (i < N)
            {
                double a = rnd.NextDouble();
                double A = a;
                k = 0;
                while (true)
                {
                    A = A - p[k];
                    if (A <= 0)
                    {
                        break;
                    }
                    k++;
                }

                Statistic[k]++;
                i++;
            }
            for (int j = 0; j < 5; j++)
            {
                Frenquesy[j] = Statistic[j] / N;
                Console.WriteLine(Frenquesy[j]);
                chart1.Series[0].Points.AddXY(j + 1, Frenquesy[j]);
            }
        }
    }
}
