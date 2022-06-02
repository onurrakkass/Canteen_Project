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
    public partial class Tedarikciler : Form
    {
        public Tedarikciler()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void Tedarikciler_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
        void temizle()
        {
            TxtAd.Text = "";
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tedarikci (TedarikciAd,TelefonNo) values (@t1,@t2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@t1", TxtAd.Text);
            komut.Parameters.AddWithValue("@t2", MskTelefonNo.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Tedarikçi Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button1_Click(sender, e);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tedarikci set TedarikciAd=@t2,TelefonNo=@t3 where ID=@t1", bgl.baglanti());
            komut.Parameters.AddWithValue("@t1", TxtID.Text);
            komut.Parameters.AddWithValue("@t2", TxtAd.Text);
            komut.Parameters.AddWithValue("@t3", MskTelefonNo.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Tedarikçi güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button1_Click(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            MskTelefonNo.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tedarikci where ID=@t1", bgl.baglanti());
            komut.Parameters.AddWithValue("@t1", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Kaydı Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tedarikci", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            temizle();
        }

        private void Tedarikciler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
