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
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }
        void temizle()
        {
            TxtTur.Text = "";
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void Kategori_Load(object sender, EventArgs e)
        {
            BtnListele_Click(sender, e);
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Kategori (KategoriTur) values (@k1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", TxtTur.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kategori Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnListele_Click(sender, e);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Kategori set KategoriTur=@k2 where ID=@k1", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", TxtID.Text);
            komut.Parameters.AddWithValue("@k2", TxtTur.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kategori güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BtnListele_Click(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtTur.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Kategori", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Kategori where ID=@k1", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kategori Kaydı Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            BtnListele_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void Kategori_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
