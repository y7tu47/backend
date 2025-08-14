using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string carFilePath = @"C:\Users\uucaex116\Documents\Backend\Database\car.txt";
        Car car = new Car();
        Booking booking = new Booking();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = car.ReadData(carFilePath);
        }

        private delegate void CarDelegate(string filePath);
        private void carManager(CarDelegate carDelegate)
        {
            car.name = textBox1.Text;
            car.price = (double)numericUpDown1.Value;
            carDelegate(carFilePath);
            textBox1.Text = "";
            numericUpDown1.Value = 0;
            dataGridView1.DataSource = car.ReadData(carFilePath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carManager(car.Add);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carManager(car.Update);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            carManager(car.Delete);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            car.id = int.Parse(row.Cells[0].Value.ToString());
            textBox1.Text = row.Cells[1].Value.ToString();
            numericUpDown1.Value = decimal.Parse(row.Cells[2].Value.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            booking.name = textBox1.Text;
            booking.price = (double)numericUpDown1.Value;
            BookingForm bookingForm = new BookingForm(booking.name, booking.price);
            bookingForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ai aiForm = new Ai();
            aiForm.ShowDialog();
        }
    }
}
