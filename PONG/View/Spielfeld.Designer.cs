namespace PONG
{
    partial class Spielfeld
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxSpielfeld = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpielfeld)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSpielfeld
            // 
            this.pictureBoxSpielfeld.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxSpielfeld.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxSpielfeld.Name = "pictureBoxSpielfeld";
            this.pictureBoxSpielfeld.Size = new System.Drawing.Size(584, 561);
            this.pictureBoxSpielfeld.TabIndex = 0;
            this.pictureBoxSpielfeld.TabStop = false;
            // 
            // Spielfeld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.pictureBoxSpielfeld);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Spielfeld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PONG!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Spielfeld_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Spielfeld_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSpielfeld)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxSpielfeld;
    }
}

