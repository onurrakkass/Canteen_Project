
namespace KantinProje2
{
    partial class Ayarlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayarlar));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnMarkaEkle = new System.Windows.Forms.Button();
            this.BtnMarkaSil = new System.Windows.Forms.Button();
            this.BtnMarkaGuncelle = new System.Windows.Forms.Button();
            this.BtnMarkaTemizle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.TxtMarka = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtGrupID = new System.Windows.Forms.TextBox();
            this.TxtUrunGrubu = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnGrupSil = new System.Windows.Forms.Button();
            this.BtnGrupTemizle = new System.Windows.Forms.Button();
            this.BtnGrupEkle = new System.Windows.Forms.Button();
            this.BtnGrupGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(248, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(300, 231);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1140, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnMarkaEkle
            // 
            this.BtnMarkaEkle.Location = new System.Drawing.Point(6, 31);
            this.BtnMarkaEkle.Name = "BtnMarkaEkle";
            this.BtnMarkaEkle.Size = new System.Drawing.Size(115, 35);
            this.BtnMarkaEkle.TabIndex = 12;
            this.BtnMarkaEkle.Text = "Ekle";
            this.BtnMarkaEkle.UseVisualStyleBackColor = true;
            this.BtnMarkaEkle.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnMarkaSil
            // 
            this.BtnMarkaSil.Location = new System.Drawing.Point(137, 31);
            this.BtnMarkaSil.Name = "BtnMarkaSil";
            this.BtnMarkaSil.Size = new System.Drawing.Size(105, 35);
            this.BtnMarkaSil.TabIndex = 13;
            this.BtnMarkaSil.Text = "Sil";
            this.BtnMarkaSil.UseVisualStyleBackColor = true;
            this.BtnMarkaSil.Click += new System.EventHandler(this.BtnMarkaSil_Click);
            // 
            // BtnMarkaGuncelle
            // 
            this.BtnMarkaGuncelle.Location = new System.Drawing.Point(65, 72);
            this.BtnMarkaGuncelle.Name = "BtnMarkaGuncelle";
            this.BtnMarkaGuncelle.Size = new System.Drawing.Size(115, 35);
            this.BtnMarkaGuncelle.TabIndex = 14;
            this.BtnMarkaGuncelle.Text = "Güncelle";
            this.BtnMarkaGuncelle.UseVisualStyleBackColor = true;
            this.BtnMarkaGuncelle.Click += new System.EventHandler(this.BtnMarkaGuncelle_Click);
            // 
            // BtnMarkaTemizle
            // 
            this.BtnMarkaTemizle.Location = new System.Drawing.Point(137, 162);
            this.BtnMarkaTemizle.Name = "BtnMarkaTemizle";
            this.BtnMarkaTemizle.Size = new System.Drawing.Size(105, 35);
            this.BtnMarkaTemizle.TabIndex = 15;
            this.BtnMarkaTemizle.Text = "Temizle";
            this.BtnMarkaTemizle.UseVisualStyleBackColor = true;
            this.BtnMarkaTemizle.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(337, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 46);
            this.label2.TabIndex = 16;
            this.label2.Text = "Marka ve Ürün Grubu Bilgisi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtID);
            this.groupBox1.Controls.Add(this.TxtMarka);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.BtnMarkaSil);
            this.groupBox1.Controls.Add(this.BtnMarkaTemizle);
            this.groupBox1.Controls.Add(this.BtnMarkaEkle);
            this.groupBox1.Controls.Add(this.BtnMarkaGuncelle);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 255);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marka";
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(7, 165);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(100, 32);
            this.TxtID.TabIndex = 17;
            this.TxtID.Visible = false;
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(6, 126);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Size = new System.Drawing.Size(236, 32);
            this.TxtMarka.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtGrupID);
            this.groupBox2.Controls.Add(this.TxtUrunGrubu);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.BtnGrupSil);
            this.groupBox2.Controls.Add(this.BtnGrupTemizle);
            this.groupBox2.Controls.Add(this.BtnGrupEkle);
            this.groupBox2.Controls.Add(this.BtnGrupGuncelle);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(600, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(555, 255);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Grubu";
            // 
            // TxtGrupID
            // 
            this.TxtGrupID.Location = new System.Drawing.Point(6, 165);
            this.TxtGrupID.Name = "TxtGrupID";
            this.TxtGrupID.Size = new System.Drawing.Size(100, 32);
            this.TxtGrupID.TabIndex = 18;
            this.TxtGrupID.Visible = false;
            // 
            // TxtUrunGrubu
            // 
            this.TxtUrunGrubu.Location = new System.Drawing.Point(6, 126);
            this.TxtUrunGrubu.Name = "TxtUrunGrubu";
            this.TxtUrunGrubu.Size = new System.Drawing.Size(232, 32);
            this.TxtUrunGrubu.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(304, 231);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BtnGrupSil
            // 
            this.BtnGrupSil.Location = new System.Drawing.Point(128, 31);
            this.BtnGrupSil.Name = "BtnGrupSil";
            this.BtnGrupSil.Size = new System.Drawing.Size(110, 35);
            this.BtnGrupSil.TabIndex = 13;
            this.BtnGrupSil.Text = "Sil";
            this.BtnGrupSil.UseVisualStyleBackColor = true;
            this.BtnGrupSil.Click += new System.EventHandler(this.BtnGrupSil_Click);
            // 
            // BtnGrupTemizle
            // 
            this.BtnGrupTemizle.Location = new System.Drawing.Point(133, 162);
            this.BtnGrupTemizle.Name = "BtnGrupTemizle";
            this.BtnGrupTemizle.Size = new System.Drawing.Size(105, 35);
            this.BtnGrupTemizle.TabIndex = 15;
            this.BtnGrupTemizle.Text = "Temizle";
            this.BtnGrupTemizle.UseVisualStyleBackColor = true;
            // 
            // BtnGrupEkle
            // 
            this.BtnGrupEkle.Location = new System.Drawing.Point(6, 31);
            this.BtnGrupEkle.Name = "BtnGrupEkle";
            this.BtnGrupEkle.Size = new System.Drawing.Size(110, 35);
            this.BtnGrupEkle.TabIndex = 12;
            this.BtnGrupEkle.Text = "Ekle";
            this.BtnGrupEkle.UseVisualStyleBackColor = true;
            this.BtnGrupEkle.Click += new System.EventHandler(this.BtnGrupEkle_Click);
            // 
            // BtnGrupGuncelle
            // 
            this.BtnGrupGuncelle.Location = new System.Drawing.Point(64, 72);
            this.BtnGrupGuncelle.Name = "BtnGrupGuncelle";
            this.BtnGrupGuncelle.Size = new System.Drawing.Size(115, 35);
            this.BtnGrupGuncelle.TabIndex = 14;
            this.BtnGrupGuncelle.Text = "Güncelle";
            this.BtnGrupGuncelle.UseVisualStyleBackColor = true;
            this.BtnGrupGuncelle.Click += new System.EventHandler(this.BtnGrupGuncelle_Click);
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1163, 334);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ayarlar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnMarkaEkle;
        private System.Windows.Forms.Button BtnMarkaSil;
        private System.Windows.Forms.Button BtnMarkaGuncelle;
        private System.Windows.Forms.Button BtnMarkaTemizle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnGrupSil;
        private System.Windows.Forms.Button BtnGrupTemizle;
        private System.Windows.Forms.Button BtnGrupEkle;
        private System.Windows.Forms.Button BtnGrupGuncelle;
        private System.Windows.Forms.TextBox TxtMarka;
        private System.Windows.Forms.TextBox TxtUrunGrubu;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.TextBox TxtGrupID;
    }
}