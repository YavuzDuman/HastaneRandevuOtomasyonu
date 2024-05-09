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
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Tbl_Branslar",bgl.baglanti());
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@p1)",bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1",TxtAd.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Brans eklendi.","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Delete from Tbl_Branslar where Bransid=@p1", bgl.baglanti());
            cmd2.Parameters.AddWithValue("@p1",TxtId.Text);
            cmd2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brans silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd3 = new SqlCommand("update tbl_Branslar set bransad=@p1 where bransid=@p2", bgl.baglanti());
            cmd3.Parameters.AddWithValue("@p1",TxtAd.Text);
            cmd3.Parameters.AddWithValue("@p2", TxtId.Text);
            cmd3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brans güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
