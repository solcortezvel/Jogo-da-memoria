
namespace jogo.memoria
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.linkLabelMostrar = new System.Windows.Forms.LinkLabel();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.Snow;
            this.textBoxUser.Font = new System.Drawing.Font("NSimSun", 11F, System.Drawing.FontStyle.Bold);
            this.textBoxUser.ForeColor = System.Drawing.Color.Magenta;
            this.textBoxUser.Location = new System.Drawing.Point(325, 308);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.ShortcutsEnabled = false;
            this.textBoxUser.Size = new System.Drawing.Size(194, 24);
            this.textBoxUser.TabIndex = 23;
            this.textBoxUser.Text = "username";
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.Snow;
            this.textBoxPass.Font = new System.Drawing.Font("NSimSun", 11F);
            this.textBoxPass.ForeColor = System.Drawing.Color.Magenta;
            this.textBoxPass.Location = new System.Drawing.Point(325, 351);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.ShortcutsEnabled = false;
            this.textBoxPass.Size = new System.Drawing.Size(194, 24);
            this.textBoxPass.TabIndex = 24;
            this.textBoxPass.Text = "password";
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // linkLabelMostrar
            // 
            this.linkLabelMostrar.AutoSize = true;
            this.linkLabelMostrar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelMostrar.LinkColor = System.Drawing.Color.Magenta;
            this.linkLabelMostrar.Location = new System.Drawing.Point(537, 356);
            this.linkLabelMostrar.Name = "linkLabelMostrar";
            this.linkLabelMostrar.Size = new System.Drawing.Size(42, 13);
            this.linkLabelMostrar.TabIndex = 25;
            this.linkLabelMostrar.TabStop = true;
            this.linkLabelMostrar.Text = "Mostrar";
            this.linkLabelMostrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMostrar_LinkClicked);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.MistyRose;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonCancelar.FlatAppearance.BorderSize = 3;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("NSimSun", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonCancelar.Location = new System.Drawing.Point(92, 234);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(181, 36);
            this.buttonCancelar.TabIndex = 27;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.BackColor = System.Drawing.Color.MistyRose;
            this.buttonEntrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonEntrar.FlatAppearance.BorderSize = 3;
            this.buttonEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEntrar.Font = new System.Drawing.Font("MS PGothic", 12.55F, System.Drawing.FontStyle.Bold);
            this.buttonEntrar.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonEntrar.Location = new System.Drawing.Point(92, 170);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(181, 36);
            this.buttonEntrar.TabIndex = 26;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = false;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jogo.memoria.Properties.Resources.escudo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(378, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS PGothic", 12.55F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Fuchsia;
            this.button1.Location = new System.Drawing.Point(92, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 36);
            this.button1.TabIndex = 28;
            this.button1.Text = "Criar conta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(733, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.linkLabelMostrar);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.LinkLabel linkLabelMostrar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Button button1;
    }
}