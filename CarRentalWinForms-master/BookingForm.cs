using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class BookingForm : Form
    {
        Booking booking = new Booking();
        [JsonPropertyName("carFilePath")]
        private string bookingFilePath = @"C:\Users\uucaex116\Documents\Backend\Database\booking.txt";


        public BookingForm(string name, double price)
        {
            InitializeComponent();
            booking.name = name;
            booking.price = price;
            dataGridView1.DataSource = booking.ReadData(bookingFilePath);

        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
        }


        private delegate void BookingDelegate(string filePath);
        private void bookingManager(BookingDelegate bookingDelegate)
        {
            fillBookingFields();
            bookingDelegate(bookingFilePath);
            textBox1.Text = "";
            textBox4.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            dataGridView1.DataSource = booking.ReadData(bookingFilePath);
        }

        private void fillBookingFields()
        {
            booking.userName = textBox1.Text;
            booking.from = dateTimePicker1.Value.ToString();
            booking.to = dateTimePicker2.Value.ToString();
            booking.mobile = textBox4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookingManager(booking.Add);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bookingManager(booking.Update);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bookingManager(booking.Delete);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            booking.id = int.Parse(row.Cells[0].Value.ToString());
            textBox1.Text = row.Cells[3].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(row.Cells[4].Value.ToString());
            dateTimePicker2.Value = DateTime.Parse(row.Cells[5].Value.ToString());
            textBox4.Text = row.Cells[6].Value.ToString();
        }
    }
}
