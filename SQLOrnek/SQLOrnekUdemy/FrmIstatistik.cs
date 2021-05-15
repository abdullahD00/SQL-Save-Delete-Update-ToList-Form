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


namespace SQLOrnekUdemy
{
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("-data source yapılan yer- Data Source=LAPTOP\\SQLEXPRESS;Initial Catalog=Personel_Bilgisi;Integrated Security=True");

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {


            //TOPLAM PERSONEL SAYISINI BULMAK

            baglanti.Open();

            SqlCommand komut = new SqlCommand("select count(*) from Tbl_Personel",baglanti );
            SqlDataReader dr = komut.ExecuteReader ();
            while (dr.Read())
            {

                label2.Text = dr[0].ToString();


            }
            baglanti.Close();


            //TOPLAM EVLİ SAYISINI BULMAK


            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("select count(*) from Tbl_Personel where PerDurum=1", baglanti);

            SqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {
                label6.Text = dr1[0].ToString();
            }

            baglanti.Close();

            //TOPLAM BEKAR SAYISINI BULMAK

            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("select count(*) from Tbl_Personel where PerDurum=0", baglanti);

            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                label4.Text = dr2[0].ToString();
            }

            baglanti.Close();

            //


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
