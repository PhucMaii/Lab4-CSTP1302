namespace Labwork4_Q2
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double organisms) && double.TryParse(textBox2.Text, out double dailyIncrease) && double.TryParse(textBox3.Text, out double days) )
            {
                listBox1.Items.Add($"Day    Apporximate Population");
                dailyIncrease = (dailyIncrease / 100);
                double temp = organisms;
                for (int i = 1; i <= days;  i++)
                {
                    listBox1.Items.Add($"{i}    {temp}");
                    temp += temp * dailyIncrease;
                }
            } else
            {
                MessageBox.Show("Invalid Input");
            }
        }
    }
}