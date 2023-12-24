namespace Percobaan2.View
{
    partial class IsiTransaksi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            dateSampai = new DateTimePicker();
            dateDari = new DateTimePicker();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(14, 59);
            listView1.Name = "listView1";
            listView1.Size = new Size(767, 433);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // dateSampai
            // 
            dateSampai.Location = new Point(321, 30);
            dateSampai.Name = "dateSampai";
            dateSampai.Size = new Size(200, 23);
            dateSampai.TabIndex = 1;
            // 
            // dateDari
            // 
            dateDari.Location = new Point(47, 30);
            dateDari.Name = "dateDari";
            dateDari.Size = new Size(200, 23);
            dateDari.TabIndex = 1;
            dateDari.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 36);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 2;
            label1.Text = "dari";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(545, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 36);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "sampai";
            // 
            // IsiTransaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateDari);
            Controls.Add(dateSampai);
            Controls.Add(listView1);
            Name = "IsiTransaksi";
            Size = new Size(795, 507);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private DateTimePicker dateSampai;
        private DateTimePicker dateDari;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
    }
}
