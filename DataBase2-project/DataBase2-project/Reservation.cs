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
            //string indate = ReservationInDate.Text;
            //string outdate = ReservationOutDate.Text;
            //string roomid = ReservationRoomId.Text;

            string customFormat = "yyyy-MM-dd"; // Custom format
            DateTime selectedDate1 = ReservationInDate.Value;
            DateTime selectedDate2 = ReservationOutDate.Value;
            string indate = selectedDate1.ToString(customFormat);
            string outdate = selectedDate2.ToString(customFormat);

            if (selectedDate2 < selectedDate1)
            {
                MessageBox.Show("The 'Out' date cannot be before the 'In' date. Please select a valid date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            var client = new RestClient("http://localhost:9000");

            var request = new RestRequest("/reservation", Method.Post);

            var postData = new
            {
                checkIOutDate = outdate,
                checkInDate = indate
            };

            string jsonBody = JsonConvert.SerializeObject(postData);

            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);

            try
            {
                var response = client.Execute(request);

                MessageBox.Show("Reservation Details Submitted");

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




        public class Staff
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Position { get; set; }
            public string Email { get; set; }
        }

        public class Guest
        {
            public int GuestId { get; set; }
            public string Name { get; set; }
            public string SSN { get; set; }
            public string PhoneNumber { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
            public string DisplayInfo { get; set; }
        }


        public class Room
        {
            public int id { get; set; }
            public Boolean availability { get; set; }
            public string floor { get; set; }
            public string type { get; set; }
            public double price { get; set; }
            public string DisplayInfo { get; set; }
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            string baseUrl = "http://localhost:9000/"; // Replace with your API base URL

            RestClient client = new RestClient(baseUrl);
            var request1 = new RestRequest("/room", Method.Get); // Change Method.Post to Method.GET if you are retrieving data
            var request2 = new RestRequest("/guest", Method.Get); // Change Method.Post to Method.GET if you are retrieving data

            RestResponse<List<Room>> response1 = client.Execute<List<Room>>(request1);

            if (response1.IsSuccessful)
            {
                List<Room> rooms = response1.Data;
                foreach (Room room in rooms)
                {

                    room.DisplayInfo = $"ID: {room.id}, Availability: {room.availability}, Floor: {room.floor}, Type: {room.type}, Price: {room.price}";
                }
                // Set the data source of the ListBox to the list of rooms
                listBox1.DataSource = rooms;

                // Specify how the Room object will be displayed in the ListBox
                listBox1.DisplayMember = "DisplayInfo"; // Assuming a property named "DisplayInfo" is added to Room class


            }
            else
            {
                MessageBox.Show($"Error: {response1.ErrorMessage}");
            }
            RestResponse<List<Guest>> response2 = client.Execute<List<Guest>>(request2);

            if (response2.IsSuccessful)
            {
                List<Guest> guests = response2.Data;
                foreach (Guest guest in guests)
                {

                    guest.DisplayInfo = $"ID: {guest.GuestId}, SSN: {guest.SSN}, Age: {guest.Age}, PhoneNumber: {guest.PhoneNumber}, email: {guest.Email}";
                }
                // Set the data source of the ListBox to the list of rooms
                listBox2.DataSource = guests;

                // Specify how the Room object will be displayed in the ListBox
                listBox2.DisplayMember = "DisplayInfo"; // Assuming a property named "DisplayInfo" is added to Room class


            }
            else
            {
                MessageBox.Show($"Error: {response1.ErrorMessage}");
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

        private void ReservationRoomId_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null && listBox1.SelectedItem is Room selectedRoom)
            {
                if (selectedRoom.availability)
                {
                    // Set the text of ReservationRoomId TextBox to the selected room's ID
                    ReservationRoomId.Text = selectedRoom.id.ToString();
                }
                else
                {
                    // Optional: If the room is not available, you can handle it here (e.g., display a message)
                    ReservationRoomId.Text = ""; // Clear the TextBox
                    MessageBox.Show("Room is not available.");
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null && listBox2.SelectedItem is Guest selectedGuest)
            {
                textBox1.Text = selectedGuest.GuestId.ToString();

            }
        }
    }
}
