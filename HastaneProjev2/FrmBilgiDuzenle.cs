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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TcNo;

        sqlBaglantisi bgl = new sqlBaglantisi();

        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = TcNo;
            SqlCommand cmd = new SqlCommand("Select * from Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TxtAd.Text = reader[1].ToString();
                TxtSoyad.Text = reader[2].ToString();
                MskTelefon.Text = reader[4].ToString();
                TxtSifre.Text = reader[5].ToString();
                CmbCinsiyet.Text = reader[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6",bgl.baglanti());
            command2.Parameters.AddWithValue("@p1",TxtAd.Text);
            command2.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            command2.Parameters.AddWithValue("@p3", MskTelefon.Text);
            command2.Parameters.AddWithValue("@p4", TxtSifre.Text);
            command2.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
            command2.Parameters.AddWithValue("@p6", MskTC.Text);
            command2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
