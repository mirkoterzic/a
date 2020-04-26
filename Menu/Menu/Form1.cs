using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void crvenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.Color.Red;
        }

        private void zelenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.Color.Green;
        }

        private void plavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.Color.Blue;
        }

        private void žutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = System.Drawing.Color.Yellow;
        }

        private void crnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Black;
        }

        private void smeđaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Brown;
        }

        private void crvenaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Red;
        }

        private void plavaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = System.Drawing.Color.Blue;
        }
    }
}
