using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static JogoMemoria.Form2;

namespace JogoMemoria
{
    public partial class Form2 : Form
    {
        public static class formState
        {
            public static Form previouspage;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
            formState.previouspage = this;
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JogoFacil menuf = new JogoFacil();
            menuf.Show();
            this.Hide();
            formState.previouspage = this;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairDoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button1.Visible = true;
            button3.Visible = false;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Visible = false;
            button4.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button2.Visible = true;
            button4.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
            formState.previouspage = this;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            JogoFacil menuf = new JogoFacil();
            menuf.Show();
            this.Hide();
            formState.previouspage = this;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
