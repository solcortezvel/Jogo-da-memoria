using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace jogo.memoria
{
    public partial class FormLevel1 : Form
    {

        bool soundON = false;
        static public bool login = false;
        const int nCartas = 20;
        byte nClics = 0; byte restantesCt = nCartas/2;
        Button cartaAnt;
        int ms = 0, sec = 0, min = 0;


        public FormLevel1()
        {
            InitializeComponent();
            timer1.Tick += timer1_Tick;
        }

        private void FormLevel1_Load(object sender, EventArgs e)
        {
            DistribuirCartas();
            AtribuirTags();
        }


        private void Pontos()
        {
            
        }
        private void Ocultar()
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                    x.Visible = false;
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "f")
                    x.Visible = false;
        }

        private void DistribuirCartas()
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                {
                    x.BackgroundImage = Properties.Resources.escudo_removebg_preview;
                    x.Visible = true;
                }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Ocultar();
        }


        private void AtribuirTags()
        {
            int[] tags = new int[nCartas];
            Random rnd = new Random();
            int i = 0; int n;
            while (i < nCartas)
            {
                n = rnd.Next(1, nCartas + 1);
                if (Array.IndexOf(tags, n) == -1)
                {
                    tags[i] = n;
                    i++;
                }
            }
            for (int j = 0; j < nCartas; j++)
                if (tags[j] > nCartas / 2)
                    tags[j] = tags[j] - (nCartas / 2);
            /* for (int j = 0; j < nCartas; j++)
                 MessageBox.Show("tags[" + j + "]=" + tags[j]);*/
            i = 0;
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                {
                    x.Tag = tags[i];
                    i++;
                }
        }

        private void CompararCartas(Button cAnt, Button cAtual)
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(600);
            if (cAnt == cAtual)
            {
                MessageBox.Show("Selecionou a mesma carta");
                nClics = 0;
                cAtual.BackgroundImage = Properties.Resources.escudo_removebg_preview;
            }
            else
            {
                if (cAtual.Tag.ToString() == cAnt.Tag.ToString())
                {
                    restantesCt--;
                    nClics = 0;
                    cAnt.Visible = false;
                    cAtual.Visible = false;
                    VerificarWin();
                }
                else
                {
                    nClics = 0;
                    cAnt.BackgroundImage = Properties.Resources.escudo_removebg_preview;
                    cAtual.BackgroundImage = Properties.Resources.escudo_removebg_preview;
                }
            }
        }
        private void OpenWin()
        {
            FormWin frm = new FormWin();
            frm.ShowDialog();
        }
        private void VerificarWin()
        {
            if (restantesCt == 0)
                OpenWin();

        }
        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                {
                    string s = "_" + x.Tag.ToString();
                    object o = Properties.Resources.ResourceManager.GetObject(s);
                    x.BackgroundImage = (System.Drawing.Image)o;
                }
            Application.DoEvents();
            System.Threading.Thread.Sleep(600);

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                    x.BackgroundImage = Properties.Resources.escudo_removebg_preview;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ms++;
            if (ms == 100)
            {
                ms = 0;
                sec++;
                if (sec == 60)
                {
                    sec = 0;
                    min++;
                }
            }
            labelTime.Text = $"{min:D2}:{sec:D2}:{ms:D2}";
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            ms = 0;
            sec = 0;
            min = 0;
            labelTime.Text = "00:00:00";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button cartaAtual = (sender as Button);
            string s = "_" + cartaAtual.Tag.ToString();
            object o = Properties.Resources.ResourceManager.GetObject(s);
            cartaAtual.BackgroundImage = (System.Drawing.Image)o;

            if (nClics == 0)
            {
                cartaAnt = cartaAtual;
                nClics++;
            }
            else
                CompararCartas(cartaAnt, cartaAtual);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
    }
}

