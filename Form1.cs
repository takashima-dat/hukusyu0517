using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hukusyu0517
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kaomoji_Click(object sender, EventArgs e)
        {
            //kaomoji.Top += (textBox2.Text);
        }

        private void up_Click(object sender, EventArgs e)
        {
            //textBox2.TextChanged += 1;
        }

        private void down_Click(object sender, EventArgs e)
        {
            
        }

        private void left_Click(object sender, EventArgs e)
        {

        }

        private void right_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //int TextBox1_TextChanged;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kaomoji.Left += int.Parse(textBox1.Text);
            kaomoji.Top += int.Parse(textBox2.Text);
        }
    }
}
