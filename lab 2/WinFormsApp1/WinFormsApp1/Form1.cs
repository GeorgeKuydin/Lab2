namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double orderSize = double.Parse(textBox1.Text);

            DeliveryFactory factory = new FoodDeliveryFactory();
            Delivery delivery = factory.CreateDelivery(orderSize);

            MessageBox.Show("Delivery method: " + delivery.DeliveryMethod);
            MessageBox.Show("Delivery cost: " + delivery.DeliveryCost);
            delivery.Deliver();
        }
    }
}