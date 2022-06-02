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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StokDetay sd = new StokDetay();
            sd.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StokDetay sd = new StokDetay();
            sd.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Finans fs = new Finans();
            fs.Show();
           
        }

        private void pbFinans_Click(object sender, EventArgs e)
        {
            Finans fs = new Finans();
            fs.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kategori kg = new Kategori();
            kg.Show();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Kategori kg = new Kategori();
            kg.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tedarikciler td = new Tedarikciler();
            td.Show();
            
        }

        private void PbTedarikciler_Click(object sender, EventArgs e)
        {
            Tedarikciler td = new Tedarikciler();
            td.Show();
            
        }

        private void PbHareketTakip_Click(object sender, EventArgs e)
        {
            Project1 p1 = new Project1();
            p1.Show();
            
        }

        private void BtnHareketTakip_Click(object sender, EventArgs e)
        {
            Project1 p1 = new Project1();
            p1.Show();
            
        }

        private void PbAyarlar_Click(object sender, EventArgs e)
        {
            Ayarlar ay = new Ayarlar();
            ay.Show();
            
        }

        private void BtnAyarlar_Click(object sender, EventArgs e)
        {
            Ayarlar ay = new Ayarlar();
            ay.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void MainMenu_Load(object sender, EventArgs e)
        {
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                this.Close();
                Form1 f1 = new Form1();
                f1.Show();
            }
        }
    }
}
