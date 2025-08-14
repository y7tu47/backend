namespace WinFormsApp1
{
    partial class BookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(207, 198);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(294, 23);
            textBox4.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(207, 325);
            button1.Name = "button1";
            button1.Size = new Size(294, 23);
            button1.TabIndex = 4;
            button1.Text = "Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 37);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 5;
            label1.Text = "user name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 86);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 6;
            label2.Text = "from";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 135);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 7;
            label3.Text = "to";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 201);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 8;
            label4.Text = "mobile";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(207, 86);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(294, 23);
            dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(207, 135);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(294, 23);
            dateTimePicker2.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(207, 374);
            button2.Name = "button2";
            button2.Size = new Size(294, 23);
            button2.TabIndex = 11;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(207, 415);
            button3.Name = "button3";
            button3.Size = new Size(294, 23);
            button3.TabIndex = 12;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(548, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 401);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Name = "BookingForm";
            Text = "BookingForm";
            Load += BookingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox4;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
    }
}