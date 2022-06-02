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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-ELLTLFB;Initial Catalog=Kantin;Integrated Security=True");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //Grafik1
            baglan.Open();
            SqlCommand komutg1 = new SqlCommand("Select UrunAd,SatisFiyati from StokList", baglan);
            SqlDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Satış Fiyatı"].Points.AddXY(dr1[0],dr1[1]);
            }
            baglan.Close();           
        }

        private void FrmGrafikler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
