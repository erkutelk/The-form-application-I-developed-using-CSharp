using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace App
{
    public partial class KullaniciEkle : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public KullaniciEkle()
        {
            InitializeComponent();
        }

        void Tablo()
        {
            SqlConnection Baglanti = new SqlConnection("Data Source=.;Initial Catalog=borcDefteri;Integrated Security=True");
            string sorgu = "select kullanicilar.ID,isim,soyisim,telefon,bolum_name from kullanicilar INNER JOIN Bolum on Bolum.ID=kullanicilar.bolumID";
            SqlDataAdapter adp = new SqlDataAdapter(sorgu, Baglanti);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        void Ekle()
        {
            SqlConnection Baglanti = new SqlConnection("Data Source=.;Initial Catalog=borcDefteri;Integrated Security=True");
            Baglanti.Open();
            string sorgu = "INSERT INTO kullanicilar (isim, soyisim, telefon, bolumID) VALUES (@isim, @soyisim, @telefon, @bolumID)";
            SqlCommand cmd = new SqlCommand(sorgu, Baglanti);
            cmd.Parameters.AddWithValue("@isim", textBox1.Text);
            cmd.Parameters.AddWithValue("@soyisim", textBox2.Text);
            cmd.Parameters.AddWithValue("@telefon", textBox3.Text);
            cmd.Parameters.AddWithValue("@bolumID", comboBox1.SelectedValue);
            cmd.ExecuteNonQuery();
            Baglanti.Close();
        }

        private void guncelle()
        {
            SqlConnection Baglanti = new SqlConnection("Data Source=.;Initial Catalog=borcDefteri;Integrated Security=True");
            string sorgu = "Update kullanicilar set isim = @isim,soyisim = @soyisim, telefon = @telefon, bolumID = @bolumID where ID=@ID";
            SqlCommand cmd = new SqlCommand(sorgu, Baglanti);
            cmd.Parameters.AddWithValue("@isim", textBox1.Text);
            cmd.Parameters.AddWithValue("@soyisim", textBox2.Text);
            cmd.Parameters.AddWithValue("@telefon", textBox3.Text);
            cmd.Parameters.AddWithValue("@bolumID", comboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@ID", dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ID"].Value);
            Baglanti.Open();
            cmd.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Güncellleme Yapıldı");
        }
        public void SetKullaniciBilgileri(int kullaniciID)
        {
            //bir formdan diğer forma veri gönderme işelemi bu şekilde yapılıoyr
            label4.Text = kullaniciID.ToString();
        }

        private void KullaniciEkle_Load(object sender, EventArgs e)
        {
            Tablo();
            this.bolumTableAdapter.Fill(this.borcDefteriDataSet1.Bolum);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekle();
            Tablo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guncelle();
            Tablo();
        }
    }
}
