using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo.memoria
{
    public partial class FormWin : Form
    {
        public FormWin()
        {
            InitializeComponent();
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
                    frm.Close();
                //this.Close();
        }

        private void FormWin_Load(object sender, EventArgs e)
        {
            labelBPoint.Text = (1 + "pontos");
            labelBPoint.Text = (1 + "pontos");
        }
    }
}
