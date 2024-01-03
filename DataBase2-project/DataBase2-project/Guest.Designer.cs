namespace DataBase2_project
{
    partial class Guest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest));
            label5 = new Label();
            pictureBox3 = new PictureBox();
            GuestName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            GuestSSN = new TextBox();
            label3 = new Label();
            GuestNo = new TextBox();
            label4 = new Label();
            GuestEmail = new TextBox();
            label6 = new Label();
            GuestAge = new TextBox();
            button1 = new Button();
            label7 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(74, 28);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(135, 21);
            label5.TabIndex = 16;
            label5.Text = "SMART RESERVE\r\n";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(9, 8);
            pictureBox3.Margin = new Padding(2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // GuestName
            // 
            GuestName.Location = new Point(74, 114);
            GuestName.Margin = new Padding(2);
            GuestName.Name = "GuestName";
            GuestName.Size = new Size(233, 23);
            GuestName.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(74, 93);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 18;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(443, 87);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 20;
            label2.Text = "SSN:";
            // 
            // GuestSSN
            // 
            GuestSSN.Location = new Point(443, 108);
            GuestSSN.Margin = new Padding(2);
            GuestSSN.Name = "GuestSSN";
            GuestSSN.Size = new Size(231, 23);
            GuestSSN.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(74, 209);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 21);
            label3.TabIndex = 22;
            label3.Text = "Phone Number:";
            // 
            // GuestNo
            // 
            GuestNo.Location = new Point(73, 232);
            GuestNo.Margin = new Padding(2);
            GuestNo.Name = "GuestNo";
            GuestNo.Size = new Size(233, 23);
            GuestNo.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(443, 210);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 24;
            label4.Text = "Email:";
            // 
            // GuestEmail
            // 
            GuestEmail.Location = new Point(443, 232);
            GuestEmail.Margin = new Padding(2);
            GuestEmail.Name = "GuestEmail";
            GuestEmail.Size = new Size(231, 23);
            GuestEmail.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(274, 333);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 26;
            label6.Text = "Age:";
            // 
            // GuestAge
            // 
            GuestAge.Location = new Point(274, 354);
            GuestAge.Margin = new Padding(2);
            GuestAge.Name = "GuestAge";
            GuestAge.Size = new Size(226, 23);
            GuestAge.TabIndex = 25;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(181, 436);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(137, 48);
            button1.TabIndex = 27;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(192, 0, 0);
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(747, 2);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(20, 21);
            label7.TabIndex = 28;
            label7.Text = "X";
            label7.Click += label7_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(443, 436);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(137, 48);
            button2.TabIndex = 29;
            button2.Text = "Home";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Guest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(774, 574);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(GuestAge);
            Controls.Add(label4);
            Controls.Add(GuestEmail);
            Controls.Add(label3);
            Controls.Add(GuestNo);
            Controls.Add(label2);
            Controls.Add(GuestSSN);
            Controls.Add(label1);
            Controls.Add(GuestName);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Guest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guest";
            Load += Guest_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private PictureBox pictureBox3;
        private TextBox GuestName;
        private Label label1;
        private Label label2;
        private TextBox GuestSSN;
        private Label label3;
        private TextBox GuestNo;
        private Label label4;
        private TextBox GuestEmail;
        private Label label6;
        private TextBox GuestAge;
        private Button button1;
        private Label label7;
        private Button button2;
    }
}