using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        UrunVT vt=new UrunVT();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vt.Liste();
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtKategori.Clear();
            nmrStok.Value = 0;
            txtFiyat.Clear();
            txtId.Clear(); 
            txtAd.Focus(); 
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun yeni_urun=new Urun();
            yeni_urun.URUNAD=txtAd.Text;
            yeni_urun.KATEGORI = txtKategori.Text;
            yeni_urun.STOKADET = Convert.ToInt32(nmrStok.Value);
            yeni_urun.FIYAT=Convert.ToInt32(txtFiyat.Text);
            vt.UrunEkle(yeni_urun);
            dataGridView1.DataSource=vt.Liste();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtId.Text))
            {
            
                DialogResult onay=MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?","Silme Onayı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (onay==DialogResult.Yes)
                {
                    vt.UrunSil(Convert.ToInt32(txtId.Text.ToString()));
                    dataGridView1.DataSource = vt.Liste();
                    Temizle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz ürünü seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Urun guncelle_urun = new Urun();
            guncelle_urun.ID = Convert.ToInt32(txtId.Text.ToString());
            guncelle_urun.URUNAD = txtAd.Text;
            guncelle_urun.KATEGORI = txtKategori.Text;
            guncelle_urun.STOKADET = Convert.ToInt32(nmrStok.Value);
            guncelle_urun.FIYAT = Convert.ToDecimal(txtFiyat.Text);
            vt.UrunGuncelle(guncelle_urun);
            dataGridView1.DataSource = vt.Liste();
            Temizle();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtKategori.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            nmrStok.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vt.UrunAra(txtArama.Text);
        }
    }
}
