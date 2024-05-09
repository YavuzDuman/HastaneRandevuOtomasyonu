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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select *  from Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Bransları comboboxa aktarma
            SqlCommand cmd2 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                CmbBrans.Items.Add(reader2[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)",bgl.baglanti());
            cmd.Parameters.AddWithValue("@d1",TxtAd.Text);
            cmd.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            cmd.Parameters.AddWithValue("@d3", CmbBrans.Text);
            cmd.Parameters.AddWithValue("@d4", MskTc.Text);
            cmd.Parameters.AddWithValue("@d5", TxtSifre.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor tanımlandı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; 
            TxtAd.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC =@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",MskTc.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTC=@d4",bgl.baglanti());
            cmd2.Parameters.AddWithValue("@d1", TxtAd.Text);
            cmd2.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            cmd2.Parameters.AddWithValue("@d3", CmbBrans.Text);
            cmd2.Parameters.AddWithValue("@d4", MskTc.Text);
            cmd2.Parameters.AddWithValue("@d5", TxtSifre.Text);
            cmd2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
