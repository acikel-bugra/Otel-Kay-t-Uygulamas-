using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace otelotomasyonu
{
    public partial class FrmHizmetler : Form
    {
        public FrmHizmetler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-P28M4HQE;Initial Catalog=oteluygulama;Integrated Security=True");
        private void verilergoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Hizmetler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Hizmetid"].ToString();
                ekle.SubItems.Add(oku["Adı"].ToString());
                ekle.SubItems.Add(oku["Yemek"].ToString());
                ekle.SubItems.Add(oku["Yemek2"].ToString());
                ekle.SubItems.Add(oku["Banyo"].ToString());
                ekle.SubItems.Add(oku["Aktivite"].ToString());
                
                listView1.Items.Add(ekle);

            }
            baglanti.Close();


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmHizmetler_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Hizmetler(Adı,Yemek,Yemek2,Banyo,Aktivite) values('" + textBox1.Text + "','" + comboBox1.Text + "','" + comboBox4.Text + "','" + CmbBanyo1.Text + "','" + CmbAktivite.Text + "')", baglanti);
           // SqlCommand komut2 = new SqlCommand("insert into Hizmetler(Adı,Yemek,Yemek2,Banyo,Aktivite) values('" + textBox2.Text + "','" + comboBox8.Text + "','" + comboBox5.Text + "','" + comboBox7.Text + "','" + comboBox6.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
