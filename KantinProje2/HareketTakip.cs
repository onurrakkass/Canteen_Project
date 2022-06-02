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
    public partial class HareketTakip : Form
    {
        //DataTable dt1;
        //SqlDataAdapter da1;
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string HareketTakipREF;
        public string FisTur;
        public string degisken;

        public int secilen;

        public HareketTakip()
        {
            InitializeComponent();
        }
        void temizle()
        {
            TxtStokRef.Text = "";
            TxtMiktar.Text = "";
            TxtBirimRef.Text = "";
            TxtBirimFiyat.Text = "";
            TxtToplamFiyat.Text = "";
            TxtKDVTutar.Text = "";
            TxtKimdenGeldi.Text = "";
            TxtID.Text = "";
        }
        private void HareketTakip_Load(object sender, EventArgs e)
        {
            
            label8.Text = HareketTakipREF;
            SqlBaglantisi bgl = new SqlBaglantisi();
            
            string sql =  "Select * from HareketAna WHERE ID="+ label8.Text;

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, bgl.baglanti());

            da.Fill(dt);


            if (FisTur == "0")  
            {
                radioButton2.Checked = true;
                label2.Text = "Satış Faturası";
            }
            else
            {
                radioButton1.Checked = true;
                label2.Text = "Satın Alma Faturası";
            }

            /*DateTime dtDate;
            if (DateTime.TryParse(dt.Rows[0].Field<string>("Tarih"), out dtDate))
            {
                dateTimePicker1.Value = dtDate;
            }
            */

            if (dt.Rows.Count > 0)
            {

                TxtFirma.Text = dt.Rows[0].Field<string>("FirmaRef");
                //TxtTutar.Text = dt.Rows[0].Field<string>("ToplamFiyat");
                RchAciklama.Text = dt.Rows[0].Field<string>("Acıklama");
                //label7.Text = dt.Rows[0].Field<string>("GirisCikis");

                sql = "Select * from StokHareket WHERE AnaRef=" + label8.Text;
                dt = new DataTable();
                da = new SqlDataAdapter(sql, bgl.baglanti());
                //ds = new DataSet();
                da.Fill(dt);
                dataGridView2.DataSource = dt;

            }

        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into HareketAna (Tarih,FirmaRef,ToplamFiyat,Acıklama,GirisCikis) values (@h1,@h2,@h3,@h4,@h5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@h1", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@h2", TxtFirma.Text);
            komut.Parameters.AddWithValue("@h3", TxtTutar.Text);
            komut.Parameters.AddWithValue("@h4", RchAciklama.Text);
            komut.Parameters.AddWithValue("@h5", label7.Text);
            
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Hareket Bilgisi Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string sql = "SELECT max(ID) ID  FROM HareketAna ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql,bgl.baglanti());
            da.Fill(dt);
            HareketTakipREF = dt.Rows[0]["ID"].ToString();
            label8.Text = dt.Rows[0]["ID"].ToString();
            pictureBox4_Click(sender, e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label7.Text = "1";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label7.Text = "0";
            }
        }

        private void label7_TextChanged(object sender, EventArgs e)
        {
            if (label7.Text == "1")
            {
                radioButton1.Checked = true;
            }
            if (label7.Text == "0")
            {
                radioButton2.Checked = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {   
            SqlCommand komut = new SqlCommand("Update HareketAna set Tarih=@h2,FirmaRef=@h3,ToplamFiyat=@h4,Acıklama=@h5,GirisCikis=@h6 where ID=@h1", bgl.baglanti());
            komut.Parameters.AddWithValue("@h1", label8.Text);
            komut.Parameters.AddWithValue("@h2", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@h3", TxtFirma.Text);
            komut.Parameters.AddWithValue("@h4", TxtTutar.Text);
            komut.Parameters.AddWithValue("@h5", RchAciklama.Text);
            komut.Parameters.AddWithValue("@h6", label7.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Hareket bilgisi güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pictureBox4_Click(sender, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("EXEC sp_hareketdel @h1", bgl.baglanti());
            komut.Parameters.AddWithValue("@h1", label8.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            this.Close();
            //MessageBox.Show("Hareket detayı silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from StokHareket where ID=" + label8.Text, bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            TxtStokRef.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            TxtMiktar.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            TxtBirimRef.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();
            TxtBirimFiyat.Text = dataGridView2.Rows[secilen].Cells[5].Value.ToString();
            TxtToplamFiyat.Text = dataGridView2.Rows[secilen].Cells[6].Value.ToString();
            TxtKDVTutar.Text = dataGridView2.Rows[secilen].Cells[7].Value.ToString();
            TxtKimdenGeldi.Text = dataGridView2.Rows[secilen].Cells[8].Value.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from StokHareket where ID=@s1", bgl.baglanti());
            komut.Parameters.AddWithValue("@s1", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Hareket Bilgisi Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            temizle();
            HareketTakip_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into StokHareket (StokRef,Miktar,BirimRef,Tarih,BirimFiyat,ToplamFiyat,KDVTutar,KimdenGeldi,AnaRef) values (@h1,@h2,@h3,@h4,@h5,@h6,@h7,@h8,@h9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@h1", TxtStokRef.Text);
            komut.Parameters.AddWithValue("@h2", TxtMiktar.Text);
            komut.Parameters.AddWithValue("@h3", TxtBirimRef.Text);
            komut.Parameters.AddWithValue("@h4", dateTimePicker2.Value);
            komut.Parameters.AddWithValue("@h5", TxtBirimFiyat.Text);
            komut.Parameters.AddWithValue("@h6", TxtToplamFiyat.Text);
            komut.Parameters.AddWithValue("@h7", TxtKDVTutar.Text);
            komut.Parameters.AddWithValue("@h8", TxtKimdenGeldi.Text);
            komut.Parameters.AddWithValue("@h9", label8.Text);

            komut.ExecuteNonQuery();
            //bgl.baglanti().Close();
            temizle();
            HareketTakip_Load(sender, e);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update StokHareket set StokRef=@h2,Miktar=@h3,BirimRef=@h4,Tarih=@h5,BirimFiyat=@h6,ToplamFiyat=@h7,KDVTutar=@h8,KimdenGeldi=@h9 where ID=@h1", bgl.baglanti());
            komut.Parameters.AddWithValue("@h1", TxtID.Text);
            komut.Parameters.AddWithValue("@h2", TxtStokRef.Text);
            komut.Parameters.AddWithValue("@h3", TxtMiktar.Text);
            komut.Parameters.AddWithValue("@h4", TxtBirimRef.Text);
            komut.Parameters.AddWithValue("@h5", dateTimePicker2.Value);
            komut.Parameters.AddWithValue("@h6", TxtBirimFiyat.Text);
            komut.Parameters.AddWithValue("@h7", TxtToplamFiyat.Text);
            komut.Parameters.AddWithValue("@h8", TxtKDVTutar.Text);
            komut.Parameters.AddWithValue("@h9", TxtKimdenGeldi.Text);

            komut.ExecuteNonQuery();
            button2_Click(sender, e);
            bgl.baglanti().Close();
            temizle();
            HareketTakip_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from StokHareket", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void TxtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.';
        }

        private void TxtStokRef_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtMiktar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtBirimRef_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtBirimFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtToplamFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtKDVTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtKimdenGeldi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void HareketTakip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
