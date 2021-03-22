using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoMemoria
{
    public partial class Form5 : Form
    {
        public static class formState
        {
            public static Form previouspage;
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 menuf = new Form1();
            menuf.Show();
            this.Hide();
            Form2.formState.previouspage = this;
        }

        private void voltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            menu.Show();
            this.Hide();
            formState.previouspage = this;
        }
    }
}
