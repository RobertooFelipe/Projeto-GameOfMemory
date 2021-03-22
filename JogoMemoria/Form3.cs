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
    public partial class Form3 : Form
    {
        public static class formState
        {
            public static Form previouspage;
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JogoFacil menuf = new JogoFacil();
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
