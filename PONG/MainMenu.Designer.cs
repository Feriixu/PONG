namespace PONG
{
    partial class MainMenu
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
            this.pictureBoxEinzelspieler = new System.Windows.Forms.PictureBox();
            this.pictureBoxMehrspieler = new System.Windows.Forms.PictureBox();
            this.pictureBoxEndlos = new System.Windows.Forms.PictureBox();
            this.pictureBoxPunkte = new System.Windows.Forms.PictureBox();
            this.pictureBoxXButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEinzelspieler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMehrspieler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEndlos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPunkte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxXButton)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEinzelspieler
            // 
            this.pictureBoxEinzelspieler.BackColor = System.Drawing.Color.Black;
            this.pictureBoxEinzelspieler.BackgroundImage = global::PONG.Properties.Resources.einzelDisabled;
            this.pictureBoxEinzelspieler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxEinzelspieler.Location = new System.Drawing.Point(183, 264);
            this.pictureBoxEinzelspieler.Name = "pictureBoxEinzelspieler";
            this.pictureBoxEinzelspieler.Size = new System.Drawing.Size(289, 32);
            this.pictureBoxEinzelspieler.TabIndex = 0;
            this.pictureBoxEinzelspieler.TabStop = false;
            this.pictureBoxEinzelspieler.Click += new System.EventHandler(this.PictureBoxEinzelspieler_Click);
            this.pictureBoxEinzelspieler.MouseEnter += new System.EventHandler(this.PictureBoxEinzelspieler_MouseEnter);
            this.pictureBoxEinzelspieler.MouseLeave += new System.EventHandler(this.PictureBoxEinzelspieler_MouseLeave);
            // 
            // pictureBoxMehrspieler
            // 
            this.pictureBoxMehrspieler.BackColor = System.Drawing.Color.Black;
            this.pictureBoxMehrspieler.BackgroundImage = global::PONG.Properties.Resources.mehrDisabled;
            this.pictureBoxMehrspieler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMehrspieler.Location = new System.Drawing.Point(256, 312);
            this.pictureBoxMehrspieler.Name = "pictureBoxMehrspieler";
            this.pictureBoxMehrspieler.Size = new System.Drawing.Size(289, 32);
            this.pictureBoxMehrspieler.TabIndex = 1;
            this.pictureBoxMehrspieler.TabStop = false;
            this.pictureBoxMehrspieler.Click += new System.EventHandler(this.PictureBoxMehrspieler_Click);
            this.pictureBoxMehrspieler.MouseEnter += new System.EventHandler(this.PictureBoxMehrspieler_MouseEnter);
            this.pictureBoxMehrspieler.MouseLeave += new System.EventHandler(this.PictureBoxMehrspieler_MouseLeave);
            // 
            // pictureBoxEndlos
            // 
            this.pictureBoxEndlos.BackColor = System.Drawing.Color.Black;
            this.pictureBoxEndlos.BackgroundImage = global::PONG.Properties.Resources.endlosDisabled;
            this.pictureBoxEndlos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxEndlos.Location = new System.Drawing.Point(550, 271);
            this.pictureBoxEndlos.Name = "pictureBoxEndlos";
            this.pictureBoxEndlos.Size = new System.Drawing.Size(140, 39);
            this.pictureBoxEndlos.TabIndex = 2;
            this.pictureBoxEndlos.TabStop = false;
            this.pictureBoxEndlos.Click += new System.EventHandler(this.PictureBoxEndlos_Click);
            // 
            // pictureBoxPunkte
            // 
            this.pictureBoxPunkte.BackColor = System.Drawing.Color.Black;
            this.pictureBoxPunkte.BackgroundImage = global::PONG.Properties.Resources.punkte;
            this.pictureBoxPunkte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPunkte.Location = new System.Drawing.Point(550, 226);
            this.pictureBoxPunkte.Name = "pictureBoxPunkte";
            this.pictureBoxPunkte.Size = new System.Drawing.Size(140, 39);
            this.pictureBoxPunkte.TabIndex = 3;
            this.pictureBoxPunkte.TabStop = false;
            this.pictureBoxPunkte.Click += new System.EventHandler(this.PictureBoxPunkte_Click);
            // 
            // pictureBoxXButton
            // 
            this.pictureBoxXButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxXButton.BackgroundImage = global::PONG.Properties.Resources.xButtonDisabled;
            this.pictureBoxXButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxXButton.Location = new System.Drawing.Point(634, 40);
            this.pictureBoxXButton.Name = "pictureBoxXButton";
            this.pictureBoxXButton.Size = new System.Drawing.Size(56, 58);
            this.pictureBoxXButton.TabIndex = 4;
            this.pictureBoxXButton.TabStop = false;
            this.pictureBoxXButton.Click += new System.EventHandler(this.PictureBoxXButton_Click);
            this.pictureBoxXButton.MouseEnter += new System.EventHandler(this.PictureBoxXButton_MouseEnter);
            this.pictureBoxXButton.MouseLeave += new System.EventHandler(this.PictureBoxXButton_MouseLeave);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::PONG.Properties.Resources.title;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(893, 568);
            this.Controls.Add(this.pictureBoxXButton);
            this.Controls.Add(this.pictureBoxPunkte);
            this.Controls.Add(this.pictureBoxEndlos);
            this.Controls.Add(this.pictureBoxMehrspieler);
            this.Controls.Add(this.pictureBoxEinzelspieler);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainMenu_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEinzelspieler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMehrspieler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEndlos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPunkte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxXButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEinzelspieler;
        private System.Windows.Forms.PictureBox pictureBoxMehrspieler;
        private System.Windows.Forms.PictureBox pictureBoxEndlos;
        private System.Windows.Forms.PictureBox pictureBoxPunkte;
        private System.Windows.Forms.PictureBox pictureBoxXButton;
    }
}