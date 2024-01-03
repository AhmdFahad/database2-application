using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;


namespace DataBase2_project
{
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
        }

        private void Guest_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = GuestName.Text;
            string ssn = GuestSSN.Text;
            string phoneNumber = GuestNo.Text;

            int age;
            if (!int.TryParse(GuestAge.Text, out age))
            {
                MessageBox.Show("Invalid age input");
                return;
            }

            string email = GuestEmail.Text;

            var client = new RestClient("http://localhost:9000");

            var request = new RestRequest("/guest", Method.Post);

            var postData = new
            {
                name = name,
                ssn = ssn,
                phoneNumber = phoneNumber,
                age = age,
                email = email
            };

            string jsonBody = JsonConvert.SerializeObject(postData);

            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);

            try
            {
                var response = client.Execute(request);

                MessageBox.Show("Guest Details Submitted");

                GuestName.Text = "";
                GuestSSN.Text = "";
                GuestNo.Text = "";
                GuestAge.Text = "";
                GuestEmail.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
