
namespace Knjiznica.Forms
{
    partial class Ucenici
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
            this.UceniciLabel = new System.Windows.Forms.Label();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Uredi = new System.Windows.Forms.Button();
            this.Brisi = new System.Windows.Forms.Button();
            this.lbUcenici = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // UceniciLabel
            // 
            this.UceniciLabel.AutoSize = true;
            this.UceniciLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UceniciLabel.Location = new System.Drawing.Point(12, 44);
            this.UceniciLabel.Name = "UceniciLabel";
            this.UceniciLabel.Size = new System.Drawing.Size(74, 22);
            this.UceniciLabel.TabIndex = 1;
            this.UceniciLabel.Text = "Učenici:";
            // 
            // Dodaj
            // 
            this.Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dodaj.Location = new System.Drawing.Point(421, 87);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(120, 50);
            this.Dodaj.TabIndex = 7;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Uredi
            // 
            this.Uredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uredi.Location = new System.Drawing.Point(421, 153);
            this.Uredi.Name = "Uredi";
            this.Uredi.Size = new System.Drawing.Size(120, 50);
            this.Uredi.TabIndex = 8;
            this.Uredi.Text = "Uredi";
            this.Uredi.UseVisualStyleBackColor = true;
            // 
            // Brisi
            // 
            this.Brisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brisi.Location = new System.Drawing.Point(421, 242);
            this.Brisi.Name = "Brisi";
            this.Brisi.Size = new System.Drawing.Size(120, 50);
            this.Brisi.TabIndex = 9;
            this.Brisi.Text = "Briši";
            this.Brisi.UseVisualStyleBackColor = true;
            // 
            // lbUcenici
            // 
            this.lbUcenici.FormattingEnabled = true;
            this.lbUcenici.Location = new System.Drawing.Point(16, 87);
            this.lbUcenici.Name = "lbUcenici";
            this.lbUcenici.Size = new System.Drawing.Size(304, 251);
            this.lbUcenici.TabIndex = 10;
            // 
            // Ucenici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 394);
            this.Controls.Add(this.lbUcenici);
            this.Controls.Add(this.Brisi);
            this.Controls.Add(this.Uredi);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.UceniciLabel);
            this.Name = "Ucenici";
            this.Text = "Ucenici";
            this.Load += new System.EventHandler(this.Ucenici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UceniciLabel;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button Uredi;
        private System.Windows.Forms.Button Brisi;
        private System.Windows.Forms.ListBox lbUcenici;
    }
}