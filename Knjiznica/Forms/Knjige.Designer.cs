
namespace Knjiznica.Forms
{
    partial class Knjige
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
            this.KnjigeLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Brisi = new System.Windows.Forms.Button();
            this.Uredi = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KnjigeLabel
            // 
            this.KnjigeLabel.AutoSize = true;
            this.KnjigeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KnjigeLabel.Location = new System.Drawing.Point(32, 43);
            this.KnjigeLabel.Name = "KnjigeLabel";
            this.KnjigeLabel.Size = new System.Drawing.Size(65, 22);
            this.KnjigeLabel.TabIndex = 2;
            this.KnjigeLabel.Text = "Knjige:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 340);
            this.textBox1.TabIndex = 3;
            // 
            // Brisi
            // 
            this.Brisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brisi.Location = new System.Drawing.Point(405, 232);
            this.Brisi.Name = "Brisi";
            this.Brisi.Size = new System.Drawing.Size(120, 50);
            this.Brisi.TabIndex = 12;
            this.Brisi.Text = "Briši";
            this.Brisi.UseVisualStyleBackColor = true;
            // 
            // Uredi
            // 
            this.Uredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uredi.Location = new System.Drawing.Point(405, 143);
            this.Uredi.Name = "Uredi";
            this.Uredi.Size = new System.Drawing.Size(120, 50);
            this.Uredi.TabIndex = 11;
            this.Uredi.Text = "Uredi";
            this.Uredi.UseVisualStyleBackColor = true;
            // 
            // Dodaj
            // 
            this.Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dodaj.Location = new System.Drawing.Point(405, 77);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(120, 50);
            this.Dodaj.TabIndex = 10;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            // 
            // Knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 445);
            this.Controls.Add(this.Brisi);
            this.Controls.Add(this.Uredi);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.KnjigeLabel);
            this.Name = "Knjige";
            this.Text = "Knjige";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KnjigeLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Brisi;
        private System.Windows.Forms.Button Uredi;
        private System.Windows.Forms.Button Dodaj;
    }
}