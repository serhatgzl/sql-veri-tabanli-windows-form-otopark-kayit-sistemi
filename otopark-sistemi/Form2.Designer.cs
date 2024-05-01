namespace SQL_Odev_4
{
    partial class Form2
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
            dgwArac = new DataGridView();
            btnTemizle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnEkle = new Button();
            txtModel = new TextBox();
            txtRenk = new TextBox();
            txtPlaka = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtYil = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwArac).BeginInit();
            SuspendLayout();
            // 
            // dgwArac
            // 
            dgwArac.AllowUserToAddRows = false;
            dgwArac.AllowUserToDeleteRows = false;
            dgwArac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwArac.Location = new Point(304, 12);
            dgwArac.Name = "dgwArac";
            dgwArac.ReadOnly = true;
            dgwArac.RowHeadersWidth = 51;
            dgwArac.RowTemplate.Height = 29;
            dgwArac.Size = new Size(681, 412);
            dgwArac.TabIndex = 27;
            dgwArac.CellEnter += dgwMusteri_CellEnter;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(147, 340);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(141, 84);
            btnTemizle.TabIndex = 26;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(9, 340);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(132, 84);
            btnSil.TabIndex = 25;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(147, 250);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(141, 84);
            btnGuncelle.TabIndex = 24;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(9, 250);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(132, 84);
            btnEkle.TabIndex = 23;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(108, 162);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(190, 27);
            txtModel.TabIndex = 22;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(108, 112);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(190, 27);
            txtRenk.TabIndex = 21;
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(108, 62);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(190, 27);
            txtPlaka.TabIndex = 20;
            // 
            // txtId
            // 
            txtId.Location = new Point(108, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(190, 27);
            txtId.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 162);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 18;
            label4.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 17;
            label3.Text = "Renk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 16;
            label2.Text = "Araç Plaka";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 11);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 15;
            label1.Text = "Araç ID";
            // 
            // txtYil
            // 
            txtYil.Location = new Point(108, 212);
            txtYil.Name = "txtYil";
            txtYil.Size = new Size(190, 27);
            txtYil.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 212);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 28;
            label5.Text = "Yıl";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(996, 435);
            Controls.Add(txtYil);
            Controls.Add(label5);
            Controls.Add(dgwArac);
            Controls.Add(btnTemizle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtModel);
            Controls.Add(txtRenk);
            Controls.Add(txtPlaka);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Araç Kayıt";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgwArac).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwArac;
        private Button btnTemizle;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEkle;
        private TextBox txtModel;
        private TextBox txtRenk;
        private TextBox txtPlaka;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtYil;
        private Label label5;
    }
}