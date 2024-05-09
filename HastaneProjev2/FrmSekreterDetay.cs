using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProjev2
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string TCnumara;
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TCnumara;

            //Ad Soyad Cekme
            SqlCommand cmd = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreterler where SekreterTC=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",LblTC.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LblAdSoyad.Text = reader[0].ToString();
            }
            bgl.baglanti().Close();

            // Bransları Cekme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAd from Tbl_Branslar",bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları Cekme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar', DoktorBrans from Tbl_Doktorlar",bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Bransı Comboboxa aktarma
            SqlCommand cmd2 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                CmbBrans.Items.Add(reader2[0]);
            }
            bgl.baglanti() .Close();    
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Randevu (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)",bgl.baglanti());
            cmd.Parameters.AddWithValue("@r1",MskTarih.Text);
            cmd.Parameters.AddWithValue("@r2", MskSaat.Text); 
            cmd.Parameters.AddWithValue("@r3", CmbBrans.Text);
            cmd.Parameters.AddWithValue("@r4", CmbDoktor.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Randevu Olusturuldu");
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();

            SqlCommand sqlCommand = new SqlCommand("Select DoktorAd, DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1",CmbBrans.Text);
            SqlDataReader reader3 = sqlCommand.ExecuteReader();
            while (reader3.Read())
            {
                CmbDoktor.Items.Add(reader3[0] + " " + reader3[1]);
            }
            bgl.baglanti().Close();
        }
    }
}
