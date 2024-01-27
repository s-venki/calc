namespace calc
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

        private void Add_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text));
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text));

        }

        private void Mul_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text));

        }

        private void Div_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text));

        }

        private void Modulus_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) % Convert.ToDouble(textBox2.Text));

        }

        private void Power_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && textBox2.Text.Contains('.'))
            {
                e.Handled = true;

            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && textBox1.Text.Contains('.'))
            {
                e.Handled = true;

            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 46 && textBox1.Text.Contains('.'))
            {
                e.Handled = true;

            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
            }
        }
    }
}
