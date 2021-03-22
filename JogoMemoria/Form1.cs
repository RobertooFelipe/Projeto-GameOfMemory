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
    public partial class Form1 : Form
    {
        int fig1 = 0, fig11 = 0, fig2 = 0, fig22 = 0, fig3 = 0, fig33 = 0, fig4 = 0, fig44 = 0, fig5 = 0, fig55 = 0, fig6 = 0, fig66 = 0, fig7 = 0, fig77 = 0, fig8 = 0, fig88 = 0, fig9 = 0, fig99 = 0, fig10 = 0, fig1010 = 0, vira = 0, acerto = 0, erro = 0;
        int time = 30; 

        Button bt = null;

        private void ContagemRegressiva()
        {
            timer1.Start();
            timer1.Tick += delegate
            {
                time--;
                if (time < 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Acabou Seu Tempo");
                    Form2 menu = new Form2();
                    menu.Show();
                    this.Close();
                }
                else
                {
                    var sstempo = TimeSpan.FromSeconds(time);
                    tempo.Text = "0:" + time.ToString();
                }
            };
        }

        private void figura66_Click(object sender, EventArgs e)
        {
            figura66.Visible = false;
            fig66 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig66 == fig6)
                {
                    figura6.Visible = false;
                    figura66.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura6.Visible = true;
                    figura66.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;

                if (erro == 3)
                {

                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();


                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }

            }
            else
            {
                bt = figura66;
            }
            mostra();

        }

        private void figura10_Click(object sender, EventArgs e)
        {
            figura10.Visible = false;
            fig10 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig10 == fig1010)
                {
                    figura10.Visible = false;
                    figura1010.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura10.Visible = true;
                    figura1010.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
                bt = figura10;
            }
            mostra();
        }

        private void figura1010_Click(object sender, EventArgs e)
        {
            figura1010.Visible = false;
            fig1010 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig1010 == fig10)
                {
                    figura10.Visible = false;
                    figura1010.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura10.Visible = true;
                    figura1010.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
                bt = figura1010;
            }
            mostra();
        }

        private void figura55_Click(object sender, EventArgs e)
        {
            figura55.Visible = false;
            fig55 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig55 == fig5)
                {
                    figura5.Visible = false;
                    figura55.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura5.Visible = true;
                    figura55.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
                bt = figura55;
            }
            mostra();
        }

        private void timerhard_Tick(object sender, EventArgs e)
        {
            figura1.Visible = true;
            figura11.Visible = true;
            figura2.Visible = true;
            figura22.Visible = true;
            figura3.Visible = true;
            figura33.Visible = true;
            figura4.Visible = true;
            figura44.Visible = true;
            figura5.Visible = true;
            figura55.Visible = true;
            figura6.Visible = true;
            figura66.Visible = true;
            figura7.Visible = true;
            figura77.Visible = true;
            figura8.Visible = true;
            figura88.Visible = true;
            figura9.Visible = true;
            figura99.Visible = true;
            figura10.Visible = true;
            figura1010.Visible = true;
            timerhard.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void voltarAoMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 menu = new Form2();
            menu.Show();
            this.Hide();
            formState.previouspage = this;
            timer1.Stop();
        }

        private void reiniciarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            tempo.Text = "0:30";
            time = 30;
            figura1.Visible = true;
            figura11.Visible = true;
            figura2.Visible = true;
            figura22.Visible = true;
            figura3.Visible = true;
            figura33.Visible = true;
            figura4.Visible = true;
            figura44.Visible = true;
            figura5.Visible = true;
            figura55.Visible = true;
            figura6.Visible = true;
            figura66.Visible = true;
            figura7.Visible = true;
            figura77.Visible = true;
            figura8.Visible = true;
            figura88.Visible = true;
            figura9.Visible = true;
            figura99.Visible = true;
            figura10.Visible = true;
            figura1010.Visible = true;
            zera();

            acerto = 0;
            erro = 0;

            label3.Text = "Acertos: 0";
            label4.Text = "Erros: 0";
        }

        private void fecharToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void figura99_Click(object sender, EventArgs e)
        {
            figura99.Visible = false;
            fig99 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig99 == fig9)
                {
                    figura9.Visible = false;
                    figura99.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura9.Visible = true;
                    figura99.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
                bt = figura99;
            }
            mostra();
        }

        private void figura9_Click(object sender, EventArgs e)
        {
            figura9.Visible = false;
            fig9 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig9 == fig99)
                {
                    figura9.Visible = false;
                    figura99.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura9.Visible = true;
                    figura99.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
                bt = figura9;
            }
            mostra();
        }

        private void figura88_Click(object sender, EventArgs e)
        {
            figura88.Visible = false;
            fig88 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig88 == fig8)
                {
                    figura8.Visible = false;
                    figura88.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura8.Visible = true;
                    figura88.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
                bt = figura88;
            }
            mostra();
        }

        private void figura8_Click(object sender, EventArgs e)
        {
            figura8.Visible = false;
            fig8 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig8 == fig88)
                {
                    figura8.Visible = false;
                    figura88.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura8.Visible = true;
                    figura88.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
                bt = figura8;
            }
            mostra();
        }

        private void figura77_Click(object sender, EventArgs e)
        {
            figura77.Visible = false;
            fig77 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig77 == fig7)
                {
                    figura7.Visible = false;
                    figura77.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura7.Visible = true;
                    figura77.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
                bt = figura77;
            }
            mostra();
        }

        private void figura7_Click(object sender, EventArgs e)
        {
            figura7.Visible = false;
            fig7 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig7 == fig77)
                {
                    figura7.Visible = false;
                    figura77.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura7.Visible = true;
                    figura77.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
                bt = figura7;
            }
            mostra();
        }

        private void figura6_Click(object sender, EventArgs e)
        {
            figura6.Visible = false;
            fig6 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig6 == fig66)
                {
                    figura6.Visible = false;
                    figura66.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura6.Visible = true;
                    figura66.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
                bt = figura6;
            }
            mostra();
        }

        private void figura5_Click(object sender, EventArgs e)
        {
            figura5.Visible = false;
            fig5 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig5 == fig55)
                {
                    figura5.Visible = false;
                    figura55.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura5.Visible = true;
                    figura55.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
                bt = figura5;
            }
            mostra();
        }

        private void figura44_Click(object sender, EventArgs e)
        {
            figura44.Visible = false;
            fig44 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig44 == fig4)
                {
                    figura4.Visible = false;
                    figura44.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura4.Visible = true;
                    figura44.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
                bt = figura44;
            }
            mostra();
        }

        private void figura4_Click(object sender, EventArgs e)
        {
            figura4.Visible = false;
            fig4 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig4 == fig44)
                {
                    figura4.Visible = false;
                    figura44.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura4.Visible = true;
                    figura44.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
                bt = figura4;
            }
            mostra();
        }

        private void figura33_Click(object sender, EventArgs e)
        {
            figura33.Visible = false;
            fig33 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig33 == fig3)
                {
                    figura3.Visible = false;
                    figura33.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura3.Visible = true;
                    figura33.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
                bt = figura33;
            }
            mostra();
        }

        private void figura3_Click(object sender, EventArgs e)
        {
            figura3.Visible = false;
            fig3 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig3 == fig33)
                {
                    figura3.Visible = false;
                    figura33.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura3.Visible = true;
                    figura33.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
                bt = figura3;
            }
            mostra();
            }

        private void figura11_Click(object sender, EventArgs e)
        {
            figura11.Visible = false;
            fig11 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig11 == fig1)
                {
                    figura1.Visible = false;
                    figura11.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura1.Visible = true;
                    figura11.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
                bt = figura11;
            }
                mostra();
            }
        

        private void figura2_Click(object sender, EventArgs e)
        {
            figura2.Visible = false;
            fig2 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig2 == fig22)
                {
                    figura2.Visible = false;
                    figura22.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura2.Visible = true;
                    figura22.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
                bt = figura2;
            }
            mostra();
        }


        public Form1()
        {
            InitializeComponent();
            ContagemRegressiva();

            figura1.Visible = false;
            figura11.Visible = false;
            figura2.Visible = false;
            figura22.Visible = false;
            figura3.Visible = false;
            figura33.Visible = false;
            figura4.Visible = false;
            figura44.Visible = false;
            figura5.Visible = false;
            figura55.Visible = false;
            figura6.Visible = false;
            figura66.Visible = false;
            figura7.Visible = false;
            figura77.Visible = false;
            figura8.Visible = false;
            figura88.Visible = false;
            figura9.Visible = false;
            figura99.Visible = false;
            figura10.Visible = false;
            figura1010.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            figura22.Visible = false;
            fig22 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig22 == fig2)
                {
                    figura2.Visible = false;
                    figura22.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura2.Visible = true;
                    figura22.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
                bt = figura22;
            }
            mostra();
        }

        private void figura1_Click(object sender, EventArgs e)
        {
            figura1.Visible = false;
            fig1 = 1;
            vira = vira + 1;
            if (vira == 2)
            {
                if (fig1 == fig11)
                {
                    figura1.Visible = false;
                    figura11.Visible = false;
                    vira = 0;
                    acerto++;
                }
                else
                {
                    figura1.Visible = true;
                    figura11.Visible = true;
                    bt.Visible = true;
                    zera();
                    erro++;

                }
                vira = 0;
                if (erro == 3)
                {
                    Form5 menu = new Form5();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();

                }
                if (acerto == 10)
                {

                    Form4 menu = new Form4();
                    menu.Show();
                    this.Hide();
                    formState.previouspage = this;
                    timer1.Stop();
                }
            }
            else
            {
            bt = figura1;
            }
            mostra(); 
            }
        
        public void zera()
        {
            fig1 = 0; fig11 = 0; fig2 = 0; fig22 = 0; fig3 = 0; fig33 = 0; fig4 = 0; fig44 = 0; fig5 = 0; fig55 = 0; fig6 = 0; fig66 = 0; fig7 = 0; fig77 = 0; fig8 = 0; fig88 = 0; fig9 = 0; fig99 = 0; fig10 = 0; fig10 = 0;
        }
        public void mostra()
        {
            label3.Text = "Acertos: " + acerto; label4.Text = "Erros: " + erro;
        }
    }
}

