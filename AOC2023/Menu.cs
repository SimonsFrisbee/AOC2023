namespace AOC2023
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form day1part1 = new Day1();
            day1part1.ShowDialog();
        }
    }
}