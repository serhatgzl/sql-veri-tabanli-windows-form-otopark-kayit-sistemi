namespace SQL_Odev_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtAdSoyad = new TextBox();
            txtYas = new TextBox();
            txtTelefon = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            dgwMusteri = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwMusteri).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 0;
            label1.Text = "Müşteri ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 60);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 110);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 2;
            label3.Text = "Yaş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 160);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefon";
            // 
            // txtId
            // 
            txtId.Location = new Point(101, 10);
            txtId.Name = "txtId";
            txtId.Size = new Size(190, 27);
            txtId.TabIndex = 5;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(101, 60);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(190, 27);
            txtAdSoyad.TabIndex = 6;
            // 
            // txtYas
            // 
            txtYas.Location = new Point(101, 110);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(190, 27);
            txtYas.TabIndex = 7;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(101, 160);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(190, 27);
            txtTelefon.TabIndex = 8;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(12, 193);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(132, 84);
            btnEkle.TabIndex = 10;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(150, 193);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(141, 84);
            btnGuncelle.TabIndex = 11;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(12, 283);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(132, 84);
            btnSil.TabIndex = 12;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(150, 283);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(141, 84);
            btnTemizle.TabIndex = 13;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // dgwMusteri
            // 
            dgwMusteri.AllowUserToAddRows = false;
            dgwMusteri.AllowUserToDeleteRows = false;
            dgwMusteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMusteri.Location = new Point(297, 10);
            dgwMusteri.Name = "dgwMusteri";
            dgwMusteri.ReadOnly = true;
            dgwMusteri.RowHeadersWidth = 51;
            dgwMusteri.RowTemplate.Height = 29;
            dgwMusteri.Size = new Size(681, 357);
            dgwMusteri.TabIndex = 14;
            dgwMusteri.CellMouseEnter += dgwMusteri_CellEnter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(989, 377);
            Controls.Add(dgwMusteri);
            Controls.Add(btnTemizle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtTelefon);
            Controls.Add(txtYas);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Müşter Kayıt";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwMusteri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtAdSoyad;
        private TextBox txtYas;
        private TextBox txtTelefon;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnTemizle;
        private DataGridView dgwMusteri;
    }
}