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
    public partial class FormNovoUser : Form
    {
        public FormNovoUser()
        {
            InitializeComponent();
        }
        public string pathCd = "credenciais.txt";

        private void buttonRegistar_Click(object sender, EventArgs e)
        {
            if(textBoxUser.Text!=""&& textBoxPass.Text!="")
            {
                if (textBoxPass.Text == textBoxPass.Text)
                {
                    if (!UtilizadorExistente(textBoxUser.Text))
                        RegistarUtilizador(textBoxUser.Text, textBoxPass.Text);
                    else
                    {
                        MessageBox.Show("Utilizador já existente");
                        textBoxUser.Text = "";
                        textBoxPass.Text = "";
                        textBoxRep.Text = "";
                        textBoxUser.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("As passwords não coincidem");
                    textBoxPass.Text = "";
                    textBoxRep.Text = "";
                    textBoxPass.Focus();
                }
            }
        }
        private bool UtilizadorExistente(string user)
        {
            
            if (File.Exists(pathCd))
            {
                try
                {
                    string[] dataUsers = File.ReadAllLines(pathCd);
                    foreach (string linha in dataUsers)
                    {
                        string[] dataUsr = linha.Split(':');
                        if (user == dataUsr[0]) return true;
                    }
                }
                catch(Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }return false;
        }
        private void RegistarUtilizador(string user, string pass)
        {
            try
            {
                string texto ="\n"+ user + ":" + pass;
                File.AppendAllText(pathCd, texto);
                MessageBox.Show("Dados do utilizador registados com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNovoUser_Load(object sender, EventArgs e)
        {

        }
    }
}
