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
    public partial class StokDetay : Form
    {
        public StokDetay()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        void temizle()
        {
            TxtBarkod.Text = "";
            TxtUrunAd.Text = "";
            CmbMarka.Text = "";
            TxtMiktar1.Text = "";
            TxtMiktar2.Text = "";
            TxtKDV.Text = "";
            CmbGrup.Text = "";
            TxtSatisFiyat.Text = "";
        }
        bool durum;

        void mukerrer()
        {
            SqlCommand komut = new SqlCommand("select * from StokList where Barkod=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBarkod.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            bgl.baglanti().Close();
            
        }

        private void StokDetay_Load(object sender, EventArgs e)
        {
            //Stok Listesini Aktarma
            button1_Click(sender, e);

            //Combobox1
            SqlCommand komut1 = new SqlCommand("Select UrunAd from UrunGrubu", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                CmbGrup.Items.Add(dr1[0]);
            }

            //Combobox2
            SqlCommand komut2 = new SqlCommand("Select MarkaAd from Marka", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbMarka.Items.Add(dr2[0]);
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            mukerrer();
            if (durum == true)
            {
                SqlCommand komut = new SqlCommand("Insert into StokList (Barkod,UrunAd,Marka,AsgariMiktar,AzamiMiktar,KDV,UrunGrubu,SatisFiyati) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@d1", TxtBarkod.Text);
                komut.Parameters.AddWithValue("@d2", TxtUrunAd.Text);
                komut.Parameters.AddWithValue("@d3", CmbMarka.Text);
                komut.Parameters.AddWithValue("@d4", TxtMiktar1.Text);
                komut.Parameters.AddWithValue("@d5", TxtMiktar2.Text);
                komut.Parameters.AddWithValue("@d6", TxtKDV.Text);
                komut.Parameters.AddWithValue("@d7", CmbGrup.Text);
                komut.Parameters.AddWithValue("@d8", TxtSatisFiyat.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ürün Stoğa Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                button1_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Bu kayıt zaten var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update StokList set Barkod=@p2,UrunAd=@p3,Marka=@p4,AsgariMiktar=@p5,AzamiMiktar=@p6,KDV=@p7,UrunGrubu=@p8,SatisFiyati=@p9 where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);
            komut.Parameters.AddWithValue("@p2", TxtBarkod.Text);
            komut.Parameters.AddWithValue("@p3", TxtUrunAd.Text);
            komut.Parameters.AddWithValue("@p4", CmbMarka.Text);
            komut.Parameters.AddWithValue("@p5", TxtMiktar1.Text);
            komut.Parameters.AddWithValue("@p6", TxtMiktar2.Text);
            komut.Parameters.AddWithValue("@p7", TxtKDV.Text);
            komut.Parameters.AddWithValue("@p8", CmbGrup.Text);
            komut.Parameters.AddWithValue("@p9", TxtSatisFiyat.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Stok bilgisi güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //int searchValue = int.Parse(TxtID.Text);

            int xxxx = dataGridView1.CurrentCell.RowIndex;

            button1_Click(sender, e);
            dataGridView1.Rows[xxxx].Selected = true;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtBarkod.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtUrunAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbMarka.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtMiktar1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtMiktar2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtKDV.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            CmbGrup.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            TxtSatisFiyat.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from StokList where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Kaydı Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from StokList", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
 
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            temizle();
        }

        private void BtnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }

        private void TxtSatisFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void TxtMiktar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtMiktar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtKDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void StokDetay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
