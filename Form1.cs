namespace area_of_rectangle_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A;
            double H;
            double L;
            double P;
            L=double.Parse(textBox1.Text);
            H=double.Parse(textBox2.Text);
            A = L * H;
            textBox3.Text = A.ToString();


        }
    }
}