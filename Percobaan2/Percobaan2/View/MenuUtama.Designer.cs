namespace Percobaan2.View
{
    partial class MenuUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUtama));
            btnTransaksi = new Button();
            btnTambahan = new Button();
            btnAkun = new Button();
            btnKomputer = new Button();
            isiKomputer1 = new IsiKomputer();
            isiAkun1 = new IsiAkun();
            SuspendLayout();
            // 
            // btnTransaksi
            // 
            btnTransaksi.BackColor = SystemColors.WindowFrame;
            btnTransaksi.FlatAppearance.BorderSize = 0;
            btnTransaksi.FlatStyle = FlatStyle.Flat;
            btnTransaksi.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTransaksi.ForeColor = Color.White;
            btnTransaksi.Image = (Image)resources.GetObject("btnTransaksi.Image");
            btnTransaksi.ImageAlign = ContentAlignment.MiddleLeft;
            btnTransaksi.Location = new Point(723, 34);
            btnTransaksi.Margin = new Padding(4, 3, 4, 3);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(144, 50);
            btnTransaksi.TabIndex = 10;
            btnTransaksi.Text = "Transaksi";
            btnTransaksi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTransaksi.UseVisualStyleBackColor = false;
            // 
            // btnTambahan
            // 
            btnTambahan.BackColor = SystemColors.WindowFrame;
            btnTambahan.FlatAppearance.BorderSize = 0;
            btnTambahan.FlatStyle = FlatStyle.Flat;
            btnTambahan.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTambahan.ForeColor = Color.White;
            btnTambahan.Image = (Image)resources.GetObject("btnTambahan.Image");
            btnTambahan.ImageAlign = ContentAlignment.MiddleLeft;
            btnTambahan.Location = new Point(561, 34);
            btnTambahan.Margin = new Padding(4, 3, 4, 3);
            btnTambahan.Name = "btnTambahan";
            btnTambahan.Size = new Size(154, 50);
            btnTambahan.TabIndex = 11;
            btnTambahan.Text = "Layanan Tambahan";
            btnTambahan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTambahan.UseVisualStyleBackColor = false;
            // 
            // btnAkun
            // 
            btnAkun.BackColor = SystemColors.WindowFrame;
            btnAkun.FlatAppearance.BorderSize = 0;
            btnAkun.FlatStyle = FlatStyle.Flat;
            btnAkun.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAkun.ForeColor = Color.White;
            btnAkun.Image = (Image)resources.GetObject("btnAkun.Image");
            btnAkun.ImageAlign = ContentAlignment.MiddleLeft;
            btnAkun.Location = new Point(409, 34);
            btnAkun.Margin = new Padding(4, 3, 4, 3);
            btnAkun.Name = "btnAkun";
            btnAkun.Size = new Size(144, 50);
            btnAkun.TabIndex = 12;
            btnAkun.Text = "Akun";
            btnAkun.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAkun.UseVisualStyleBackColor = false;
            btnAkun.Click += btnAkun_Click;
            // 
            // btnKomputer
            // 
            btnKomputer.BackColor = SystemColors.WindowFrame;
            btnKomputer.FlatAppearance.BorderSize = 0;
            btnKomputer.FlatStyle = FlatStyle.Flat;
            btnKomputer.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKomputer.ForeColor = Color.White;
            btnKomputer.Image = (Image)resources.GetObject("btnKomputer.Image");
            btnKomputer.ImageAlign = ContentAlignment.MiddleLeft;
            btnKomputer.Location = new Point(257, 34);
            btnKomputer.Margin = new Padding(4, 3, 4, 3);
            btnKomputer.Name = "btnKomputer";
            btnKomputer.Size = new Size(144, 50);
            btnKomputer.TabIndex = 13;
            btnKomputer.Text = "Komputer";
            btnKomputer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKomputer.UseVisualStyleBackColor = false;
            btnKomputer.Click += btnKomputer_Click;
            // 
            // isiKomputer1
            // 
            isiKomputer1.Location = new Point(257, 90);
            isiKomputer1.Name = "isiKomputer1";
            isiKomputer1.Size = new Size(745, 462);
            isiKomputer1.TabIndex = 14;
            // 
            // isiAkun1
            // 
            isiAkun1.Location = new Point(257, 90);
            isiAkun1.Name = "isiAkun1";
            isiAkun1.Size = new Size(745, 462);
            isiAkun1.TabIndex = 15;
            // 
            // MenuUtama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 560);
            Controls.Add(isiKomputer1);
            Controls.Add(isiAkun1);
            Controls.Add(btnTransaksi);
            Controls.Add(btnTambahan);
            Controls.Add(btnAkun);
            Controls.Add(btnKomputer);
            Name = "MenuUtama";
            Text = "MenuUtama";
            ResumeLayout(false);
        }

        #endregion

        private Button btnTransaksi;
        private Button btnTambahan;
        private Button btnAkun;
        private Button btnKomputer;
        private IsiKomputer isiKomputer1;
        private IsiAkun isiAkun1;
    }
}