namespace Decorator
{
    public partial class Form1 : Form
    {
        private IBurger? _burger = new BasicBurger("Burger", 0m);
        public Form1()
        {
            InitializeComponent();

            UpdateInfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void UpdateInfo()
        {
            textBox1.Text =
                "Burger: " + _burger.GetDescription() + Environment.NewLine +
                "Cost: " + _burger.GetCost().ToString("0.00");
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _burger = new BasicBurger("Classic Burger", 100m);
            UpdateInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _burger = new CheeseDecorator(_burger);
            UpdateInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _burger = new BaconDecorator(_burger);
            UpdateInfo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _burger = new SauceDecorator(_burger, "Ketchup", 10m);
            UpdateInfo();
        }
    }
}
