using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SQLite;

namespace Percobaan2.View
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        private void lvwAkun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InisialisasiListView()
        {
            lvwAkun.View = System.Windows.Forms.View.Details;
            lvwAkun.FullRowSelect = true;
            lvwAkun.GridLines = true;
            lvwAkun.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwAkun.Columns.Add("Username", 91, HorizontalAlignment.Center);
            lvwAkun.Columns.Add("Nama", 170, HorizontalAlignment.Left);
            lvwAkun.Columns.Add("email", 80, HorizontalAlignment.Center);

            lvwTransaksi.View = System.Windows.Forms.View.Details;
            lvwTransaksi.FullRowSelect = true;
            lvwTransaksi.GridLines = true;
            lvwTransaksi.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Username", 91, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Tanggal", 170, HorizontalAlignment.Left);
            lvwTransaksi.Columns.Add("Waktu", 80, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Harga", 80, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Waktu Terpakai", 80, HorizontalAlignment.Center);
            lvwTransaksi.Columns.Add("Staff", 80, HorizontalAlignment.Center);


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lstTransaksi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvwTransaksi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
