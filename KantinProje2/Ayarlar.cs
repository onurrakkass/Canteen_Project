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

namespace KantinProje2
{
    public partial class Ayarlar : Form
    {
        SqlBaglantisi bgl = new SqlBaglantisi();
        public Ayarlar()
        {
            InitializeComponent();
        }
        void temizle()
        {
            TxtID.Text = "";
            TxtMarka.Text = "";
        }
        void temizle2()
        {
            TxtGrupID.Text = "";
            TxtUrunGrubu.Text = "";
        }
        void listele()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Marka", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }
        void listele2()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from UrunGrubu", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }
        private void Ayarlar_Load(object sender, EventArgs e)
        {
            listele2();
            listele();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Marka (MarkaAd) values (@m1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@m1", TxtMarka.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Marka Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            listele();
        }

        private void BtnMarkaSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Marka where ID=@m1", bgl.baglanti());
            komut.Parameters.AddWithValue("@m1", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Marka Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            temizle();
            listele();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            TxtMarka.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Marka set MarkaAd=@p2 where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Marka güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            listele();
        }

        private void BtnGrupEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into UrunGrubu (UrunAd) values (@u1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@u1", TxtUrunGrubu.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Grubu Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle2();
            listele2();
        }

        private void BtnGrupSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from UrunGrubu where ID=@g1", bgl.baglanti());
            komut.Parameters.AddWithValue("@g1", TxtGrupID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Grubu Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            temizle2();
            listele2();
        }

        private void BtnGrupGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update UrunGrubu set UrunAd=@p2 where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtGrupID.Text);
            komut.Parameters.AddWithValue("@p2", TxtUrunGrubu.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Grubu güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle2();
            listele2();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            TxtGrupID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            TxtUrunGrubu.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
        }

        private void Ayarlar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
