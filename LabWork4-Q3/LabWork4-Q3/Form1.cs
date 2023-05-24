namespace LabWork4_Q3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        private void turnLightOn()
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            label1.Text = "ON";
        }
        private void turnLightOff()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            label1.Text = "OFF";
        }
        private bool isOnOff = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (isOnOff)
            {
                isOnOff = false;
                turnLightOn();

            }
            else
            {
                isOnOff = true;
                turnLightOff();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}