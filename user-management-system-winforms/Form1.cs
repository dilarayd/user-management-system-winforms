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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 cagir = new Form2();
            cagir.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Göster")
            {
                textBox2.PasswordChar = Char.Parse("\0");
                button1.Text = "Gizle";
            }
            else
            {
                textBox2.PasswordChar = Char.Parse("*");
                button1.Text = "Göster";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == KullaniciVeri.KullaniciMail && textBox2.Text == KullaniciVeri.KullaniciSifre)
            {
                MessageBox.Show("Hoşgeldiniz " + KullaniciVeri.KullaniciAdi);
                Form3 cagir = new Form3();
                cagir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
