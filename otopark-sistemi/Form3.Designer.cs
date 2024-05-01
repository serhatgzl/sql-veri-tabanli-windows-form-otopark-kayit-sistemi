namespace SQL_Odev_4
{
    partial class Form3
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Temizle = new Button();
            dgwAbonelik = new DataGridView();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgwAbonelik).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Abonelik ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Abonelik Tipi";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(133, 72);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 27);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 4;
            label3.Text = "Süre";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(133, 105);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 27);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 108);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 6;
            label4.Text = "Abone Baş. Tah.";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(133, 138);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(180, 27);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 141);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 8;
            label5.Text = "Abone Bit. Tah.";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(133, 171);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(180, 27);
            textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 174);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 10;
            label6.Text = "Ücret";
            // 
            // button1
            // 
            button1.Location = new Point(12, 200);
            button1.Name = "button1";
            button1.Size = new Size(145, 105);
            button1.TabIndex = 12;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnEkle_Click;
            // 
            // button2
            // 
            button2.Location = new Point(168, 200);
            button2.Name = "button2";
            button2.Size = new Size(145, 105);
            button2.TabIndex = 13;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnGuncelle_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 311);
            button3.Name = "button3";
            button3.Size = new Size(145, 105);
            button3.TabIndex = 14;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnSil_Click;
            // 
            // Temizle
            // 
            Temizle.Location = new Point(168, 311);
            Temizle.Name = "Temizle";
            Temizle.Size = new Size(145, 105);
            Temizle.TabIndex = 15;
            Temizle.Text = "Temizle";
            Temizle.UseVisualStyleBackColor = true;
            Temizle.Click += btnTemizle_Click;
            // 
            // dgwAbonelik
            // 
            dgwAbonelik.AllowUserToAddRows = false;
            dgwAbonelik.AllowUserToDeleteRows = false;
            dgwAbonelik.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwAbonelik.Location = new Point(319, 12);
            dgwAbonelik.Name = "dgwAbonelik";
            dgwAbonelik.ReadOnly = true;
            dgwAbonelik.RowHeadersWidth = 51;
            dgwAbonelik.RowTemplate.Height = 29;
            dgwAbonelik.Size = new Size(686, 404);
            dgwAbonelik.TabIndex = 17;
            dgwAbonelik.CellEnter += dgwAbonelik_CellEnter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(133, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 28);
            comboBox1.TabIndex = 18;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1021, 428);
            Controls.Add(comboBox1);
            Controls.Add(dgwAbonelik);
            Controls.Add(Temizle);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Abonelik Sistemi";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgwAbonelik).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button Temizle;
        private DataGridView dgwAbonelik;
        private ComboBox comboBox1;
    }
}