
namespace Knjiznica.Forms
{
    partial class DetaljiPosudbe
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
            this.Ucenik = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Knjiga = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DatumPosudbe = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BrojDana = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ucenik
            // 
            this.Ucenik.AutoSize = true;
            this.Ucenik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ucenik.Location = new System.Drawing.Point(12, 63);
            this.Ucenik.Name = "Ucenik";
            this.Ucenik.Size = new System.Drawing.Size(70, 22);
            this.Ucenik.TabIndex = 0;
            this.Ucenik.Text = "Učenik:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 221);
            this.textBox1.TabIndex = 1;
            // 
            // Knjiga
            // 
            this.Knjiga.AutoSize = true;
            this.Knjiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Knjiga.Location = new System.Drawing.Point(12, 330);
            this.Knjiga.Name = "Knjiga";
            this.Knjiga.Size = new System.Drawing.Size(65, 22);
            this.Knjiga.TabIndex = 2;
            this.Knjiga.Text = "Knjiga:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 355);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(301, 221);
            this.textBox2.TabIndex = 3;
            // 
            // DatumPosudbe
            // 
            this.DatumPosudbe.AutoSize = true;
            this.DatumPosudbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatumPosudbe.Location = new System.Drawing.Point(376, 86);
            this.DatumPosudbe.Name = "DatumPosudbe";
            this.DatumPosudbe.Size = new System.Drawing.Size(141, 22);
            this.DatumPosudbe.TabIndex = 4;
            this.DatumPosudbe.Text = "Datum posudbe:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(380, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(380, 242);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // BrojDana
            // 
            this.BrojDana.AutoSize = true;
            this.BrojDana.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrojDana.Location = new System.Drawing.Point(376, 207);
            this.BrojDana.Name = "BrojDana";
            this.BrojDana.Size = new System.Drawing.Size(92, 22);
            this.BrojDana.TabIndex = 7;
            this.BrojDana.Text = "Broj dana:";
            // 
            // OK
            // 
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.Location = new System.Drawing.Point(500, 302);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(80, 50);
            this.OK.TabIndex = 8;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // DetaljiPosudbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 622);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.BrojDana);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DatumPosudbe);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Knjiga);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Ucenik);
            this.Name = "DetaljiPosudbe";
            this.Text = "DetaljiPosudbe";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ucenik;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Knjiga;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label DatumPosudbe;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label BrojDana;
        private System.Windows.Forms.Button OK;
    }
}