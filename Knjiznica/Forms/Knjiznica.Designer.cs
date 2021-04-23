
namespace Knjiznica.Forms
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UčeniciLabel = new System.Windows.Forms.Label();
            this.KnjigeLabel = new System.Windows.Forms.Label();
            this.PosuđeneKnjige = new System.Windows.Forms.Label();
            this.Učenici = new System.Windows.Forms.Button();
            this.Knjige = new System.Windows.Forms.Button();
            this.PosudiButton = new System.Windows.Forms.Button();
            this.IzmijeniButton = new System.Windows.Forms.Button();
            this.VratiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 125);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(537, 313);
            this.textBox1.TabIndex = 0;
            // 
            // UčeniciLabel
            // 
            this.UčeniciLabel.AutoSize = true;
            this.UčeniciLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UčeniciLabel.Location = new System.Drawing.Point(12, 37);
            this.UčeniciLabel.Name = "UčeniciLabel";
            this.UčeniciLabel.Size = new System.Drawing.Size(69, 22);
            this.UčeniciLabel.TabIndex = 1;
            this.UčeniciLabel.Text = "Učenici";
            this.UčeniciLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // KnjigeLabel
            // 
            this.KnjigeLabel.AutoSize = true;
            this.KnjigeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KnjigeLabel.Location = new System.Drawing.Point(108, 37);
            this.KnjigeLabel.Name = "KnjigeLabel";
            this.KnjigeLabel.Size = new System.Drawing.Size(60, 22);
            this.KnjigeLabel.TabIndex = 2;
            this.KnjigeLabel.Text = "Knjige";
            // 
            // PosuđeneKnjige
            // 
            this.PosuđeneKnjige.AutoSize = true;
            this.PosuđeneKnjige.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosuđeneKnjige.Location = new System.Drawing.Point(12, 96);
            this.PosuđeneKnjige.Name = "PosuđeneKnjige";
            this.PosuđeneKnjige.Size = new System.Drawing.Size(148, 22);
            this.PosuđeneKnjige.TabIndex = 3;
            this.PosuđeneKnjige.Text = "Posuđene knjige:";
            // 
            // Učenici
            // 
            this.Učenici.Location = new System.Drawing.Point(181, 96);
            this.Učenici.Name = "Učenici";
            this.Učenici.Size = new System.Drawing.Size(110, 23);
            this.Učenici.TabIndex = 4;
            this.Učenici.Text = "Učenici";
            this.Učenici.UseVisualStyleBackColor = true;
            // 
            // Knjige
            // 
            this.Knjige.Location = new System.Drawing.Point(297, 96);
            this.Knjige.Name = "Knjige";
            this.Knjige.Size = new System.Drawing.Size(110, 23);
            this.Knjige.TabIndex = 5;
            this.Knjige.Text = "Knjige";
            this.Knjige.UseVisualStyleBackColor = true;
            // 
            // PosudiButton
            // 
            this.PosudiButton.Location = new System.Drawing.Point(623, 133);
            this.PosudiButton.Name = "PosudiButton";
            this.PosudiButton.Size = new System.Drawing.Size(120, 40);
            this.PosudiButton.TabIndex = 6;
            this.PosudiButton.Text = "Posudi";
            this.PosudiButton.UseVisualStyleBackColor = true;
            // 
            // IzmijeniButton
            // 
            this.IzmijeniButton.Location = new System.Drawing.Point(623, 179);
            this.IzmijeniButton.Name = "IzmijeniButton";
            this.IzmijeniButton.Size = new System.Drawing.Size(120, 40);
            this.IzmijeniButton.TabIndex = 7;
            this.IzmijeniButton.Text = "Izmijeni";
            this.IzmijeniButton.UseVisualStyleBackColor = true;
            // 
            // VratiButton
            // 
            this.VratiButton.Location = new System.Drawing.Point(623, 256);
            this.VratiButton.Name = "VratiButton";
            this.VratiButton.Size = new System.Drawing.Size(120, 40);
            this.VratiButton.TabIndex = 8;
            this.VratiButton.Text = "Vrati";
            this.VratiButton.UseVisualStyleBackColor = true;
            this.VratiButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 445);
            this.Controls.Add(this.VratiButton);
            this.Controls.Add(this.IzmijeniButton);
            this.Controls.Add(this.PosudiButton);
            this.Controls.Add(this.Knjige);
            this.Controls.Add(this.Učenici);
            this.Controls.Add(this.PosuđeneKnjige);
            this.Controls.Add(this.KnjigeLabel);
            this.Controls.Add(this.UčeniciLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Knjižnica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label UčeniciLabel;
        private System.Windows.Forms.Label KnjigeLabel;
        private System.Windows.Forms.Label PosuđeneKnjige;
        private System.Windows.Forms.Button Učenici;
        private System.Windows.Forms.Button Knjige;
        private System.Windows.Forms.Button PosudiButton;
        private System.Windows.Forms.Button IzmijeniButton;
        private System.Windows.Forms.Button VratiButton;
    }
}