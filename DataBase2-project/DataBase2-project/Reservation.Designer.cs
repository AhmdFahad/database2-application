namespace DataBase2_project
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ReservationRoomId = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            ReservationInDate = new DateTimePicker();
            ReservationOutDate = new DateTimePicker();
            label3 = new Label();
            listBox1 = new ListBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            listBox2 = new ListBox();
            label7 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(85, 36);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(135, 21);
            label5.TabIndex = 12;
            label5.Text = "SMART RESERVE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(10, 7);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // ReservationRoomId
            // 
            ReservationRoomId.Location = new Point(27, 388);
            ReservationRoomId.Margin = new Padding(2, 3, 2, 3);
            ReservationRoomId.Name = "ReservationRoomId";
            ReservationRoomId.Size = new Size(236, 27);
            ReservationRoomId.TabIndex = 8;
            ReservationRoomId.TextChanged += ReservationRoomId_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(27, 352);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 19);
            label4.TabIndex = 5;
            label4.Text = "Room Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(27, 263);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 19);
            label2.TabIndex = 6;
            label2.Text = "Out Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 144);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 7;
            label1.Text = "In Date";
            label1.Click += label1_Click;
            // 
            // ReservationInDate
            // 
            ReservationInDate.Location = new Point(27, 169);
            ReservationInDate.Margin = new Padding(2, 3, 2, 3);
            ReservationInDate.Name = "ReservationInDate";
            ReservationInDate.Size = new Size(236, 27);
            ReservationInDate.TabIndex = 13;
            ReservationInDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // ReservationOutDate
            // 
            ReservationOutDate.Location = new Point(27, 291);
            ReservationOutDate.Margin = new Padding(2, 3, 2, 3);
            ReservationOutDate.Name = "ReservationOutDate";
            ReservationOutDate.Size = new Size(236, 27);
            ReservationOutDate.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(487, 91);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(208, 19);
            label3.TabIndex = 5;
            label3.Text = "SHOW ALL ROOM AVAILABLE:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(487, 132);
            listBox1.Margin = new Padding(2, 3, 2, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(689, 124);
            listBox1.TabIndex = 15;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(192, 0, 0);
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1181, 4);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(20, 21);
            label6.TabIndex = 16;
            label6.Text = "X";
            label6.Click += label6_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(50, 613);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(147, 64);
            button1.TabIndex = 17;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(250, 613);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(147, 64);
            button2.TabIndex = 18;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 477);
            textBox1.Margin = new Padding(2, 3, 2, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 27);
            textBox1.TabIndex = 20;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(487, 329);
            listBox2.Margin = new Padding(2, 3, 2, 3);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(689, 124);
            listBox2.TabIndex = 21;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(487, 299);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(122, 19);
            label7.TabIndex = 22;
            label7.Text = "SHOW ALL Guest";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(29, 446);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(63, 19);
            label9.TabIndex = 24;
            label9.Text = "Guest Id";
            // 
            // Reservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(1207, 945);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(listBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(listBox1);
            Controls.Add(ReservationOutDate);
            Controls.Add(ReservationInDate);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(ReservationRoomId);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Reservation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reservation";
            Load += Reservation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private PictureBox pictureBox1;
        private TextBox ReservationRoomId;
        private Label label4;
        private Label label2;
        private Label label1;
        private DateTimePicker ReservationInDate;
        private DateTimePicker ReservationOutDate;
        private Label label3;
        private ListBox listBox1;
        private Label label6;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private ListBox listBox2;
        private Label label7;
        private Label label9;
    }
}