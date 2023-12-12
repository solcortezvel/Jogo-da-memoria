using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace jogo.memoria
{
    public partial class Form1 : Form
    {
        bool soundON = false;
        static public bool login = false;   
        public Form1()
        {
            InitializeComponent();
        }       
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            buttonSom.Visible = true;
                  foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "o")
                    x.Visible = false;
            FormLogin frm = new FormLogin();
            frm.ShowDialog();        
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tsLabelData.Text = DateTime.Now.ToLongDateString();
            timer1.Enabled = true;
            SomInicial();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tsLabelHora.Text = DateTime.Now.ToLongTimeString();
        }       
        private void buttonSom_Click(object sender, EventArgs e)
        {
            Stream st = Properties.Resources.ukulele1;
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(st);
            if (soundON)
            {
                sp.Stop();
                soundON = false;
                buttonSom.BackgroundImage = Properties.Resources.download_removebg_preview__2_;
            }
            else
            {
                sp.PlayLooping();
                soundON = true;
                buttonSom.BackgroundImage = Properties.Resources.download_removebg_preview__3_;
            }
        }
        private void SomInicial()
        {
            Stream st = Properties.Resources.ukulele1;
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(st);
            sp.PlayLooping();
            soundON = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Application.Restart();
        }  
    }
}
