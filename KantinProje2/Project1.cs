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
    public partial class Project1 : Form
    {
        DataTable dt1;
        SqlDataAdapter da1;
        DataSet ds;
        
        public Project1()
        {
            InitializeComponent();
        }
        
        public void TxtDoldur()
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            dt1 = new DataTable();
            da1 = new SqlDataAdapter("Select * from HareketAna", bgl.baglanti());
            ds = new DataSet();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            
        }

        public void Project1_Load(object sender, EventArgs e)
        {
            TxtDoldur();
        }
        
        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlBaglantisi bgl = new SqlBaglantisi();
            DataTable dt2 = new DataTable();
            SqlCommand komut = new SqlCommand("Select * from HareketAna where GirisCikis=1", bgl.baglanti());



            HareketTakip ht = new HareketTakip();
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            ht.HareketTakipREF = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ht.ShowDialog();
            TxtDoldur();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            HareketTakip ht = new HareketTakip();
            
            ht.HareketTakipREF = "0";
            ht.FisTur = "1";
            ht.ShowDialog();
            TxtDoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtDoldur();
        }

        private void Project1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                this.Close();
            }
        }

        private void BtnSatis_Click(object sender, EventArgs e)
        {
            HareketTakip ht = new HareketTakip();

            ht.HareketTakipREF = "0";
            ht.FisTur = "0";
            ht.ShowDialog();
            TxtDoldur();
        }
    }
}
