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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        public string tc;
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = tc;
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",MskTC.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TxtAd.Text = reader[1].ToString();
                TxtSoyad.Text = reader[2].ToString();
                CmbBrans.Text = reader[3].ToString();   
                TxtSifre.Text = reader[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5",bgl.baglanti());
            cmd1.Parameters.AddWithValue("@p1",TxtAd.Text);
            cmd1.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            cmd1.Parameters.AddWithValue("@p3", CmbBrans.Text);
            cmd1.Parameters.AddWithValue("@p4", TxtSifre.Text);
            cmd1.Parameters.AddWithValue("@p5", MskTC.Text);
            cmd1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt güncellendi");
        }
    }
}
