
namespace jogo.memoria
{
    partial class FormWin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPoint = new System.Windows.Forms.Label();
            this.labelBPoint = new System.Windows.Forms.Label();
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 30F);
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(139, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 58);
            this.label1.TabIndex = 53;
            this.label1.Text = "PARABENS!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(506, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 23);
            this.label2.TabIndex = 55;
            this.label2.Text = "Tua pontuação: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(506, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Melhor pontuação: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(583, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 25);
            this.label4.TabIndex = 57;
            this.label4.Text = "Jogar de novo?";
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Font = new System.Drawing.Font("OCR A Extended", 15.75F);
            this.labelPoint.Location = new System.Drawing.Point(703, 213);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(23, 23);
            this.labelPoint.TabIndex = 60;
            this.labelPoint.Text = "l";
            // 
            // labelBPoint
            // 
            this.labelBPoint.AutoSize = true;
            this.labelBPoint.Font = new System.Drawing.Font("OCR A Extended", 15.75F);
            this.labelBPoint.Location = new System.Drawing.Point(736, 258);
            this.labelBPoint.Name = "labelBPoint";
            this.labelBPoint.Size = new System.Drawing.Size(23, 23);
            this.labelBPoint.TabIndex = 61;
            this.labelBPoint.Text = "l";
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
            this.buttonPlayAgain.Location = new System.Drawing.Point(588, 375);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(94, 89);
            this.buttonPlayAgain.TabIndex = 59;
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
            this.buttonClose.Location = new System.Drawing.Point(707, 375);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(98, 90);
            this.buttonClose.TabIndex = 58;
            this.buttonClose.Tag = "o";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::jogo.memoria.Properties.Resources.rumbling;
            this.pictureBox1.Location = new System.Drawing.Point(83, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 221);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // FormWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(905, 491);
            this.Controls.Add(this.labelBPoint);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.buttonPlayAgain);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MEMOMEMO";
            this.Load += new System.EventHandler(this.FormWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonPlayAgain;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.Label labelBPoint;
    }
}