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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 245);
            label1.Name = "label1";
            label1.Size = new Size(660, 46);
            label1.TabIndex = 0;
            label1.Text = "Selamat datang di DuckFarmApps";
            label1.TextAlign = ContentAlignment.TopRight;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(115, 300);
            label2.Name = "label2";
            label2.Size = new Size(571, 58);
            label2.TabIndex = 1;
            label2.Text = "Anda sekarang di Halaman Utama.\r\nPilih halaman dengan menekan tombol dibawah!";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(425, 372);
            button1.Name = "button1";
            button1.Size = new Size(181, 63);
            button1.TabIndex = 2;
            button1.Text = "HitungFCR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(195, 372);
            button2.Name = "button2";
            button2.Size = new Size(224, 63);
            button2.TabIndex = 4;
            button2.Text = "Hitung Bobot";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(225, 21);
            label7.Name = "label7";
            label7.Size = new Size(554, 96);
            label7.TabIndex = 42;
            label7.Text = "DuckFarmApps";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 82F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(-8, 9);
            label6.Name = "label6";
            label6.Size = new Size(300, 219);
            label6.TabIndex = 41;
            label6.Text = "\U0001f986";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(254, 117);
            label3.Name = "label3";
            label3.Size = new Size(234, 29);
            label3.TabIndex = 43;
            label3.Text = "Salam Wek Wek! \U0001f986";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
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
    }
}
