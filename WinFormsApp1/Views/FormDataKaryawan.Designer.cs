namespace WinFormsApp1
{
    partial class FormDataKaryawan
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
            dataGridViewABK = new DataGridView();
            textBoxNamaAdd = new TextBox();
            textBoxNoHPAdd = new TextBox();
            textBoxAlamatAdd = new TextBox();
            btnSimpan = new Button();
            btnUpdate = new Button();
            textBoxAlamatUpdate = new TextBox();
            textBoxNoHPUpdate = new TextBox();
            textBoxNamaUpdate = new TextBox();
            NamaAdd = new Label();
            NoHPAdd = new Label();
            AlamatAdd = new Label();
            AlamatUpdate = new Label();
            NoHPUpdate = new Label();
            NamaUpdate = new Label();
            TombolBack = new Button();
            label1 = new Label();
            textBoxidUpdate = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewABK).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewABK
            // 
            dataGridViewABK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewABK.Location = new Point(12, 220);
            dataGridViewABK.Name = "dataGridViewABK";
            dataGridViewABK.RowHeadersWidth = 51;
            dataGridViewABK.Size = new Size(776, 230);
            dataGridViewABK.TabIndex = 0;
            dataGridViewABK.CellContentClick += dataGridViewABK_CellContentClick;
            // 
            // textBoxNamaAdd
            // 
            textBoxNamaAdd.BackColor = Color.White;
            textBoxNamaAdd.Location = new Point(76, 85);
            textBoxNamaAdd.Name = "textBoxNamaAdd";
            textBoxNamaAdd.Size = new Size(133, 27);
            textBoxNamaAdd.TabIndex = 1;
            textBoxNamaAdd.TextChanged += textBoxNama_TextChanged;
            // 
            // textBoxNoHPAdd
            // 
            textBoxNoHPAdd.BackColor = Color.White;
            textBoxNoHPAdd.Location = new Point(76, 128);
            textBoxNoHPAdd.Name = "textBoxNoHPAdd";
            textBoxNoHPAdd.Size = new Size(133, 27);
            textBoxNoHPAdd.TabIndex = 2;
            textBoxNoHPAdd.TextChanged += textBoxNoHP_TextChanged;
            // 
            // textBoxAlamatAdd
            // 
            textBoxAlamatAdd.BackColor = Color.White;
            textBoxAlamatAdd.Location = new Point(76, 173);
            textBoxAlamatAdd.Name = "textBoxAlamatAdd";
            textBoxAlamatAdd.Size = new Size(133, 27);
            textBoxAlamatAdd.TabIndex = 3;
            textBoxAlamatAdd.TextChanged += textBoxAlamat_TextChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.FromArgb(224, 224, 224);
            btnSimpan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSimpan.Location = new Point(215, 85);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(152, 115);
            btnSimpan.TabIndex = 4;
            btnSimpan.Text = "Tambah Data";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.Location = new Point(636, 42);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 157);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update Data";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // textBoxAlamatUpdate
            // 
            textBoxAlamatUpdate.Location = new Point(493, 172);
            textBoxAlamatUpdate.Name = "textBoxAlamatUpdate";
            textBoxAlamatUpdate.Size = new Size(137, 27);
            textBoxAlamatUpdate.TabIndex = 7;
            // 
            // textBoxNoHPUpdate
            // 
            textBoxNoHPUpdate.Location = new Point(493, 127);
            textBoxNoHPUpdate.Name = "textBoxNoHPUpdate";
            textBoxNoHPUpdate.Size = new Size(137, 27);
            textBoxNoHPUpdate.TabIndex = 6;
            // 
            // textBoxNamaUpdate
            // 
            textBoxNamaUpdate.Location = new Point(493, 84);
            textBoxNamaUpdate.Name = "textBoxNamaUpdate";
            textBoxNamaUpdate.Size = new Size(137, 27);
            textBoxNamaUpdate.TabIndex = 5;
            // 
            // NamaAdd
            // 
            NamaAdd.AutoSize = true;
            NamaAdd.Location = new Point(12, 87);
            NamaAdd.Name = "NamaAdd";
            NamaAdd.Size = new Size(52, 20);
            NamaAdd.TabIndex = 9;
            NamaAdd.Text = "Nama:";
            // 
            // NoHPAdd
            // 
            NoHPAdd.AutoSize = true;
            NoHPAdd.Location = new Point(12, 131);
            NoHPAdd.Name = "NoHPAdd";
            NoHPAdd.Size = new Size(55, 20);
            NoHPAdd.TabIndex = 10;
            NoHPAdd.Text = "No HP:";
            // 
            // AlamatAdd
            // 
            AlamatAdd.AutoSize = true;
            AlamatAdd.Location = new Point(12, 176);
            AlamatAdd.Name = "AlamatAdd";
            AlamatAdd.Size = new Size(60, 20);
            AlamatAdd.TabIndex = 11;
            AlamatAdd.Text = "Alamat:";
            // 
            // AlamatUpdate
            // 
            AlamatUpdate.AutoSize = true;
            AlamatUpdate.Location = new Point(430, 176);
            AlamatUpdate.Name = "AlamatUpdate";
            AlamatUpdate.Size = new Size(60, 20);
            AlamatUpdate.TabIndex = 14;
            AlamatUpdate.Text = "Alamat:";
            // 
            // NoHPUpdate
            // 
            NoHPUpdate.AutoSize = true;
            NoHPUpdate.Location = new Point(430, 131);
            NoHPUpdate.Name = "NoHPUpdate";
            NoHPUpdate.Size = new Size(55, 20);
            NoHPUpdate.TabIndex = 13;
            NoHPUpdate.Text = "No HP:";
            // 
            // NamaUpdate
            // 
            NamaUpdate.AutoSize = true;
            NamaUpdate.Location = new Point(430, 87);
            NamaUpdate.Name = "NamaUpdate";
            NamaUpdate.Size = new Size(52, 20);
            NamaUpdate.TabIndex = 12;
            NamaUpdate.Text = "Nama:";
            // 
            // TombolBack
            // 
            TombolBack.Font = new Font("Segoe UI", 9F);
            TombolBack.Location = new Point(695, 473);
            TombolBack.Margin = new Padding(2);
            TombolBack.Name = "TombolBack";
            TombolBack.Size = new Size(93, 31);
            TombolBack.TabIndex = 42;
            TombolBack.Text = "Kembali";
            TombolBack.UseVisualStyleBackColor = true;
            TombolBack.Click += TombolBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(430, 45);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 44;
            label1.Text = "Id:";
            // 
            // textBoxidUpdate
            // 
            textBoxidUpdate.Location = new Point(493, 42);
            textBoxidUpdate.Name = "textBoxidUpdate";
            textBoxidUpdate.Size = new Size(137, 27);
            textBoxidUpdate.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 19F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(61, 45);
            label2.TabIndex = 45;
            label2.Text = "\U0001f986";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(65, 17);
            label3.Name = "label3";
            label3.Size = new Size(266, 45);
            label3.TabIndex = 46;
            label3.Text = "Duck Farm Apps";
            // 
            // FormDataKaryawan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 524);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxidUpdate);
            Controls.Add(TombolBack);
            Controls.Add(AlamatUpdate);
            Controls.Add(NoHPUpdate);
            Controls.Add(NamaUpdate);
            Controls.Add(AlamatAdd);
            Controls.Add(NoHPAdd);
            Controls.Add(NamaAdd);
            Controls.Add(btnUpdate);
            Controls.Add(textBoxAlamatUpdate);
            Controls.Add(textBoxNoHPUpdate);
            Controls.Add(textBoxNamaUpdate);
            Controls.Add(btnSimpan);
            Controls.Add(textBoxAlamatAdd);
            Controls.Add(textBoxNoHPAdd);
            Controls.Add(textBoxNamaAdd);
            Controls.Add(dataGridViewABK);
            Name = "FormDataKaryawan";
            Text = "Form Data ABK";
            Load += FormDataKaryawan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewABK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewABK;
        private TextBox textBoxNamaAdd;
        private TextBox textBoxNoHPAdd;
        private TextBox textBoxAlamatAdd;
        private Button btnSimpan;
        private Button btnUpdate;
        private TextBox textBoxAlamatUpdate;
        private TextBox textBoxNoHPUpdate;
        private TextBox textBoxNamaUpdate;
        private Label NamaAdd;
        private Label NoHPAdd;
        private Label AlamatAdd;
        private Label AlamatUpdate;
        private Label NoHPUpdate;
        private Label NamaUpdate;
        private Button TombolBack;
        private Label label1;
        private TextBox textBoxidUpdate;
        private Label label2;
        private Label label3;
    }
}