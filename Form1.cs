namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            MessageBox.Show("button2 unlocked");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("succesfull");
        }
    }
}