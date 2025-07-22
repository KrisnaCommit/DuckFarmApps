namespace WinFormsApp1
{
    partial class HitungBobot
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
            label10 = new Label();
            TombolKurangiKarung = new Button();
            TombolTambahKarung = new Button();
            SalinBobotPerKarung = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            TombolBack = new Button();
            label13 = new Label();
            button2 = new Button();
            label9 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 22);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(390, 40);
            label10.TabIndex = 36;
            label10.Text = "Gunakan ini jika ingin menghitung langsung \r\nrata-rata bobot sambil memanen. (Tulis dalam satuan kg)";
            label10.Click += label10_Click;
            // 
            // TombolKurangiKarung
            // 
            TombolKurangiKarung.Location = new Point(26, 138);
            TombolKurangiKarung.Margin = new Padding(2);
            TombolKurangiKarung.Name = "TombolKurangiKarung";
            TombolKurangiKarung.Size = new Size(114, 27);
            TombolKurangiKarung.TabIndex = 35;
            TombolKurangiKarung.Text = "Kurangi Karung";
            TombolKurangiKarung.UseVisualStyleBackColor = true;
            TombolKurangiKarung.Click += TombolKurangiKarung_Click;
            // 
            // TombolTambahKarung
            // 
            TombolTambahKarung.Location = new Point(270, 99);
            TombolTambahKarung.Margin = new Padding(2);
            TombolTambahKarung.Name = "TombolTambahKarung";
            TombolTambahKarung.Size = new Size(32, 27);
            TombolTambahKarung.TabIndex = 34;
            TombolTambahKarung.Text = "+";
            TombolTambahKarung.UseVisualStyleBackColor = true;
            TombolTambahKarung.Click += TombolTambahKarung_Click;
            // 
            // SalinBobotPerKarung
            // 
            SalinBobotPerKarung.Location = new Point(143, 224);
            SalinBobotPerKarung.Margin = new Padding(2);
            SalinBobotPerKarung.Name = "SalinBobotPerKarung";
            SalinBobotPerKarung.Size = new Size(114, 27);
            SalinBobotPerKarung.TabIndex = 33;
            SalinBobotPerKarung.Text = "Salin";
            SalinBobotPerKarung.UseVisualStyleBackColor = true;
            SalinBobotPerKarung.Click += SalinBobotPerKarung_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 196);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 32;
            label4.Text = "Total Bobot:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 70);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 30;
            label3.Text = "Karung ke:";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 102);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 29;
            label1.Text = "Berat Per Karung:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 101);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 27);
            textBox1.TabIndex = 28;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(356, 210);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(231, 41);
            label7.TabIndex = 40;
            label7.Text = "DuckFarmApps";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 50F);
            label6.Location = new Point(378, 89);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(154, 112);
            label6.TabIndex = 39;
            label6.Text = "\U0001f986";
            // 
            // TombolBack
            // 
            TombolBack.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TombolBack.Location = new Point(538, 474);
            TombolBack.Margin = new Padding(2);
            TombolBack.Name = "TombolBack";
            TombolBack.Size = new Size(93, 33);
            TombolBack.TabIndex = 41;
            TombolBack.Text = "Kembali";
            TombolBack.TextAlign = ContentAlignment.TopCenter;
            TombolBack.UseVisualStyleBackColor = true;
            TombolBack.Click += TombolBack_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(18, 458);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(271, 40);
            label13.TabIndex = 46;
            label13.Text = "Note: Bagian ini tidak bisa menghitung \r\nrata-rata.";
            // 
            // button2
            // 
            button2.Location = new Point(143, 424);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(114, 27);
            button2.TabIndex = 45;
            button2.Text = "Salin";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 343);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(259, 40);
            label9.TabIndex = 44;
            label9.Text = "Gunakan ini jika berat per karung\r\n(yang dipanen) sudah ditulis di kertas.";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 391);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(121, 27);
            textBox3.TabIndex = 43;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 391);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 42;
            label8.Text = "Total Bobot:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 265);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(327, 80);
            label2.TabIndex = 47;
            label2.Text = "Ini merupakan proyek eksperimental yang tidak \r\ndidanai oleh siapapun. Dibuat sendiri dan \r\nsaya sangat menghargai apabila ada yang \r\nmendownload dengan menyertai kredit sumber.";
            label2.Click += label2_Click;
            // 
            // HitungBobot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 516);
            Controls.Add(label2);
            Controls.Add(label13);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(textBox3);
            Controls.Add(label8);
            Controls.Add(TombolBack);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label10);
            Controls.Add(TombolKurangiKarung);
            Controls.Add(TombolTambahKarung);
            Controls.Add(SalinBobotPerKarung);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(2);
            Name = "HitungBobot";
            Text = "Hitung Bobot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label10;
        private Button TombolKurangiKarung;
        private Button TombolTambahKarung;
        private Button SalinBobotPerKarung;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Button TombolBack;
        private Label label13;
        private Button button2;
        private Label label9;
        private TextBox textBox3;
        private Label label8;
        private Label label2;
        private Button button3;
    }
}