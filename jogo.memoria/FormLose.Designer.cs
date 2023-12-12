
namespace jogo.memoria
{
    partial class FormLose
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(569, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 25);
            this.label4.TabIndex = 66;
            this.label4.Text = "Jogar de novo?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 30F);
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(180, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 58);
            this.label1.TabIndex = 62;
            this.label1.Text = "GAME OVER";
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.BackColor = System.Drawing.Color.MistyRose;
            this.buttonPlayAgain.BackgroundImage = global::jogo.memoria.Properties.Resources.play_game_or_start_symbol_colorful_game_button_png_removebg_preview;
            this.buttonPlayAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlayAgain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonPlayAgain.FlatAppearance.BorderSize = 0;
            this.buttonPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayAgain.Font = new System.Drawing.Font("NSimSun", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayAgain.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonPlayAgain.Location = new System.Drawing.Point(574, 270);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(94, 89);
            this.buttonPlayAgain.TabIndex = 68;
            this.buttonPlayAgain.Tag = "o";
            this.buttonPlayAgain.UseVisualStyleBackColor = false;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.MistyRose;
            this.buttonClose.BackgroundImage = global::jogo.memoria.Properties.Resources.wrong_or_exit_or_close_game_symbol_colorful_game_button_png_removebg_preview;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("NSimSun", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonClose.Location = new System.Drawing.Point(693, 270);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(98, 90);
            this.buttonClose.TabIndex = 67;
            this.buttonClose.Tag = "o";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::jogo.memoria.Properties.Resources.rumbling;
            this.pictureBox1.Location = new System.Drawing.Point(124, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 221);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // FormLose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(915, 494);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormLose";
            this.Load += new System.EventHandler(this.FormLose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPlayAgain;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}