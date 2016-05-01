using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Led
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("A");
            pictureBox1.Image = Properties.Resources.Ron;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("d");
            pictureBox1.Image = Properties.Resources.Roff;
        }
    }
}
