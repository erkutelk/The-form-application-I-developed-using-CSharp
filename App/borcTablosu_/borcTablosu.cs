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

    public partial class borcTablosu : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public borcTablosu()
        {
            InitializeComponent();
        }
        void Tablo()
        {
            SqlConnection Baglanti = new SqlConnection("Data Source=.;Initial Catalog=borcDefteri;Integrated Security=True");
            string sorgu = "Select kullanicilar.ID,kullanicilar.isim as ISIM,kullanicilar.soyisim as SOYISIM,sum(borclartablosu.borc)as Borclar_Toplam   from kullanicilar, borclartablosu where kullanicilar.ID = borclartablosu.kullaniciID group by kullanicilar.isim,kullanicilar.soyisim,kullanicilar.ID";
            SqlDataAdapter adp = new SqlDataAdapter(sorgu, Baglanti);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        void Ekle()
        {
            SqlConnection Baglanti = new SqlConnection("Data Source=.;Initial Catalog=borcDefteri;Integrated Security=True");
            Baglanti.Open();
            string sorgu = "INSERT INTO borclartablosu (kullaniciID,borc, borc_kategorisiID, aciklama,borc_alinan_tarih) VALUES (@kullaniciID, @borc, @borc_kategorisiID, @aciklama,GETDATE())";
            SqlCommand cmd = new SqlCommand(sorgu, Baglanti);
            cmd.Parameters.AddWithValue("@borc", textBox2.Text);
            cmd.Parameters.AddWithValue("@kullaniciID", listBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@borc_kategorisiID", comboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@aciklama", textBox4.Text);
          

            cmd.ExecuteNonQuery();
            Baglanti.Close();
        }

        
       
        void hatirlat()
        {
            SqlConnection Baglanti = new SqlConnection("Data Source=.;Initial Catalog=borcDefteri;Integrated Security=True");
            Baglanti.Open();
            string sorgu = "INSERT INTO borclartablosu (hatirlatma) values(true)";
            SqlCommand cmd = new SqlCommand(sorgu, Baglanti);
            cmd.ExecuteNonQuery();
            Baglanti.Close();

        }

        public void gosterBorc(int KullaniciID)
        {
            SqlConnection Baglanti = new SqlConnection("Data Source=.;Initial Catalog=borcDefteri;Integrated Security=True");
            Baglanti.Open();
            string sorgu = "SELECT kullanicilar.isim, kullanicilar.soyisim, SUM(CASE WHEN borc_kategorisi.kategori = 'YEMEK' THEN borclartablosu.borc ELSE 0 END) as YEMEK, SUM(CASE WHEN borc_kategorisi.kategori = 'YAKIT' THEN borclartablosu.borc ELSE 0 END) as YAKIT, SUM(CASE WHEN borc_kategorisi.kategori = 'DETARJAN' THEN borclartablosu.borc ELSE 0 END) as DETARJAN, SUM(CASE WHEN borc_kategorisi.kategori = 'DİĞER' THEN borclartablosu.borc ELSE 0 END) as DİĞER FROM borclartablosu INNER JOIN borc_kategorisi ON borclartablosu.borc_kategorisiID = borc_kategorisi.ID INNER JOIN kullanicilar ON kullanicilar.ID = borclartablosu.kullaniciID WHERE kullanicilar.ID = @kullaniciID GROUP BY kullanicilar.isim, kullanicilar.soyisim";
            SqlCommand cmd = new SqlCommand(sorgu, Baglanti);
            cmd.Parameters.AddWithValue("@kullaniciID", KullaniciID);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                

                label5.Text= dr["YEMEK"].ToString();
                label9.Text = dr["YAKIT"].ToString();
                label10.Text = dr["DİĞER"].ToString();

                label11.Text = dr["DETARJAN"].ToString();
   
                

            }
            Baglanti.Close();
        }


        private void borcTablosu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'borcDefteriDataSet3.kullanicilar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanicilarTableAdapter.Fill(this.borcDefteriDataSet3.kullanicilar);
            // TODO: Bu kod satırı 'borcDefteriDataSet2.borc_kategorisi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borc_kategorisiTableAdapter.Fill(this.borcDefteriDataSet2.borc_kategorisi);
            Tablo();
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.Name = "konu";
            btn1.Text = "incele";
            btn1.UseColumnTextForButtonValue = true;
            btn1.DefaultCellStyle.BackColor = Color.White;
            btn1.Width = 50;


            dataGridView1.Columns.Add(btn1);
            
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Ekle();
            Tablo();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

 
            if (e.ColumnIndex == dataGridView1.Columns["konu"].Index && e.RowIndex >= 0)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int kullaniciID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].Value);

                GosterKullaniciOzellikleri(kullaniciID);
            }

        }

        private void GosterKullaniciOzellikleri(int kullaniciID)
        {
            // Kullanıcı özelliklerini çekmek için veritabanı sorgusu
            string sorgu = "SELECT * FROM kullanicilar WHERE ID = @kullaniciID";

            using (SqlConnection Baglanti = new SqlConnection("Data Source=.;Initial Catalog=borcDefteri;Integrated Security=True"))
            {
                Baglanti.Open();
                using (SqlCommand cmd = new SqlCommand(sorgu, Baglanti))
                {
                    cmd.Parameters.AddWithValue("@kullaniciID", kullaniciID);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        // KullaniciEkle formunu oluştur
                        KullaniciEkle kullaniciEkleForm = new KullaniciEkle();

                        //bir formdan diğer forma veri gönderme işelemi bu şekilde yapılıoyr
                        kullaniciEkleForm.SetKullaniciBilgileri(Convert.ToInt32(dr["ID"]));

                        // Formu göster
                        kullaniciEkleForm.Show();
                    }

                    dr.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {


            int kullaniciID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            gosterBorc(kullaniciID);
            
            Tablo();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            hatirlat();
        }

    }
}





