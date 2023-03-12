using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA_W3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int calc;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            calc = int.Parse(Prime_txt.Text);
            if (calc == 0 || calc == 1)
            {
                string body = "Not Prime";
                MessageBox.Show(body, "Prime Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            for (int i = 1; i <= calc; i++)
            {
                if (calc % i == 0)
                {
                    counter++;
                }
            }
            if (counter == 2)
            {
                string body = "Prime";
                MessageBox.Show(body, "Prime Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string body = "Not Prime";
                MessageBox.Show(body, "Prime Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Fact_btn_Click(object sender, EventArgs e)
        {
            calc = int.Parse(Fact_txt.Text);
            int a = 1;
            for (int i = 1 ; i <= calc; i++)
            {
                a = a * i;
            }
            string isibody = a.ToString();
            MessageBox.Show(isibody, "Factorial Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Comb_btn_Click(object sender, EventArgs e)
        {
            int n = int.Parse(Comb_txt.Text);
            int r = int.Parse(CombR_txt.Text);
            int comb1, comb2, comb3, number, result;
            comb1 = n;
            if (n < r)
            {
                string isibody = "n is smaller. n Must be greater than r";
                MessageBox.Show(isibody, "Combination Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                for (int i = n - 1; i >= 1; i--)
                {
                    comb1 = comb1 * i;
                }
                comb2 = r;
                for (int i = r-1; i>=1; i--)
                {
                    comb2 = comb2 * i;
                }
                number = n - r;
                comb3 = number;
                for (int i = number-1; i >= 1; i--)
                {
                    comb3 = comb3 * i;
                }
                comb3= comb2 * comb3;
                result = comb1 / comb3;
                string isibody = result.ToString();
                MessageBox.Show(isibody, "Combination Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
