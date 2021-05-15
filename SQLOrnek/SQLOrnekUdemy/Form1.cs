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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
        }
        
        void verilerisil()
        {
            textBox_PerID.Clear();
            textBox_PerAD.Clear();
            textBox_PerSOYAD.Clear();
            comboBox_PerSEHIR.Text = " ";
            maskedTextBox_PerMAAS.Clear();
            radioButton_Bekar.Checked = false;
            radioButton_Evli.Checked = false;
            textBox_PerMESLEK.Clear();

            textBox_PerAD.Focus();
        } 

        SqlConnection baglanti = new SqlConnection("-data source yapılan yer- Data Source=LAPTOP\\SQLEXPRESS;Initial Catalog=Personel_Bilgisi;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personel_BilgisiDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personel_BilgisiDataSet.Tbl_Personel);

        }

        private void button_LISTELE_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personel_BilgisiDataSet.Tbl_Personel);
        }
        //GİRİLENLERİ KAYIT ETME ALGORİTMASI
        private void button_KAYDET_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@1,@2,@3,@4,@5,@6)", baglanti);
            komut.Parameters.AddWithValue("@1", textBox_PerAD.Text);
            komut.Parameters.AddWithValue("@2", textBox_PerSOYAD.Text);
            komut.Parameters.AddWithValue("@3", comboBox_PerSEHIR.Text);
            komut.Parameters.AddWithValue("@4", maskedTextBox_PerMAAS.Text);
            komut.Parameters.AddWithValue("@5", textBox_PerMESLEK.Text);
            komut.Parameters.AddWithValue("@6", label1.Text);

            komut.ExecuteNonQuery();
            
            baglanti.Close();

            
        }

        private void radioButton_Evli_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_Evli.Checked ==true)
            {
                label1.Text = "True";
                
            }
           

        }

        private void radioButton_Bekar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Bekar.Checked == true)
            {
                label1.Text = "False";
                
            }
        }

        private void button_TEMIZLE_Click(object sender, EventArgs e)
        {

            verilerisil();

        }
        //TABLODAKİ VERİLERİ TEXTBOX'LARA ÇEKME ALGORİTMASI
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox_PerID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox_PerAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox_PerSOYAD.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox_PerSEHIR.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBox_PerMAAS.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox_PerMESLEK.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if(label1.Text == "True")
            {
                radioButton_Evli.Checked = true;
            }
            if(label1.Text == "False")
            {
                radioButton_Bekar.Checked = true;
            }
        }
        //SİLME ALGORİTMASI
        private void button_SIL_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Personel where PerID=@k", baglanti);
            komut.Parameters.AddWithValue("@k", textBox_PerID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void button_GUNCELLE_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("update Tbl_Personel set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6,PerId=@a7", baglanti);

            komut.Parameters.AddWithValue("@a1", textBox_PerAD.Text);
            komut.Parameters.AddWithValue("@a2", textBox_PerSOYAD.Text);
            komut.Parameters.AddWithValue("@a3", comboBox_PerSEHIR.Text);
            komut.Parameters.AddWithValue("@a4", maskedTextBox_PerMAAS.Text);
            komut.Parameters.AddWithValue("@a5", label1.Text);
            komut.Parameters.AddWithValue("@a6", textBox_PerMESLEK.Text);
            komut.Parameters.AddWithValue("@a7", textBox_PerID.Text);

            komut.ExecuteNonQuery();

            baglanti.Close();

        }

        private void button_ISTATISTIK_Click(object sender, EventArgs e)
        {
            
            
            FrmIstatistik frm = new FrmIstatistik();
            frm.Show();



        }
    }
}
