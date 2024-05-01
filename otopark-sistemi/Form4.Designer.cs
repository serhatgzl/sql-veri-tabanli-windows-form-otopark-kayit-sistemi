namespace SQL_Odev_4
{
    partial class Form4
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
            comboBox1 = new ComboBox();
            dgwHizmet = new DataGridView();
            Temizle = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgwHizmet).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(131, 42);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 28);
            comboBox1.TabIndex = 35;
            // 
            // dgwHizmet
            // 
            dgwHizmet.AllowUserToAddRows = false;
            dgwHizmet.AllowUserToDeleteRows = false;
            dgwHizmet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwHizmet.Location = new Point(317, 12);
            dgwHizmet.Name = "dgwHizmet";
            dgwHizmet.ReadOnly = true;
            dgwHizmet.RowHeadersWidth = 51;
            dgwHizmet.RowTemplate.Height = 29;
            dgwHizmet.Size = new Size(686, 408);
            dgwHizmet.TabIndex = 34;
            dgwHizmet.CellEnter += dgwMusteri_CellEnter;
            // 
            // Temizle
            // 
            Temizle.Location = new Point(166, 315);
            Temizle.Name = "Temizle";
            Temizle.Size = new Size(145, 105);
            Temizle.TabIndex = 33;
            Temizle.Text = "Temizle";
            Temizle.UseVisualStyleBackColor = true;
            Temizle.Click += btnTemizle_Click;
            // 
            // button3
            // 
            button3.Location = new Point(10, 315);
            button3.Name = "button3";
            button3.Size = new Size(145, 105);
            button3.TabIndex = 32;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnSil_Click;
            // 
            // button2
            // 
            button2.Location = new Point(166, 208);
            button2.Name = "button2";
            button2.Size = new Size(145, 105);
            button2.TabIndex = 31;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnGuncelle_Click;
            // 
            // button1
            // 
            button1.Location = new Point(10, 208);
            button1.Name = "button1";
            button1.Size = new Size(145, 105);
            button1.TabIndex = 30;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnEkle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 174);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 28;
            label6.Text = "Abonelik Tipi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 141);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 26;
            label5.Text = "Çıkış Saati";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(131, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 27);
            textBox3.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 108);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 24;
            label4.Text = "Giriş Saati";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 27);
            textBox2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 75);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 22;
            label3.Text = "Plaka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 42);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 21;
            label2.Text = "Müşteri İsimi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 27);
            textBox1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 19;
            label1.Text = "Sıra Numara";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(131, 75);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(180, 28);
            comboBox2.TabIndex = 36;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(131, 174);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(180, 28);
            comboBox3.TabIndex = 37;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1018, 425);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dgwHizmet);
            Controls.Add(Temizle);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgwHizmet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private DataGridView dgwHizmet;
        private Button Temizle;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label6;
        private Label label5;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}