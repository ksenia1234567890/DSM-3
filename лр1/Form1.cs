using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ulong number = ulong.Parse(textBox1.Text);
            ulong number_2 = Calculate(number);
            textBox2.Text = Convert.ToString(number_2);
        }
        public ulong Calculate(ulong a)
        {
            if (a == 1)
            {
                return 1;
            }
            return a* Calculate(a - 1);
            
        }
    }
}
