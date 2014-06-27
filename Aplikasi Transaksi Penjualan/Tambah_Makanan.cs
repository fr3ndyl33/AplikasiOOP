﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;
using System.Globalization;

namespace Aplikasi_Transaksi_Penjualan
{
    public partial class Tambah_Makanan : Form
    {
        OleDbConnection database;
        Menu_Makanan mm = new Menu_Makanan();
        public string idmakanan { set; get; }
        public string namamakanan { set; get; }
        public int hargamakanan { set; get; }
        public int satuanmakanan {set; get; }
        public DateTime tanggal { set; get; }
        public string keterangan {set; get; }

        public Tambah_Makanan()
        {
            InitializeComponent();
            //initiate DB connection
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C://TP.mdb";
            try
            {
                database = new OleDbConnection(connectionString);
                database.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }

        public void savemakanan(string idmakanan, string namamakanan, int hargamakanan, DateTime tanggal, string keterangan)
        {
            string queryInsertUser = "INSERT INTO tb_menu([kode_menu],[nama_menu],[harga],[tanggal],[keterangan]) VALUES('" + idmakanan + "','" + namamakanan + "','" + int.Parse(hargamakanan.ToString()) + "','"+ tanggal +"','" + keterangan + "')";
            OleDbCommand SQLInsert = new OleDbCommand(queryInsertUser, database);
            int result = SQLInsert.ExecuteNonQuery();
            
            if (result == 1)
                MessageBox.Show("Berhasil Disimpan");
            else
                MessageBox.Show("Gagal Disimpan");
             
        }
        private void Tambah_Makanan_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null && textBox3.Text != null && textBox6.Text != null)
            {
                idmakanan = textBox1.Text;
                namamakanan = textBox2.Text;
                hargamakanan = int.Parse(textBox3.Text);
                keterangan = textBox6.Text;
                tanggal = dateTimePicker1.Value;
                savemakanan(idmakanan,namamakanan,hargamakanan,tanggal,keterangan);
            }
            mm.Show();
            Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
            Menu_Makanan mm = new Menu_Makanan();
            mm.Show();
        }
    }
}
