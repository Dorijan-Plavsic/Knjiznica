
namespace Knjiznica.Forms
{
    partial class DodajKnjige
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
            this.ISBN = new System.Windows.Forms.Label();
            this.BrojPrimjeraka = new System.Windows.Forms.Label();
            this.GodinaIzdanja = new System.Windows.Forms.Label();
            this.Naslov = new System.Windows.Forms.Label();
            this.Autor = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN.Location = new System.Drawing.Point(40, 44);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(56, 22);
            this.ISBN.TabIndex = 1;
            this.ISBN.Text = "ISBN:";
            // 
            // BrojPrimjeraka
            // 
            this.BrojPrimjeraka.AutoSize = true;
            this.BrojPrimjeraka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrojPrimjeraka.Location = new System.Drawing.Point(40, 305);
            this.BrojPrimjeraka.Name = "BrojPrimjeraka";
            this.BrojPrimjeraka.Size = new System.Drawing.Size(135, 22);
            this.BrojPrimjeraka.TabIndex = 2;
            this.BrojPrimjeraka.Text = "Broj primjeraka:";
            // 
            // GodinaIzdanja
            // 
            this.GodinaIzdanja.AutoSize = true;
            this.GodinaIzdanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GodinaIzdanja.Location = new System.Drawing.Point(40, 252);
            this.GodinaIzdanja.Name = "GodinaIzdanja";
            this.GodinaIzdanja.Size = new System.Drawing.Size(134, 22);
            this.GodinaIzdanja.TabIndex = 3;
            this.GodinaIzdanja.Text = "Godina izdanja:";
            this.GodinaIzdanja.Click += new System.EventHandler(this.label2_Click);
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naslov.Location = new System.Drawing.Point(40, 181);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(70, 22);
            this.Naslov.TabIndex = 4;
            this.Naslov.Text = "Naslov:";
            // 
            // Autor
            // 
            this.Autor.AutoSize = true;
            this.Autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autor.Location = new System.Drawing.Point(40, 116);
            this.Autor.Name = "Autor";
            this.Autor.Size = new System.Drawing.Size(58, 22);
            this.Autor.TabIndex = 5;
            this.Autor.Text = "Autor:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 183);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 30);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 118);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(355, 30);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 46);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(355, 30);
            this.textBox3.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(208, 255);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(208, 307);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(411, 353);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(70, 40);
            this.OK.TabIndex = 12;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // DodajKnjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 441);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Autor);
            this.Controls.Add(this.Naslov);
            this.Controls.Add(this.GodinaIzdanja);
            this.Controls.Add(this.BrojPrimjeraka);
            this.Controls.Add(this.ISBN);
            this.Name = "DodajKnjige";
            this.Text = "DodajKnjige";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.Label BrojPrimjeraka;
        private System.Windows.Forms.Label GodinaIzdanja;
        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Label Autor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button OK;
    }
}