
namespace jogo.memoria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLabelAutor = new System.Windows.Forms.ToolStripStatusLabel();
            this.I = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabelData = new System.Windows.Forms.ToolStripStatusLabel();
            this.l = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabelHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonSom = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabelAutor,
            this.I,
            this.tsLabelData,
            this.l,
            this.tsLabelHora});
            this.statusStrip1.Location = new System.Drawing.Point(9, 504);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(178, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Tag = "o";
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsLabelAutor
            // 
            this.tsLabelAutor.Name = "tsLabelAutor";
            this.tsLabelAutor.Size = new System.Drawing.Size(77, 17);
            this.tsLabelAutor.Text = "© Sol Cortez ";
            // 
            // I
            // 
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(10, 17);
            this.I.Text = "|";
            // 
            // tsLabelData
            // 
            this.tsLabelData.Name = "tsLabelData";
            this.tsLabelData.Size = new System.Drawing.Size(31, 17);
            this.tsLabelData.Text = "Data";
            // 
            // l
            // 
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(10, 17);
            this.l.Text = "|";
            // 
            // tsLabelHora
            // 
            this.tsLabelHora.Name = "tsLabelHora";
            this.tsLabelHora.Size = new System.Drawing.Size(33, 17);
            this.tsLabelHora.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLogin);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(281, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 490);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "o";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.MistyRose;
            this.buttonLogin.BackgroundImage = global::jogo.memoria.Properties.Resources.play_game_or_start_symbol_colorful_game_button_png_removebg_preview;
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("NSimSun", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Fuchsia;
            this.buttonLogin.Location = new System.Drawing.Point(103, 378);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(131, 123);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Tag = "o";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::jogo.memoria.Properties.Resources.Captura_de_pantalla_2023_09_30_113203_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(20, 52);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(305, 72);
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::jogo.memoria.Properties.Resources.escudo_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(51, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(228, 226);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "o";
            // 
            // buttonSom
            // 
            this.buttonSom.BackgroundImage = global::jogo.memoria.Properties.Resources.download_removebg_preview__2_;
            this.buttonSom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSom.Location = new System.Drawing.Point(855, 12);
            this.buttonSom.Name = "buttonSom";
            this.buttonSom.Size = new System.Drawing.Size(30, 29);
            this.buttonSom.TabIndex = 41;
            this.buttonSom.Tag = "";
            this.buttonSom.UseVisualStyleBackColor = true;
            this.buttonSom.Click += new System.EventHandler(this.buttonSom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(897, 527);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSom);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "MEMOMEMO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelAutor;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelData;
        private System.Windows.Forms.ToolStripStatusLabel I;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel l;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelHora;
        private System.Windows.Forms.Button buttonSom;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

