using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Percobaan2.Model.Entity;
using Percobaan2.Controller;



namespace Percobaan2.View
{
    public partial class MainMenu : Form
    {

        private List<Pelanggan> ListOfPelanggan = new List<Pelanggan>();

        private PelangganController controllerPelanggan;
        private List<KomputerWarnet> listOfKomputer = new List<KomputerWarnet>();
        private KomputerWarnetController controllerKomputer;


        public MainMenu()
        {
            InitializeComponent();

            controllerPelanggan = new PelangganController();
            controllerKomputer = new KomputerWarnetController();
            InisialisasiListView();
            LoadDataKomputer();
            LoadDataPelanggan();

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

            lvwKomputer.View = System.Windows.Forms.View.Details;
            lvwKomputer.FullRowSelect = true;
            lvwKomputer.GridLines = true;

            lvwKomputer.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwKomputer.Columns.Add("ID Komputer", 91, HorizontalAlignment.Center);
            lvwKomputer.Columns.Add("Ketersediaan", 150, HorizontalAlignment.Center);
            lvwKomputer.Columns.Add("Jenis Komputer", 150, HorizontalAlignment.Left);

        }

        private void LoadDataKomputer()
        {
            lvwKomputer.Items.Clear();
            listOfKomputer = controllerKomputer.ReadAll();

            foreach (var komputer in listOfKomputer)
            {
                var noUrut = lvwKomputer.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(komputer.ID_Komputer.ToString());
                item.SubItems.Add(komputer.Ketersediaan.ToString());
                item.SubItems.Add(komputer.Jenis_Komputer);

                lvwKomputer.Items.Add(item);
            }
        }

        private void LoadDataPelanggan()
        {
            // kosongkan listview
            lvwAkun.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            ListOfPelanggan = controllerPelanggan.ReadAll();

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
        private void btnCariAkun_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCariAKun(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void lvwTransaksi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            firstCustomControl1.BringToFront();
        }




    }


}

