namespace Sinnema_bufe_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double toplam = 0, kasatutari = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            double misir, su, cay, bilet;
            misir = Convert.ToInt16(textBox1.Text);
            su = Convert.ToInt16(textBox2.Text);
            cay = Convert.ToInt16(textBox3.Text);
            bilet = Convert.ToInt16(textBox4.Text);

            toplam = misir * 4 + su * 1 + cay * 2.5 + bilet * 18;
            label10.Text = Convert.ToString(toplam) + " $";
            kasatutari = kasatutari + toplam;
            label12.Text = "Kasa Tutarý: " + kasatutari + "$";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}