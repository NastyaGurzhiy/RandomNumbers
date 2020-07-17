using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumbers
{
    public partial class Form1 : Form
    {
        Random random;
       
        public Form1()
        {
            random = new Random();
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int from = (int)nudFrom.Value;
            int to = (int)nudTo.Value;
            if (from < to)
            {
                int number = random.Next(from, to);
                tbOutPut.BackColor = Color.AliceBlue;
                tbOutPut.Text = number.ToString();
                if (cbWithoutRepeat.Checked)
                {
                    if (tbHistory.Text.IndexOf(number.ToString()) == -1)
                        tbHistory.AppendText(tbOutPut.Text + "\n");
                }
                else
                    tbHistory.AppendText(tbOutPut.Text + "\n");
            }
            else
            {
                MessageBox.Show("Invalid arguments", "Error");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nudFrom.Value = 0;
            nudTo.Value = 6;
            tbOutPut.BackColor = Color.White;
            tbOutPut.Text = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbHistory.Text = null;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbHistory.Text);
        }
    }
}
