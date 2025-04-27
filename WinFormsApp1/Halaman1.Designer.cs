namespace WinFormsApp1
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
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            buttonSQLConnect = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 196);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(568, 40);
            label1.TabIndex = 0;
            label1.Text = "Selamat datang di DuckFarmApps";
            label1.TextAlign = ContentAlignment.TopRight;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 240);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(464, 48);
            label2.TabIndex = 1;
            label2.Text = "Anda sekarang di Halaman Utama.\r\nPilih halaman dengan menekan tombol dibawah!";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(235, 295);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(145, 50);
            button1.TabIndex = 2;
            button1.Text = "HitungFCR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(51, 295);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(179, 50);
            button2.TabIndex = 4;
            button2.Text = "Hitung Bobot";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(180, 17);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(460, 81);
            label7.TabIndex = 42;
            label7.Text = "DuckFarmApps";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 82F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(-6, 7);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(251, 182);
            label6.TabIndex = 41;
            label6.Text = "\U0001f986";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(203, 94);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(194, 24);
            label3.TabIndex = 43;
            label3.Text = "Salam Wek Wek! \U0001f986";
            // 
            // buttonSQLConnect
            // 
            buttonSQLConnect.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSQLConnect.Location = new Point(435, 132);
            buttonSQLConnect.Margin = new Padding(2);
            buttonSQLConnect.Name = "buttonSQLConnect";
            buttonSQLConnect.Size = new Size(167, 50);
            buttonSQLConnect.TabIndex = 44;
            buttonSQLConnect.Text = "SQLConnect";
            buttonSQLConnect.UseVisualStyleBackColor = true;
            buttonSQLConnect.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(384, 295);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(223, 50);
            button4.TabIndex = 45;
            button4.Text = "Data Karyawan";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(button4);
            Controls.Add(buttonSQLConnect);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label7;
        private Label label6;
        private Label label3;
        private Button buttonSQLConnect;
        private Button button4;
    }
}
