namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string odemeTipi = comboBox1.SelectedItem?.ToString();
            string tutar = textBox1.Text;

            if (string.IsNullOrEmpty(odemeTipi) || string.IsNullOrEmpty(tutar))
            {
                label3.Text = "L�tfen t�m alanlar� doldurun.";
                return;
            }

            label3.Text = $"Sonu� : {odemeTipi} ile {tutar} TL �deme yap�ld�.";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
