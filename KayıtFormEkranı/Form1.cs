using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayıtFormEkranı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UyeOl()
        {
            string adi, soyadi, email, sifre, adres, sehir, ilgialani, uzmanlik;
            bool cinsiyet;
            DateTime dtarih;

            adi = txt_Adi.Text.ToString();
            soyadi = txt_soyad.Text.ToString();
            email = txt_Email.Text.ToString();
            sifre = txt_Sifre.Text.ToString();

            if (rdbtn_Bay.Checked == true)
            {                
                cinsiyet = true;               
            }
            else
            {
                cinsiyet = false;
            }

            dtarih = dtp_DogumT.Value;
            adres = txt_Adres.Text.ToString();
            sehir = cb_Sehir.SelectedItem.ToString();

            ilgialani = "";
            for (int i = 0; i < clb_Ilgi.CheckedItems.Count; i++)
            {
                ilgialani += clb_Ilgi.CheckedItems[i].ToString() + ",";
            }

            uzmanlik = lb_Uzmanlik.SelectedItem.ToString();

            DataTable dt = new DataTable();
            dt.Columns.Add("Adı");
            dt.Columns.Add("Soyadı");
            dt.Columns.Add("E-Mail");
            dt.Columns.Add("Şifre");
            dt.Columns.Add("Cinsiyet");
            dt.Columns.Add("Tarih");
            dt.Columns.Add("Adres");
            dt.Columns.Add("Şehir");
            dt.Columns.Add("İlgi Alanı");
            dt.Columns.Add("Uzmanlık");

            DataRow drow = dt.NewRow();
            drow["Adı"] = adi;
            drow["Soyadı"] = soyadi;
            drow["E-Mail"] = email;
            drow["Şifre"] = sifre;
            drow["Cinsiyet"] = cinsiyet.ToString();
            drow["Tarih"] = dtarih.ToString();
            drow["Adres"] = adres;
            drow["Şehir"] = sehir;
            drow["İlgi Alanı"] = ilgialani;
            drow["Uzmanlık"] = uzmanlik;

            dt.Rows.Add(drow);

            dataGridView1.DataSource = dt;

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Adı");
            listView1.Columns.Add("Soyadı");
            listView1.Columns.Add("E-Mail");
            listView1.Columns.Add("Şifre");
            listView1.Columns.Add("Cinsiyet");
            listView1.Columns.Add("Tarih");
            listView1.Columns.Add("Adres");
            listView1.Columns.Add("Şehir");
            listView1.Columns.Add("İlgi Alanı");
            listView1.Columns.Add("Uzmanlık");

            string[] uyeler = { adi, soyadi, email, sifre, cinsiyet.ToString(), dtarih.ToString(), adres, sehir, ilgialani, uzmanlik };
            var lstUyeler = new ListViewItem(uyeler);
            listView1.Items.Add(lstUyeler);

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_UyeOl_Click(object sender, EventArgs e)
        {
            if (cb_Uye.Checked == true)
            {
                UyeOl();
            }
        }
    }
}
