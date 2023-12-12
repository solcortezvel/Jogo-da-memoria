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
    public partial class FormLose : Form
    {
        public FormLose()
        {
            InitializeComponent();
        }

        private void FormLose_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
                frm.Close();
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
    }
}
