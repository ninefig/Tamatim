using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tamatim
{
    public partial class Principal : Form
    {
        int quantPomodori = 0, qPomodori = 0, somaPomodoris = 0;
        private SoundPlayer pausaSound;

        public Principal()
        {
            InitializeComponent();
            pausaSound = new SoundPlayer("pausa.wav");
        }

        private void umPomodori_Tick(object sender, EventArgs e)
        {
            umPomodori.Stop();
            qPomodori = qPomodori + 1;

            if (qPomodori == 1)
            {
                   somaPomodoris = somaPomodoris + 1;
                   totalPomodoris.Text = Convert.ToString(somaPomodoris);
                    MessageBox.Show("Intervalo 5 minutos.");
                    pausaSound.Play();
                    umPomodori.Start();
            }
            else                
                MessageBox.Show("Acabou.");
                qPomodori = 0;
        }

        private void tresPomodoris_Tick(object sender, EventArgs e)
        {
            tresPomodoris.Stop();
            qPomodori = qPomodori + 1;

            if (qPomodori < 4)
            {
                somaPomodoris = somaPomodoris + 1;
                totalPomodoris.Text = Convert.ToString(somaPomodoris);
                MessageBox.Show("Intervalo 5 minutos.");
                pausaSound.Play();
                tresPomodoris.Start();
            }
            else
                MessageBox.Show("Acabou.");
                qPomodori = 0;
        }

        private void quatroPomodoris_Tick(object sender, EventArgs e)
        {
            quatroPomodoris.Stop();
            qPomodori = qPomodori + 1;

            if (qPomodori < 4)
            {
                somaPomodoris = somaPomodoris + 1;
                totalPomodoris.Text = Convert.ToString(somaPomodoris);
                MessageBox.Show("Intervalo 5 minutos.");
                pausaSound.Play();
                quatroPomodoris.Start();
            }
            else if (qPomodori == 4)
            {
                somaPomodoris = somaPomodoris + 1;
                totalPomodoris.Text = Convert.ToString(somaPomodoris);
                MessageBox.Show("Intervalo 20 minutos.");
                pausaSound.Play();
                quatroPomodoris.Start();
            }
            else
                MessageBox.Show("Acabou.");
                qPomodori = 0;
        }

        private void doisPomodoris_Tick(object sender, EventArgs e)
        {
            doisPomodoris.Stop();
            qPomodori = qPomodori + 1;

            if (qPomodori < 3)
            {
                somaPomodoris = somaPomodoris + 1;
                totalPomodoris.Text = Convert.ToString(somaPomodoris);
                MessageBox.Show("Intervalo 5 minutos.");
                pausaSound.Play();
                doisPomodoris.Start();
            }
            else
                MessageBox.Show("Acabou.");
                qPomodori = 0;
        }

        private void cincoPomodoris_Tick(object sender, EventArgs e)
        {
            cincoPomodoris.Stop();
            qPomodori = qPomodori + 1;

            if (qPomodori < 4)
            {
                somaPomodoris = somaPomodoris + 1;
                totalPomodoris.Text = Convert.ToString(somaPomodoris);
                MessageBox.Show("Intervalo 5 minutos.");
                pausaSound.Play();
                cincoPomodoris.Start();
            }
            else if (qPomodori == 4 || qPomodori == 5)
            {
                somaPomodoris = somaPomodoris + 1;
                totalPomodoris.Text = Convert.ToString(somaPomodoris);
                MessageBox.Show("Intervalo 20 minutos.");
                pausaSound.Play();
                cincoPomodoris.Start();
            }
            else
                MessageBox.Show("Acabou.");
                qPomodori = 0;
        }

        private void seisPomodoris_Tick(object sender, EventArgs e)
        {
            seisPomodoris.Stop();
            qPomodori = qPomodori + 1;

            if (qPomodori < 4)
            {
                somaPomodoris = somaPomodoris + 1;
                totalPomodoris.Text = Convert.ToString(somaPomodoris);
                MessageBox.Show("Intervalo 5 minutos.");
                pausaSound.Play();
                seisPomodoris.Start();
            }
            else if (qPomodori == 4 || qPomodori < 7)
            {
                somaPomodoris = somaPomodoris + 1;
                totalPomodoris.Text = Convert.ToString(somaPomodoris);
                MessageBox.Show("Intervalo 20 minutos.");
                pausaSound.Play();
                seisPomodoris.Start();
            }
            else
                MessageBox.Show("Acabou.");
                qPomodori = 0; 
        }

        private void setePomodoris_Tick(object sender, EventArgs e)
        {
            setePomodoris.Stop();
            qPomodori = qPomodori + 1;

            if (qPomodori < 4)
            {
                somaPomodoris = somaPomodoris + 1;
                totalPomodoris.Text = Convert.ToString(somaPomodoris);
                MessageBox.Show("Intervalo 5 minutos.");
                pausaSound.Play();
                setePomodoris.Start();
            }
            else if (qPomodori == 4 || qPomodori < 8)
            {
                somaPomodoris = somaPomodoris + 1;
                totalPomodoris.Text = Convert.ToString(somaPomodoris);
                MessageBox.Show("Intervalo 20 minutos.");
                pausaSound.Play();
                setePomodoris.Start();
            }
            else
                MessageBox.Show("Acabou.");
                qPomodori = 0;
        }

        private void oitoPomodoris_Tick(object sender, EventArgs e)
        {
            oitoPomodoris.Stop();
            qPomodori = qPomodori + 1;

            if (qPomodori < 4)
            {
                somaPomodoris = somaPomodoris + 1;
                totalPomodoris.Text = Convert.ToString(somaPomodoris);
                MessageBox.Show("Intervalo 5 minutos.");
                pausaSound.Play();
                oitoPomodoris.Start();
            }
            else if (qPomodori == 4 || qPomodori < 9)
            {
                somaPomodoris = somaPomodoris + 1;
                totalPomodoris.Text = Convert.ToString(somaPomodoris);
                MessageBox.Show("Intervalo 20 minutos.");
                pausaSound.Play();
                oitoPomodoris.Start();
            }
            else
                MessageBox.Show("Acabou.");
                qPomodori = 0;
        }

        private void novePomodoris_Tick(object sender, EventArgs e)
        {
            novePomodoris.Stop();
            qPomodori = qPomodori + 1;

            if (qPomodori < 4)
            {
                somaPomodoris = somaPomodoris + 1;
                totalPomodoris.Text = Convert.ToString(somaPomodoris);
                MessageBox.Show("Intervalo 5 minutos.");
                pausaSound.Play();
                novePomodoris.Start();
            }
            else if (qPomodori == 4 || qPomodori < 10)
            {
                somaPomodoris = somaPomodoris + 1;
                totalPomodoris.Text = Convert.ToString(somaPomodoris);
                MessageBox.Show("Intervalo 20 minutos.");
                pausaSound.Play();
                novePomodoris.Start();
            }
            else
                MessageBox.Show("Acabou.");
                qPomodori = 0; 
        }

        private void dezPomodoris_Tick(object sender, EventArgs e)
        {
            dezPomodoris.Stop();
            qPomodori = qPomodori + 1;

            if (qPomodori < 4)
            {
                somaPomodoris = somaPomodoris + 1;
                totalPomodoris.Text = Convert.ToString(somaPomodoris);
                MessageBox.Show("Intervalo 5 minutos.");
                pausaSound.Play();
                dezPomodoris.Start();
            }
            else if (qPomodori == 4 || qPomodori <= 10)
            {
                somaPomodoris = somaPomodoris + 1;
                totalPomodoris.Text = Convert.ToString(somaPomodoris);
                MessageBox.Show("Intervalo 20 minutos.");
                pausaSound.Play();
                dezPomodoris.Start();
            }
            else
                MessageBox.Show("Acabou.");   
                qPomodori = 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtQuantPomodoris.Text = "";
            totalPomodoris.Text = "";
            somaPomodoris = 0;
            qPomodori = 0;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Text = "Feito";
            }
            else
                checkBox2.Text = "";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.Text = "Feito";
            }
            else
                checkBox3.Text = "";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox6.Text = "Feito";
            }
            else
                checkBox6.Text = "";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox5.Text = "Feito";
            }
            else
                checkBox5.Text = "";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox4.Text = "Feito";
            }
            else
                checkBox4.Text = "";
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                checkBox9.Text = "Feito";
            }
            else
                checkBox9.Text = "";
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                checkBox8.Text = "Feito";
            }

            else
                checkBox8.Text = "";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox7.Text = "Feito";
            } else
                checkBox7.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Feito";
            }
            else
                checkBox1.Text = "";

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            quantPomodori = Convert.ToInt16(txtQuantPomodoris.Text);

            switch (quantPomodori)
            {
                case 1:
                    umPomodori.Start();                    
                    break;

                case 2:
                    doisPomodoris.Start();
                    break;

                case 3:
                    tresPomodoris.Start();
                    break;

                case 4:
                    quatroPomodoris.Start();
                    break;

                case 5:
                    cincoPomodoris.Start();
                    break;

                case 6:
                    seisPomodoris.Start();
                    break;

                case 7:
                    setePomodoris.Start();
                    break;

                case 8:
                    oitoPomodoris.Start();
                    break;

                case 9:
                    novePomodoris.Start();
                    break;

                case 10:
                    dezPomodoris.Start();
                    break;

                default:
                    MessageBox.Show("Você digitou um número acima de 10 pomodoris (limite) ou não digitou um valor válido. Tente novamente.");
                    break;
            }
        }

        private void btnPomodori_Click_1(object sender, EventArgs e)
        {
            somaPomodoris = somaPomodoris + 1;
            totalPomodoris.Text = Convert.ToString(somaPomodoris);
           
            switch (somaPomodoris)
            {
                case 1:
                    umPomodori.Start();
                    break;

                case 2:
                    doisPomodoris.Start();
                    break;

                case 3:
                    tresPomodoris.Start();
                    break;

                case 4:
                    quatroPomodoris.Start();
                    break;

                case 5:
                    cincoPomodoris.Start();
                    break;

                case 6:
                    seisPomodoris.Start();
                    break;

                case 7:
                    setePomodoris.Start();
                    break;

                case 8:
                    oitoPomodoris.Start();
                    break;

                case 9:
                    novePomodoris.Start();
                    break;

                case 10:
                    dezPomodoris.Start();
                    break;

                default:
                    MessageBox.Show("Insira um valor e tente novamente!");
                    break;
            }
        }
    }
}
