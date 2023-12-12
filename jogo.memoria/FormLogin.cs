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
    public partial class FormLogin : Form
    {
        string pathCd = "credenciais.txt";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Form1.login = false;
            string user = textBoxUser.Text;
            string pass = textBoxPass.Text;
            if ((user == "sol") && (pass == "sol"))
                Form1.login = true;
            else
                Form1.login=VerificarLogin(user, pass);
            Form3 frm = new Form3();
            frm.ShowDialog();
        }
        private bool VerificarLogin(string us, string ps)
        {
            if(File.Exists(pathCd))
            {
                string[] users = File.ReadAllLines(pathCd);
                foreach(string s in users)
                {
                    string[] dataUser = s.Split(':');
                    //string nUser = dataUser[0];
                    //string nPass = dataUser[1];
                    if (us == dataUser[0] && ps == dataUser[1])
                    {
                        MessageBox.Show("Seja bemvindo/a" + us+"!!");
                        return true;
                    }
                }
                MessageBox.Show("O user que inseriste não está associado a uma conta.");
            }return false;
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Form1.login = false;
            this.Close();
        }
        private void linkLabelMostrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelMostrar.Text == "Mostrar")
            {
                textBoxPass.UseSystemPasswordChar = false;
                linkLabelMostrar.Text = "Ocultar";
            }
            else
            {
                textBoxPass.UseSystemPasswordChar = true;
                linkLabelMostrar.Text = "Mostrar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNovoUser frm = new FormNovoUser();
            frm.ShowDialog();
            textBoxUser.Focus();
        }
    }
}
