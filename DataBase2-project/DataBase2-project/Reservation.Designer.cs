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
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(74, 27);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(135, 21);
            label5.TabIndex = 12;
            label5.Text = "SMART RESERVE";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 5);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // ReservationRoomId
            // 
            ReservationRoomId.Location = new Point(24, 319);
            ReservationRoomId.Margin = new Padding(2);
            ReservationRoomId.Name = "ReservationRoomId";
            ReservationRoomId.Size = new Size(207, 23);
            ReservationRoomId.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(24, 295);
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
            label2.Location = new Point(24, 197);
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
            label1.Location = new Point(24, 108);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 7;
            label1.Text = "In Date";
            label1.Click += label1_Click;
            // 
            // ReservationInDate
            // 
            ReservationInDate.Location = new Point(24, 127);
            ReservationInDate.Margin = new Padding(2);
            ReservationInDate.Name = "ReservationInDate";
            ReservationInDate.Size = new Size(207, 23);
            ReservationInDate.TabIndex = 13;
            ReservationInDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // ReservationOutDate
            // 
            ReservationOutDate.Location = new Point(24, 218);
            ReservationOutDate.Margin = new Padding(2);
            ReservationOutDate.Name = "ReservationOutDate";
            ReservationOutDate.Size = new Size(207, 23);
            ReservationOutDate.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(426, 68);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(208, 19);
            label3.TabIndex = 5;
            label3.Text = "SHOW ALL ROOM AVAILABLE:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(426, 99);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(603, 529);
            listBox1.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(192, 0, 0);
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1033, 3);
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
            button1.Location = new Point(44, 460);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(129, 48);
            button1.TabIndex = 17;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(219, 460);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(129, 48);
            button2.TabIndex = 18;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(281, 114);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(110, 48);
            button3.TabIndex = 19;
            button3.Text = "FetchData";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Reservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(1056, 709);
            Controls.Add(button3);
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
            Margin = new Padding(2);
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
        private Button button3;
    }
}