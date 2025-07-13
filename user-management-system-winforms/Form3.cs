using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagementSystemWinforms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 cagir = new Form1();
            cagir.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
      

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = KullaniciVeri.KullaniciAdi;
            textBox3.Text = KullaniciVeri.KullaniciMail;
            textBox4.Text = KullaniciVeri.KullaniciSifre;

            comboBox1.Items.Add("İstanbul");
            comboBox1.Items.Add("Ankara");
            comboBox1.Items.Add("İzmir");

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Güncelleme", 120);
            listView1.Columns.Add("İsim Soyisim", 120);
            listView1.Columns.Add("Cep No", 100);
            listView1.Columns.Add("Şifre", 70);
            listView1.Columns.Add("Cinsiyet", 70);
            listView1.Columns.Add("Adres", 120);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cinsiyet = "";

            if (radioButton1.Checked)
                cinsiyet = "Erkek";
            else if (radioButton2.Checked)
                cinsiyet = "Kadın";
            else
                cinsiyet = "Belirtilmedi"; // opsiyonel, her iki seçenek de işaretli değilse



            if (!checkBox1.Checked)
            {
                MessageBox.Show("Lütfen Onay Verin");

            }
            else
            {


                DateTime guncelleme = DateTime.Now;
                string ilce = comboBox2.SelectedItem?.ToString();
                string il = comboBox1.SelectedItem?.ToString();
                string adres = textBox5.Text + " " + ilce + "/" + il;
                string[] row = { guncelleme.ToString(), KullaniciVeri.KullaniciAdi,maskedTextBox1.Text, KullaniciVeri.KullaniciSifre,cinsiyet,adres };
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                string[] ilce = { "Sarıyer", "Beyoğlu", "Beşiktaş" };
                comboBox2.Items.AddRange(ilce);
            } else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                string[] ilce = { "Çankaya", "Mamak", "Beypazarı" };
                comboBox2.Items.AddRange(ilce);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Clear();
                comboBox2.Text = "";
                string[] ilce = { "Bornova", "Alsancak", "Karşıyaka" };
                comboBox2.Items.AddRange(ilce);
            }
        }
    }
}
