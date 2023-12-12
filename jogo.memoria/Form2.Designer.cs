
namespace jogo.memoria
{
    partial class FormNovoUser
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonRegistar = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxRep = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.MistyRose;
            this.buttonCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonCancelar.FlatAppearance.BorderSize = 3;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("NSimSun", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonCancelar.Location = new System.Drawing.Point(241, 287);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(128, 36);
            this.buttonCancelar.TabIndex = 33;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonRegistar
            // 
            this.buttonRegistar.BackColor = System.Drawing.Color.MistyRose;
            this.buttonRegistar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonRegistar.FlatAppearance.BorderSize = 3;
            this.buttonRegistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistar.Font = new System.Drawing.Font("MS PGothic", 12.55F, System.Drawing.FontStyle.Bold);
            this.buttonRegistar.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonRegistar.Location = new System.Drawing.Point(86, 287);
            this.buttonRegistar.Name = "buttonRegistar";
            this.buttonRegistar.Size = new System.Drawing.Size(128, 36);
            this.buttonRegistar.TabIndex = 32;
            this.buttonRegistar.Text = "Registar";
            this.buttonRegistar.UseVisualStyleBackColor = false;
            this.buttonRegistar.Click += new System.EventHandler(this.buttonRegistar_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.Color.Snow;
            this.textBoxUser.Font = new System.Drawing.Font("NSimSun", 11F, System.Drawing.FontStyle.Bold);
            this.textBoxUser.ForeColor = System.Drawing.Color.Magenta;
            this.textBoxUser.Location = new System.Drawing.Point(86, 129);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.ShortcutsEnabled = false;
            this.textBoxUser.Size = new System.Drawing.Size(220, 24);
            this.textBoxUser.TabIndex = 30;
            this.textBoxUser.Text = "username";
            // 
            // textBoxRep
            // 
            this.textBoxRep.BackColor = System.Drawing.Color.Snow;
            this.textBoxRep.Font = new System.Drawing.Font("NSimSun", 11F, System.Drawing.FontStyle.Bold);
            this.textBoxRep.ForeColor = System.Drawing.Color.Magenta;
            this.textBoxRep.Location = new System.Drawing.Point(86, 226);
            this.textBoxRep.Name = "textBoxRep";
            this.textBoxRep.ShortcutsEnabled = false;
            this.textBoxRep.Size = new System.Drawing.Size(220, 24);
            this.textBoxRep.TabIndex = 32;
            this.textBoxRep.Text = "repetir password";
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.Snow;
            this.textBoxPass.Font = new System.Drawing.Font("NSimSun", 11F, System.Drawing.FontStyle.Bold);
            this.textBoxPass.ForeColor = System.Drawing.Color.Magenta;
            this.textBoxPass.Location = new System.Drawing.Point(86, 176);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.ShortcutsEnabled = false;
            this.textBoxPass.Size = new System.Drawing.Size(220, 24);
            this.textBoxPass.TabIndex = 31;
            this.textBoxPass.Text = "password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jogo.memoria.Properties.Resources.escudo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(393, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // FormNovoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(717, 446);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxRep);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonRegistar);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNovoUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormNovoUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonRegistar;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxRep;
        private System.Windows.Forms.TextBox textBoxPass;
    }
}