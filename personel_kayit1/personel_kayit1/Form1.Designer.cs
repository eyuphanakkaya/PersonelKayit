namespace personel_kayit1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_psoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_pad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pmeslek = new System.Windows.Forms.TextBox();
            this.comboBoxsehir = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxmaas = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_list = new System.Windows.Forms.Button();
            this.button_kaydet = new System.Windows.Forms.Button();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_guncelle = new System.Windows.Forms.Button();
            this.button_temizle = new System.Windows.Forms.Button();
            this.button_ist = new System.Windows.Forms.Button();
            this.button_grafik = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonevli = new System.Windows.Forms.RadioButton();
            this.radioButtonbekar = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonbekar);
            this.groupBox1.Controls.Add(this.radioButtonevli);
            this.groupBox1.Controls.Add(this.maskedTextBoxmaas);
            this.groupBox1.Controls.Add(this.comboBoxsehir);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_pmeslek);
            this.groupBox1.Controls.Add(this.txt_pad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_psoyad);
            this.groupBox1.Controls.Add(this.txt_pid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "p_id:";
            // 
            // txt_pid
            // 
            this.txt_pid.Location = new System.Drawing.Point(94, 54);
            this.txt_pid.Name = "txt_pid";
            this.txt_pid.Size = new System.Drawing.Size(150, 32);
            this.txt_pid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "p_soyadi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "p_maas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "p_durum:";
            // 
            // txt_psoyad
            // 
            this.txt_psoyad.Location = new System.Drawing.Point(94, 134);
            this.txt_psoyad.Name = "txt_psoyad";
            this.txt_psoyad.Size = new System.Drawing.Size(150, 32);
            this.txt_psoyad.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "p_sehir:";
            // 
            // txt_pad
            // 
            this.txt_pad.Location = new System.Drawing.Point(94, 96);
            this.txt_pad.Name = "txt_pad";
            this.txt_pad.Size = new System.Drawing.Size(150, 32);
            this.txt_pad.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "p_adi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-4, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "p_meslek:";
            // 
            // txt_pmeslek
            // 
            this.txt_pmeslek.Location = new System.Drawing.Point(94, 286);
            this.txt_pmeslek.Name = "txt_pmeslek";
            this.txt_pmeslek.Size = new System.Drawing.Size(150, 32);
            this.txt_pmeslek.TabIndex = 8;
            // 
            // comboBoxsehir
            // 
            this.comboBoxsehir.FormattingEnabled = true;
            this.comboBoxsehir.Location = new System.Drawing.Point(94, 172);
            this.comboBoxsehir.Name = "comboBoxsehir";
            this.comboBoxsehir.Size = new System.Drawing.Size(150, 32);
            this.comboBoxsehir.TabIndex = 4;
            // 
            // maskedTextBoxmaas
            // 
            this.maskedTextBoxmaas.Location = new System.Drawing.Point(94, 210);
            this.maskedTextBoxmaas.Mask = "0000";
            this.maskedTextBoxmaas.Name = "maskedTextBoxmaas";
            this.maskedTextBoxmaas.Size = new System.Drawing.Size(150, 32);
            this.maskedTextBoxmaas.TabIndex = 5;
            this.maskedTextBoxmaas.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_grafik);
            this.groupBox2.Controls.Add(this.button_ist);
            this.groupBox2.Controls.Add(this.button_guncelle);
            this.groupBox2.Controls.Add(this.button_temizle);
            this.groupBox2.Controls.Add(this.button_sil);
            this.groupBox2.Controls.Add(this.button_kaydet);
            this.groupBox2.Controls.Add(this.button_list);
            this.groupBox2.Location = new System.Drawing.Point(466, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 340);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // button_list
            // 
            this.button_list.Location = new System.Drawing.Point(36, 20);
            this.button_list.Name = "button_list";
            this.button_list.Size = new System.Drawing.Size(125, 39);
            this.button_list.TabIndex = 0;
            this.button_list.Text = "Listeleme";
            this.button_list.UseVisualStyleBackColor = true;
            // 
            // button_kaydet
            // 
            this.button_kaydet.Location = new System.Drawing.Point(36, 65);
            this.button_kaydet.Name = "button_kaydet";
            this.button_kaydet.Size = new System.Drawing.Size(125, 39);
            this.button_kaydet.TabIndex = 1;
            this.button_kaydet.Text = "Kaydet";
            this.button_kaydet.UseVisualStyleBackColor = true;
            // 
            // button_sil
            // 
            this.button_sil.Location = new System.Drawing.Point(36, 110);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(125, 39);
            this.button_sil.TabIndex = 2;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = true;
            // 
            // button_guncelle
            // 
            this.button_guncelle.Location = new System.Drawing.Point(36, 151);
            this.button_guncelle.Name = "button_guncelle";
            this.button_guncelle.Size = new System.Drawing.Size(125, 39);
            this.button_guncelle.TabIndex = 3;
            this.button_guncelle.Text = "Güncelle";
            this.button_guncelle.UseVisualStyleBackColor = true;
            // 
            // button_temizle
            // 
            this.button_temizle.Location = new System.Drawing.Point(36, 196);
            this.button_temizle.Name = "button_temizle";
            this.button_temizle.Size = new System.Drawing.Size(125, 39);
            this.button_temizle.TabIndex = 4;
            this.button_temizle.Text = "Temizleme";
            this.button_temizle.UseVisualStyleBackColor = true;
            // 
            // button_ist
            // 
            this.button_ist.Location = new System.Drawing.Point(36, 241);
            this.button_ist.Name = "button_ist";
            this.button_ist.Size = new System.Drawing.Size(125, 39);
            this.button_ist.TabIndex = 5;
            this.button_ist.Text = "İstatistik";
            this.button_ist.UseVisualStyleBackColor = true;
            // 
            // button_grafik
            // 
            this.button_grafik.Location = new System.Drawing.Point(36, 286);
            this.button_grafik.Name = "button_grafik";
            this.button_grafik.Size = new System.Drawing.Size(125, 39);
            this.button_grafik.TabIndex = 6;
            this.button_grafik.Text = "Grafikler";
            this.button_grafik.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(27, 370);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(829, 161);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(823, 130);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(719, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonevli
            // 
            this.radioButtonevli.AutoSize = true;
            this.radioButtonevli.Location = new System.Drawing.Point(97, 252);
            this.radioButtonevli.Name = "radioButtonevli";
            this.radioButtonevli.Size = new System.Drawing.Size(61, 28);
            this.radioButtonevli.TabIndex = 6;
            this.radioButtonevli.TabStop = true;
            this.radioButtonevli.Text = "Evli";
            this.radioButtonevli.UseVisualStyleBackColor = true;
            // 
            // radioButtonbekar
            // 
            this.radioButtonbekar.AutoSize = true;
            this.radioButtonbekar.Location = new System.Drawing.Point(164, 252);
            this.radioButtonbekar.Name = "radioButtonbekar";
            this.radioButtonbekar.Size = new System.Drawing.Size(80, 28);
            this.radioButtonbekar.TabIndex = 7;
            this.radioButtonbekar.TabStop = true;
            this.radioButtonbekar.Text = "Bekar";
            this.radioButtonbekar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(859, 543);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxmaas;
        private System.Windows.Forms.ComboBox comboBoxsehir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_pmeslek;
        private System.Windows.Forms.TextBox txt_pad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_psoyad;
        private System.Windows.Forms.TextBox txt_pid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_grafik;
        private System.Windows.Forms.Button button_ist;
        private System.Windows.Forms.Button button_guncelle;
        private System.Windows.Forms.Button button_temizle;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_kaydet;
        private System.Windows.Forms.Button button_list;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonbekar;
        private System.Windows.Forms.RadioButton radioButtonevli;
    }
}

