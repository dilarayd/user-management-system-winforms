using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Mail;

namespace UserManagementSystemWinforms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label6.Text = "";

            Random rnd = new Random();
            string karakter =  "qwertyuıopğüüasdfghjklşizxcvbnmöç1234567890QWERRTYUYIOASDFGHJKLZXCVBNMÖÇ123456789" ;
            string kod = "";
            
            for(int i=0; i<6; i++)
            {
               kod+= karakter[rnd.Next(karakter.Length)];
            }
            label7.Text = kod;




            timer1.Start();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 cagir = new Form1();
            cagir.Show();
            this.Hide();
        }
      
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int karaktersayisi = textBox3.Text.Length;
            if (karaktersayisi>0 && karaktersayisi<=4)
            {
                label6.Text = "Zayıf Şifre";
                progressBar1.Value = 1;
                progressBar1.ForeColor = Color.Red;
            }
            else if (karaktersayisi >4 && karaktersayisi <= 8)
            {
                label6.Text = "Orta Şifre";
                progressBar1.Value = 2;
                progressBar1.ForeColor = Color.Yellow;
            }
            else if (karaktersayisi >8)
            {
                label6.Text = "Güçlü Şifre";
                progressBar1.Value = 3;
                progressBar1.ForeColor = Color.Green;
            }
            else
            {
                label6.Text = "";
                progressBar1.Value = 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Göster")
            {
                textBox3.PasswordChar = Char.Parse("\0");
                textBox4.PasswordChar = Char.Parse("\0");
                button1.Text = "Gizle";
            }
            else
            {
                textBox3.PasswordChar = Char.Parse("*");
                textBox4.PasswordChar = Char.Parse("*");
                button1.Text = "Göster";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        int saniye = 59;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = saniye.ToString();
            saniye--;
            progressBar2.Value = saniye;

            if(saniye==0)
            {
                timer1.Stop();
                Random rnd = new Random();
                string karakter = "qwertyuıopğüüasdfghjklşizxcvbnmöç1234567890QWERRTYUYIOASDFGHJKLZXCVBNMÖÇ123456789";
                string kod = "";

                for (int i = 0; i < 6; i++)
                {
                    kod += karakter[rnd.Next(karakter.Length)];
                }
                label7.Text = kod;

                saniye = 59;
                timer1.Start();
            }
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private bool emailKontrol(string email)
        {
            try
            {
                MailAddress ma = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("İsim Boş Geçilemez!");
            } else if (emailKontrol(textBox2.Text) == false)
            {
                MessageBox.Show("Mail adresini kontrol edin");

            } 
            else if (textBox3.Text != textBox4.Text || textBox3.Text == "" || textBox4.Text=="")
            {
                MessageBox.Show( "Şifreyi kontrol edin");
            }
            else if (textBox5.Text != label7.Text)
            {
                MessageBox.Show("Doğrulama Kodunu kontrol edin");
            }
            else
            {
                KullaniciVeri.KullaniciAdi = textBox1.Text;
                KullaniciVeri.KullaniciMail = textBox2.Text;
                KullaniciVeri.KullaniciSifre = textBox3.Text;
                MessageBox.Show("Kayıt Gerçekleşti");
            }

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text != textBox4.Text)
            {
                label10.Text = "Şifreler Eşit Değil";
            }
            else
            {
                label10.Text = "";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
