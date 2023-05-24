namespace DistanceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

   
            if (double.TryParse(textBox1.Text, out double speed) && double.TryParse(textBox2.Text, out double distance)){
                for (int i = 1; i <= distance; ++i)
                {
                    listBox1.Items.Add($"After hour {i} the distance is {speed * i}");
                }
            } else
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}