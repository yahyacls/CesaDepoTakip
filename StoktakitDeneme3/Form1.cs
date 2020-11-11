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

namespace StoktakitDeneme3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=StokTakipOtomasyonu;Integrated Security=True");
        SqlCommand komut;

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            komut = new SqlCommand("select model,stok from StokBilgi where Kategori='"+"Telefon"+"' ", con);
            SqlDataReader dr =komut.ExecuteReader();

            while (dr.Read())
            {
                chart1.Series["Telefon"].Points.AddXY(dr[0], dr[1]);
                chart1.Series["Kamera"].Points.AddXY(dr[0], dr[1]);

            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StokSayfasi ss = new StokSayfasi();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AlisSayfasi als= new AlisSayfasi();
            als.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SatisSayfasi sas = new SatisSayfasi();
            sas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanicilar kul = new Kullanicilar();
            kul.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
