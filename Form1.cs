using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_for_do_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i <= 10)
            {
                listBox1.Items.Add(i);
                i++;
            }
            button1.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int j = 0;
            do
            {
                listBox2.Items.Add(j);
                j++;
            }
            while (j <= 10);
            button2.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (k=0; k <= 10; k++)
            {
                listBox3.Items.Add(k);
                button3.Enabled = false;
            }
        }
    }
}
