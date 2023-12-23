namespace Percobaan2.View
{
    partial class MainMenu
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
            tabControl1 = new TabControl();
            tabPage5 = new TabPage();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            tabPage6 = new TabPage();
            lvwAkun = new ListView();
            comboBox1 = new ComboBox();
            btnCariAkun = new Button();
            textBox2 = new TextBox();
            tabPage7 = new TabPage();
            btnCariTransaksi = new Button();
            txtCariTransaksi = new TextBox();
            cmbCariTransaksi = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            lvwTransaksi = new ListView();
            tabPage1 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage5.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(1, 44);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1106, 559);
            tabControl1.TabIndex = 2;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(groupBox1);
            tabPage5.Location = new Point(4, 26);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1098, 529);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Komputer";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(122, 170);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "PC-1";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(110, 46);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(lvwAkun);
            tabPage6.Controls.Add(comboBox1);
            tabPage6.Controls.Add(btnCariAkun);
            tabPage6.Controls.Add(textBox2);
            tabPage6.Location = new Point(4, 26);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1098, 529);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Akun";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // lvwAkun
            // 
            lvwAkun.Location = new Point(194, 6);
            lvwAkun.Name = "lvwAkun";
            lvwAkun.Size = new Size(590, 416);
            lvwAkun.TabIndex = 13;
            lvwAkun.UseCompatibleStateImageBehavior = false;
            lvwAkun.SelectedIndexChanged += lvwAkun_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "username", "nama", "status" });
            comboBox1.Location = new Point(7, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 25);
            comboBox1.TabIndex = 11;
            // 
            // btnCariAkun
            // 
            btnCariAkun.Location = new Point(130, 37);
            btnCariAkun.Margin = new Padding(4, 3, 4, 3);
            btnCariAkun.Name = "btnCariAkun";
            btnCariAkun.Size = new Size(57, 27);
            btnCariAkun.TabIndex = 10;
            btnCariAkun.Text = "Cari";
            btnCariAkun.UseVisualStyleBackColor = true;
            btnCariAkun.Click += button1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(7, 37);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(115, 25);
            textBox2.TabIndex = 8;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(btnCariTransaksi);
            tabPage7.Controls.Add(txtCariTransaksi);
            tabPage7.Controls.Add(cmbCariTransaksi);
            tabPage7.Controls.Add(label2);
            tabPage7.Controls.Add(label1);
            tabPage7.Controls.Add(dateTimePicker2);
            tabPage7.Controls.Add(dateTimePicker1);
            tabPage7.Controls.Add(lvwTransaksi);
            tabPage7.Location = new Point(4, 26);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1098, 529);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Transaksi";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnCariTransaksi
            // 
            btnCariTransaksi.Location = new Point(911, 13);
            btnCariTransaksi.Name = "btnCariTransaksi";
            btnCariTransaksi.Size = new Size(75, 23);
            btnCariTransaksi.TabIndex = 20;
            btnCariTransaksi.Text = "CARI";
            btnCariTransaksi.UseVisualStyleBackColor = true;
            // 
            // txtCariTransaksi
            // 
            txtCariTransaksi.Location = new Point(774, 11);
            txtCariTransaksi.Name = "txtCariTransaksi";
            txtCariTransaksi.Size = new Size(121, 25);
            txtCariTransaksi.TabIndex = 19;
            // 
            // cmbCariTransaksi
            // 
            cmbCariTransaksi.FormattingEnabled = true;
            cmbCariTransaksi.Items.AddRange(new object[] { "Username", "Operator" });
            cmbCariTransaksi.Location = new Point(638, 11);
            cmbCariTransaksi.Name = "cmbCariTransaksi";
            cmbCariTransaksi.Size = new Size(121, 25);
            cmbCariTransaksi.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 13);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 17;
            label2.Text = "Sampai";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(34, 19);
            label1.TabIndex = 17;
            label1.Text = "Dari";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(359, 10);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(241, 25);
            dateTimePicker2.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(53, 11);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 25);
            dateTimePicker1.TabIndex = 15;
            // 
            // lvwTransaksi
            // 
            lvwTransaksi.Location = new Point(7, 42);
            lvwTransaksi.Name = "lvwTransaksi";
            lvwTransaksi.Size = new Size(1000, 481);
            lvwTransaksi.TabIndex = 14;
            lvwTransaksi.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1098, 529);
            tabPage1.TabIndex = 7;
            tabPage1.Text = "Layanan Tambahan";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 615);
            Controls.Add(tabControl1);
            Name = "MainMenu";
            Text = "MainMenu";
            tabControl1.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage5;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private TabPage tabPage6;
        private ListView lvwAkun;
        private ComboBox comboBox1;
        private Button btnCariAkun;
        private TextBox textBox2;
        private TabPage tabPage7;
        private TabPage tabPage1;
        private ListView lvwTransaksi;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbCariTransaksi;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Button btnCariTransaksi;
        private TextBox txtCariTransaksi;
    }
}