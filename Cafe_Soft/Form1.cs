using System.Windows.Forms;

namespace Cafe_Soft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sifre;
        private void button1_Click(object sender, EventArgs e)
        {
            Screen2 DD = new Screen2();

            sifre = "Sokak Lambasý";

            if (sifre == textBox1.Text)
            {

                MessageBox.Show("Giriþ baþarýlý!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);



                DD.Show();
                this.Hide();



            }
            else
            {
                MessageBox.Show("Giriþ baþarýsýz Tekrar Deneyiniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}