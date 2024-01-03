using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase2_project
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (ReservationInDate.Text == "")
                MessageBox.Show("Please select date");
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string indate = ReservationInDate.Text;
            string outdate = ReservationOutDate.Text;
            string roomid = ReservationRoomId.Text;

            var client = new RestClient("http://192.168.43.87:8080");

            var request = new RestRequest("/", Method.Post);

            var postData = new
            {
                indate = indate,
                outdate = outdate,
                roomid = roomid,
            };

            string jsonBody = JsonConvert.SerializeObject(postData);

            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);

            try
            {
                var response = client.Execute(request);

                MessageBox.Show("Guest Details Submitted");

                ReservationInDate.Text = "";
                ReservationOutDate.Text = "";
                ReservationRoomId.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        public class YourDataModel
        {
            public int RoomId { get; set; }
            public string ReservationOutDate { get; set; }
            public string ReservationIntDate { get; set; }
            // Add other properties as needed
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            string baseUrl = "http://192.168.43.87:8080"; // Replace with your API base URL

            RestClient client = new RestClient(baseUrl);
            var request = new RestRequest("/reservation", Method.Get); // Change Method.Post to Method.GET if you are retrieving data

            RestResponse<List<YourDataModel>> response = client.Execute<List<YourDataModel>>(request);

            if (response.IsSuccessful)
            {
                // Populate the ListBox with the retrieved data
                listBox1.DataSource = response.Data;
                listBox1.DisplayMember = "RoomId"; // Change this to the property you want to display

                // Optionally, you can add more properties to display in the ListBox
                listBox1.ValueMember = "RoomId";
                listBox1.DisplayMember = "ReservationOutDate";
                listBox1.DisplayMember = "ReservationIntDate";
            }
            else
            {
                MessageBox.Show($"Error: {response.ErrorMessage}");
            }
        }


        private void fetchreservationdata()
        {
            string baseUrl = "http://192.168.43.87:8080"; // Replace with your API base URL
            string endpoint = "/reservation/{RoomId}"; // Replace with your API endpoint

            RestClient client = new RestClient(baseUrl);
            RestRequest request = new RestRequest(endpoint, Method.Get);

            // Assuming EmpIdTb.Text contains the employee ID
            request.AddUrlSegment("RoomId", ReservationRoomId.Text);

            RestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                // Deserialize the response content into your data model
                ReservationData reservation = Newtonsoft.Json.JsonConvert.DeserializeObject<ReservationData>(response.Content);

                // Set UI elements
                ReservationOutDate.Text = reservation.ReservationOutDate;
                ReservationInDate.Text = reservation.ReservationInDate;
            }
            else
            {
                // Handle error (e.g., display error message)
                Console.WriteLine("Error: " + response.ErrorMessage);
            }
        }

        // Create a class to represent your data model
        public class ReservationData
        {
            public int ReservationRoomId { get; set; }
            public string ReservationOutDate { get; set; }
            public string ReservationInDate { get; set; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fetchreservationdata();
        }
    }
}
