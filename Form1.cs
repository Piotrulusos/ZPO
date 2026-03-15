namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int wartosc = (int)numericUpDown1.Value;
            var d = new Drzewo(wartosc);
            Drzewo d1 = new(wartosc);
            MessageBox.Show(d.korzen.ToString());
        }
    }
}