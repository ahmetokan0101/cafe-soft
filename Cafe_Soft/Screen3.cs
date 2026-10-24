using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Soft
{
    public partial class Screen3 : Form
    {
        public static int toplam = 0;
        int toplamtutar = 0;

        int pizza = 300;
        int espresso = 120;
        int icetea = 70;
        int cay = 25;
        int coffe = 70;
        int su = 20;
        int portakalsuyu = 200;
        int elmasuyu = 200;
        int limonata = 200;
        int kola = 70;
        int latte = 100;
        int sicakcikilota = 80;
        int sut = 80;
        int yesilcay = 80;
        int enegydrink = 100;
        int milkshake = 150;
        int madensuyu = 60;
        int ananassuyu = 200;
        int bitkicayi = 80;
        int hindistancevizi = 230;
        int mocha = 100;
        int proteinsuyu = 150;
        int detokssuyu = 150;
        int kabarcikçayi = 110;


        public Screen3()
        {
            InitializeComponent();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void Screen3_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Piza");
            toplamtutar = toplamtutar + pizza;
            toplam = toplam + pizza;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Espresso");
            toplamtutar = toplamtutar + espresso;
            toplam = toplam + espresso;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ice Tea");
            toplamtutar += icetea;
            toplam += icetea;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Çay");
            toplamtutar += cay;
            toplam += cay;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Coffee");
            toplamtutar += coffe;
            toplam += coffe;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Su");
            toplamtutar += su;
            toplam += su;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Portakal Suyu");
            toplamtutar += portakalsuyu;
            toplam += portakalsuyu;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Elma Suyu");
            toplamtutar += elmasuyu;
            toplam += elmasuyu;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Limonata");
            toplamtutar += limonata;
            toplam += limonata;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kola");
            toplamtutar += kola;
            toplam += kola;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Latte");
            toplamtutar += latte;
            toplam += latte;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Sıcak Çikolata");
            toplamtutar += sicakcikilota;
            toplam += sicakcikilota;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Süt");
            toplamtutar += sut;
            toplam += sut;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Yeşil Çay");
            toplamtutar += yesilcay;
            toplam += yesilcay;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Enerji İçeceği");
            toplamtutar += enegydrink;
            toplam += enegydrink;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Milkshake");
            toplamtutar += milkshake;
            toplam += milkshake;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Maden Suyu");
            toplamtutar += madensuyu;
            toplam += madensuyu;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ananas Suyu");
            toplamtutar += ananassuyu;
            toplam += ananassuyu;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Bitki Çayı");
            toplamtutar += bitkicayi;
            toplam += bitkicayi;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Hindistancevizi Suyu");
            toplamtutar += hindistancevizi;
            toplam += hindistancevizi;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Mocha");
            toplamtutar += mocha;
            toplam += mocha;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Protein Suyu");
            toplamtutar += proteinsuyu;
            toplam += proteinsuyu;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Detoks Suyu");
            toplamtutar += detokssuyu;
            toplam += detokssuyu;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kabarcık Çayı");
            toplamtutar += kabarcikçayi;
            toplam += kabarcikçayi;
            label29.Text = toplam.ToString();
            label28.Text = toplamtutar.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label29.Text = "";
            listBox1.Items.Clear();
            toplam = 0;


            this.Close();
            Screen2 dd = new Screen2();
            dd.Show();

        }

    }
}
