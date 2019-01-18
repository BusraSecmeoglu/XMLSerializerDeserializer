namespace XMLSerializerDeserializer
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnIceAktar = new System.Windows.Forms.Button();
            this.btnDısaAktar = new System.Windows.Forms.Button();
            this.lstBoxOgrenci = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(93, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(12, 46);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(22, 13);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Adı";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(12, 81);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(39, 13);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyadı";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(12, 124);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(70, 13);
            this.lblDogumTarihi.TabIndex = 2;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(33, 268);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnIceAktar
            // 
            this.btnIceAktar.Location = new System.Drawing.Point(363, 201);
            this.btnIceAktar.Name = "btnIceAktar";
            this.btnIceAktar.Size = new System.Drawing.Size(121, 53);
            this.btnIceAktar.TabIndex = 3;
            this.btnIceAktar.Text = "İçe Aktar(Deserializer)";
            this.btnIceAktar.UseVisualStyleBackColor = true;
            // 
            // btnDısaAktar
            // 
            this.btnDısaAktar.Location = new System.Drawing.Point(363, 304);
            this.btnDısaAktar.Name = "btnDısaAktar";
            this.btnDısaAktar.Size = new System.Drawing.Size(121, 42);
            this.btnDısaAktar.TabIndex = 3;
            this.btnDısaAktar.Text = "Dışa Aktar(Serializer)";
            this.btnDısaAktar.UseVisualStyleBackColor = true;
            // 
            // lstBoxOgrenci
            // 
            this.lstBoxOgrenci.FormattingEnabled = true;
            this.lstBoxOgrenci.Location = new System.Drawing.Point(584, 43);
            this.lstBoxOgrenci.Name = "lstBoxOgrenci";
            this.lstBoxOgrenci.Size = new System.Drawing.Size(187, 303);
            this.lstBoxOgrenci.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBoxOgrenci);
            this.Controls.Add(this.btnDısaAktar);
            this.Controls.Add(this.btnIceAktar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnIceAktar;
        private System.Windows.Forms.Button btnDısaAktar;
        private System.Windows.Forms.ListBox lstBoxOgrenci;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

