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
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=StokTakipOtomasyonu;Integrated Security=True");
        SqlDataReader dr;

        void giris()
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select *from Kullanicilar where KullaniciAdi='" + txtKullanici.Text.ToString() + "' and Sifre='" + txtSifre.Text.ToString() + "' ", con);
            dr = komut.ExecuteReader();


            if (dr.Read())
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kulllanıcı Adı veya Şifre hatalı!");
            }
            con.Close();
        }
        void temizle()
        {
            if (txtSifre.Text.Length > 0 || txtKullanici.Text.Length > 0)
            {
                txtKullanici.Text = "";
                txtSifre.Text = "";
            }
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            giris();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter && txtKullanici.Text!="" && txtSifre.Text!="")
            {
                giris();
            }
        }
        private void txtKullanici_TextChanged(object sender, EventArgs e)
        {
            if (txtKullanici.Text.Length > 0 || txtSifre.Text.Length>0)
            {
                btnTemizle.Enabled = true;
            }
            else if (txtKullanici.Text.Length <= 0 || txtSifre.Text.Length <=0)
            {
                btnTemizle.Enabled = false;
            }
        }
        private void GirisSayfasi_Load(object sender, EventArgs e)
        {
            btnTemizle.Enabled = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
