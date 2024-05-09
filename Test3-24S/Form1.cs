namespace Test3_24S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            x = x + double.Parse(textBox2.Text);
            textBox2.Text = x.ToString();
            double y = 1;
            y = y + double.Parse(textBox3.Text);
            textBox3.Text = y.ToString();
            double z = x / y;
            textBox4.Text = z.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            double r = 0;
            textBox1 = new TextBox();
            textBox2.Text = r.ToString();
            textBox2 = new TextBox();
            textBox3.Text = r.ToString();
            textBox3 = new TextBox();
            textBox4.Text = r.ToString();


        }
    }
}
