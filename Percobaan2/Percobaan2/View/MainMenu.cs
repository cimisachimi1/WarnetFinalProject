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
using Percobaan2.Model.Entity;
using Percobaan2.Controller;

namespace Percobaan2.View
{
    public partial class MainMenu : Form
    {

        private List<Pelanggan> ListOfPelanggan = new List<Pelanggan>();

        private PelangganController controller;


        public MainMenu()
        {
            InitializeComponent();

            controller = new PelangganController();

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
            lvwAkun.Columns.Add("No.", 91, HorizontalAlignment.Center);
            lvwAkun.Columns.Add("ID_Pelanggan", 91, HorizontalAlignment.Center);
            lvwAkun.Columns.Add("NamaPelanggan", 170, HorizontalAlignment.Left);
            lvwAkun.Columns.Add("email", 80, HorizontalAlignment.Center);
            lvwAkun.Columns.Add("NomerHp", 91, HorizontalAlignment.Center);

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
            // kosongkan listview
            lvwAkun.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            ListOfPelanggan = controller.ReadAll();

            // ekstrak objek mhs dari collection
            foreach (var mhs in ListOfPelanggan)
            {
                var noUrut = lvwAkun.Items.Count + 1;


                var item = new ListViewItem(noUrut.ToString());

                item.SubItems.Add(mhs.NamaPelanggan);
                item.SubItems.Add(mhs.Email);
                item.SubItems.Add(mhs.NomerHp);
                // tampilkan data mhs ke listview
                lvwAkun.Items.Add(item);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // kosongkan listview
            lvwAkun.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            ListOfPelanggan = controller.ReadAll();

            // ekstrak objek mhs dari collection
            foreach (var mhs in ListOfPelanggan)
            {
                var noUrut = lvwAkun.Items.Count + 1;


                var item = new ListViewItem(noUrut.ToString());

                item.SubItems.Add(mhs.NamaPelanggan);
                item.SubItems.Add(mhs.Email);
                item.SubItems.Add(mhs.NomerHp);
                // tampilkan data mhs ke listview
                lvwAkun.Items.Add(item);
            }
        }
    }


}

