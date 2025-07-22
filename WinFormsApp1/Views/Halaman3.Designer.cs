namespace WinFormsApp1
{
    partial class Hitung_FCR
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
            label2 = new Label();
            textBox2 = new TextBox();
            HitungTotalPakan = new Button();
            label5 = new Label();
            TombolBack = new Button();
            label6 = new Label();
            label7 = new Label();
            SalinTotalPakan = new Button();
            label11 = new Label();
            textBox4 = new TextBox();
            label14 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 270);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(247, 60);
            label2.TabIndex = 3;
            label2.Text = "Total Pakan:\r\n\r\n(ketik dengan Kg dalam satuan Ton)";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(294, 270);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(115, 27);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // HitungTotalPakan
            // 
            HitungTotalPakan.Location = new Point(294, 384);
            HitungTotalPakan.Margin = new Padding(2, 2, 2, 2);
            HitungTotalPakan.Name = "HitungTotalPakan";
            HitungTotalPakan.Size = new Size(114, 27);
            HitungTotalPakan.TabIndex = 9;
            HitungTotalPakan.Text = "Hitung";
            HitungTotalPakan.UseVisualStyleBackColor = true;
            HitungTotalPakan.Click += HitungTotalPakan_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 418);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 10;
            label5.Text = "FCR:";
            label5.Click += label5_Click;
            // 
            // TombolBack
            // 
            TombolBack.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TombolBack.Location = new Point(509, 492);
            TombolBack.Margin = new Padding(2, 2, 2, 2);
            TombolBack.Name = "TombolBack";
            TombolBack.Size = new Size(93, 33);
            TombolBack.TabIndex = 11;
            TombolBack.Text = "Kembali";
            TombolBack.TextAlign = ContentAlignment.TopCenter;
            TombolBack.UseVisualStyleBackColor = true;
            TombolBack.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 82F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(186, 4);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(251, 182);
            label6.TabIndex = 12;
            label6.Text = "\U0001f986";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(197, 184);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(231, 41);
            label7.TabIndex = 13;
            label7.Text = "DuckFarmApps";
            // 
            // SalinTotalPakan
            // 
            SalinTotalPakan.Location = new Point(294, 450);
            SalinTotalPakan.Margin = new Padding(2, 2, 2, 2);
            SalinTotalPakan.Name = "SalinTotalPakan";
            SalinTotalPakan.Size = new Size(114, 27);
            SalinTotalPakan.TabIndex = 14;
            SalinTotalPakan.Text = "Salin";
            SalinTotalPakan.UseVisualStyleBackColor = true;
            SalinTotalPakan.Click += button6_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(166, 238);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(290, 20);
            label11.TabIndex = 24;
            label11.Text = "Bagian hitung FCR(Food Conversion Ratio)";
            label11.Click += label11_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(294, 347);
            textBox4.Margin = new Padding(2, 2, 2, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(115, 27);
            textBox4.TabIndex = 31;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(166, 347);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(90, 20);
            label14.TabIndex = 30;
            label14.Text = "Total Bobot:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Red;
            label13.Location = new Point(166, 492);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(229, 20);
            label13.TabIndex = 47;
            label13.Text = "Note: FCR ideal itu antara 1,5-1,8.";
            // 
            // Hitung_FCR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 534);
            Controls.Add(label13);
            Controls.Add(textBox4);
            Controls.Add(label14);
            Controls.Add(label11);
            Controls.Add(SalinTotalPakan);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(TombolBack);
            Controls.Add(label5);
            Controls.Add(HitungTotalPakan);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Hitung_FCR";
            Text = "Hitung FCR";
            Load += Hitung_FCR_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        // Add the missing event handler method for textBox1_TextChanged
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Add your logic here
        }
        // Add the missing event handler method for label1_Click
        private void label1_Click(object sender, EventArgs e)
        {
            // Add your logic here
        }
        // Add the missing event handler method for button3_Click
        private void button3_Click(object sender, EventArgs e)
        {
            // Add your logic here
        }
        //Add the missing event handler method for label5_Click
        private void label5_Click(object sender, EventArgs e)
        {
            // Add your logic here
        }

        #endregion
        private Label label2;
        private TextBox textBox2;
        private Button HitungTotalPakan;
        private Label label5;
        private Button TombolBack;
        private Label label6;
        private Label label7;
        private Button SalinTotalPakan;
        private Label label11;
        private TextBox textBox4;
        private Label label14;
        private Label label13;
    }
}