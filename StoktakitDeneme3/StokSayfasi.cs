using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoktakitDeneme3
{
    public partial class StokSayfasi : Form
    {
        public StokSayfasi()
        {
            InitializeComponent();
        }

        private void StokSayfasi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokTakipOtomasyonuDataSet3.StokBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stokBilgiTableAdapter2.Fill(this.stokTakipOtomasyonuDataSet3.StokBilgi);
        }

        private void fotoekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            fototxt.Text = openFileDialog1.FileName;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView2.SelectedCells[0].RowIndex;
            serinumaratxt.Text = dataGridView2.Rows[secili].Cells[0].Value.ToString();
            markacombobox.Text = dataGridView2.Rows[secili].Cells[1].Value.ToString();
            modelcombobox.Text = dataGridView2.Rows[secili].Cells[2].Value.ToString();
            fiyatnumeric.Text = dataGridView2.Rows[secili].Cells[3].Value.ToString();
            stoknumeric.Text = dataGridView2.Rows[secili].Cells[4].Value.ToString();
            kategoricombobox.Text = dataGridView2.Rows[secili].Cells[5].Value.ToString();
            fototxt.Text = dataGridView2.Rows[secili].Cells[6].Value.ToString();


        }
    }
}
