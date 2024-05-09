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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;
            //AdSoyad Cekme
            SqlCommand command = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            command.Parameters.AddWithValue("@p1",LblTC.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                LblAdSoyad.Text= reader[0] +" "+ reader[1];
            }
            bgl.baglanti().Close();

            // Randevu gecmisi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from  Tbl_Randevu where HastaTC="+tc,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Bransları cekme
            SqlCommand command2 = new SqlCommand("Select BransAd From Tbl_Branslar",bgl.baglanti());
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read()) 
            {
                CmbBrans.Items.Add(reader2[0]);
            }
            bgl.baglanti().Close();
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand command3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1",bgl.baglanti());
            command3.Parameters.AddWithValue("@p1",CmbBrans.Text);
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                CmbDoktor.Items.Add(reader3[0] + " " + reader3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevu where RandevuBrans='" + CmbBrans.Text+"'" + " and RandevuDoktor='"+CmbDoktor.Text+ "' and RandevuDurum=0",bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void LnkBilgiGuncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.TcNo = LblTC.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen1 = dataGridView2.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView2.Rows[secilen1].Cells[0].Value.ToString();
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Update Tbl_Randevu set RandevuDurum=1, HastaTC=@p1, HastaSikayet=@p2 where Randevuid=@p3",bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1",LblTC.Text);
            sqlCommand.Parameters.AddWithValue("@p2", RchSikayet.Text);
            sqlCommand.Parameters.AddWithValue("@p3", TxtId.Text);
            sqlCommand.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu alındı.", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
