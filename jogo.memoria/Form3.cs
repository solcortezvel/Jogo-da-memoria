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
    public partial class Form3 : Form
    {
        bool soundON = false;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLevel1 frm = new FormLevel1();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLevel2 frm = new FormLevel2();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLevel3 frm = new FormLevel3();
            frm.ShowDialog();
        }

        private void buttonSom_Click(object sender, EventArgs e)
        {
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
        }
            private void SomInicial()
            {
                Stream st = Properties.Resources.ukulele1;
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer(st);
                sp.PlayLooping();
                soundON = true;
            }
        }
}
