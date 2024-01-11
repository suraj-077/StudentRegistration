using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace StudentRegistration
{
    public partial class student_registration_form : Form
    {
        public student_registration_form()
        {
            InitializeComponent();
        }

       // SqlConnection conn=null;
        //Connection string used for the connecting to the database
        public string ConnectionString = "Data Source=DESKTOP-OR92H06\\SQLEXPRESS;Initial Catalog=StudentDb;User ID=sa;Password=sa123;";

        //Email id textbox should follow this pattern
        string email_pattern = "^[\\w-\\.]+@([\\w]+\\.)+[\\w-]{2,3}$";

       // string email_pattern = "^([_a-z0-9-]+(\\.[_a-z0-9-]+)@[a-z0-9-]+(\\.[a-z0-9-]+)(\\.[a-z]{2,4})){0,30}$ ";


        //phone textbox should follow this pattern
        string phone_pattern = "^[0-9]{10}$";

        //Address textbox should follow this pattern
        string addr_pattern = "^[a-zA-Z0-9]+[a-zA-Z0-9\\.\\s\\-\\,\\.]{5,20}$";




        private void first_name_Leave(object sender, EventArgs e)
        {

            // Check if the name is empty or null
            if (String.IsNullOrEmpty(first_name.Text))
            {
                // Set focus back to the first_name_text TextBox
                first_name.Focus();
                // Display an error message using the error provider
                first_name_errorprovider.SetError(this.first_name, "Please fill the name textfield");
            }
            else
            {
                first_name_errorprovider.Clear();
            }

        }
        /// <summary>
        /// Event handler triggered when a key is pressed in the first_name_text TextBox.
        /// Allows only letters, backspace, and space characters.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The KeyPressEventArgs containing the key that was pressed.</param>

        private void first_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8 || ch == 32)
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

    
        private void last_name_Leave(object sender, EventArgs e)
        {
            // Check if the last_name is empty or null
            if (String.IsNullOrEmpty(last_name.Text))
            {
                // Set focus back to the first_name_text TextBox
                last_name.Focus();
                // Display an error message using the error provider
                last_name_errorProvider.SetError(this.last_name, "Please fill the last name");
            }
            else
            {
                last_name_errorProvider.Clear();
            }


        }

        private void last_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsLetter(ch))
            {
                e.Handled = false;
            }
            else if (ch == 8 || ch == 32)
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void _email_Leave(object sender, EventArgs e)
        {
            // Check if the entered email address matches the specified pattern
            if (Regex.IsMatch(_email.Text, email_pattern) == false)
            {
                _email.Focus();
                email_errorProvider.SetError(this._email, "Invalid Email");
            }

            else
            {
                email_errorProvider.Clear();
            }

        }


        private void phone_no_Leave(object sender, EventArgs e)
        {
            // Check if the entered phone number matches the specified pattern
            if (Regex.IsMatch(phone_no.Text, phone_pattern) == false)
            {
                // Set focus back to the phone_text TextBox
                phone_no.Focus();
                // Display an error message using the error provider
                phone_errorProvider.SetError(this.phone_no, "Please enter the valid mobile number ");
            }
            else
            {
                // Clear the error message if the phone number is valid
                phone_errorProvider.Clear();
            }

        }

        private void phone_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (Char.IsDigit(ch))
            {
                e.Handled = false;
            }

            else if (ch == 8)
            {

                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void _address_Leave(object sender, EventArgs e)
        {

            // Check if the entered address matches the specified pattern
            if (Regex.IsMatch(_address.Text, addr_pattern) == false)
            {
                _address.Focus();
                address_errorProvider.SetError(this._address, "Please enter the valid address ");
            }
            else
            {
                address_errorProvider.Clear();
            }

        }

        private void _address_Enter(object sender, EventArgs e)
        {
            // Check if the current text in the address_text TextBox is the default placeholder text
            if (_address.Text == "Address should be between 5 to 50 letters")
            {
                // Clear the text and change the text color to black
                _address.Text = "";
                _address.ForeColor = Color.Black;
            }
        }

        private void _address_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Get the pressed character
            char addressCharacter = e.KeyChar;

            if (Char.IsLetterOrDigit(addressCharacter))
            {
                e.Handled = false;

            }
            // Allow certain special characters (',', '.', '/', '-')
            else if (addressCharacter >= 44 && addressCharacter <= 47)
            {

                e.Handled = false;
            }
            // Allow backspace
            else if (addressCharacter == 8)
            {

                e.Handled = false;
            }
            // Allow backspace
            else if (addressCharacter == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(first_name.Text))
            {
                // Set focus back to the first_name_text TextBox
                first_name.Focus();
                // Display an error message using the error provider
                first_name_errorprovider.SetError(this.first_name, "Please fill the name textfield");
            }

            // Check if the last_name is empty or null
            if (String.IsNullOrEmpty(last_name.Text))
            {
                // Set focus back to the first_name_text TextBox
                last_name.Focus();
                // Display an error message using the error provider
                last_name_errorProvider.SetError(this.last_name, "Please fill the last name");
            }

            // Check if the entered email address matches the specified pattern
             if (Regex.IsMatch(_email.Text, email_pattern) == false)
            {
                _email.Focus();
                email_errorProvider.SetError(this._email, "Invalid Email");
            }

            // Check if the entered phone number matches the specified pattern
             if (Regex.IsMatch(phone_no.Text, phone_pattern) == false)
            {
                // Set focus back to the phone_text TextBox
                phone_no.Focus();
                // Display an error message using the error provider
                phone_errorProvider.SetError(this.phone_no, "Please enter the valid mobile number ");
            }

            // Check if the entered phone number matches the specified pattern
             if (Regex.IsMatch(phone_no.Text, phone_pattern) == false)
            {
                // Set focus back to the phone_text TextBox
                phone_no.Focus();
                // Display an error message using the error provider
                phone_errorProvider.SetError(this.phone_no, "Please enter the valid mobile number ");
            }
            // Check if the entered address matches the specified pattern
            if (Regex.IsMatch(_address.Text, addr_pattern) == false)
            {
                _address.Focus();
                address_errorProvider.SetError(this._address, "Please enter the valid address ");
            }

            else
            {
                //Create connection
                SqlConnection conn1 = new SqlConnection(ConnectionString);
                if (IsEmailExists(_email.Text, conn1))
                {
                    MessageBox.Show("Email already exists in the database. Please use a different email.");
                }
                if (IsPhoneExist(phone_no.Text, conn1))
                {
                    MessageBox.Show("Phone number already exists in the database. Please use a different phone no.");
                }
                else
                {

                    string gender = GetSelectedGender();
                    string Rank =GetSelectedRank();
                    string Date = GetSelectedDate();
                    string First_name = first_name.Text;
                    string Last_name = last_name.Text;
                    string Email = _email.Text;
                    string Phone_No = phone_no.Text;
                    string Address = _address.Text;



                    try
                    {
                        // Establish database connection
                        using (SqlConnection conn = new SqlConnection(ConnectionString))
                        {
                            conn.Open();

                            // Create SqlCommand object for stored procedure
                            SqlCommand cmd = new SqlCommand("InsertStudent", conn);
                            cmd.CommandType = CommandType.StoredProcedure;

                            // Add parameters to the command
                            cmd.Parameters.AddWithValue("@first_name", First_name);
                            cmd.Parameters.AddWithValue("@last_name", Last_name);
                            cmd.Parameters.AddWithValue("@date_of_birth", Date);
                            cmd.Parameters.AddWithValue("@gender", gender);
                            cmd.Parameters.AddWithValue("@email", Email);
                            cmd.Parameters.AddWithValue("@address", Address);
                            cmd.Parameters.AddWithValue("@rank", Rank);
                            cmd.Parameters.AddWithValue("@phone_no", Phone_No);


                            // Execute the stored procedure
                            int rowsAffected = cmd.ExecuteNonQuery();

                            // Check the result and display a message
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record inserted successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to insert record.");
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Handle database-related errors
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        // Handle other unexpected errors
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }

                }
            }

        }
        private string GetSelectedGender()
        {

            if (_male_radiobutton.Checked)
            {
                return _male_radiobutton.Text;
            }
            else if (_female_radiobutton.Checked)
            {
                return _female_radiobutton.Text;
            }
            else if (_other_radiobutton.Checked)
            {
                return _other_radiobutton.Text;
            }
            else
            {
                return "No gender selected";
            }
        }

        /* private string GetSelectedRanks()
         {

             string selectedRanks = "";

             // Check each checkbox and append the selected ranks to the string
             if (poor.Checked)
                 selectedRanks += "Poor, ";

             if (good.Checked)
                 selectedRanks += "Good, ";

             if (excellent.Checked)
                 selectedRanks += "Excellent";

             // Remove trailing comma and space if any
             selectedRanks = selectedRanks.TrimEnd(',', ' ');

             return selectedRanks;
         }*/
        private string GetSelectedRank()
        {
           
            if (poor.Checked)
                return "Poor";

            if (good.Checked)
                return "Good";

            if (excellent.Checked)
                return "Excellent";

            // If none are selected, return an appropriate default value or handle it accordingly
            return "NoRankSelected";
        }
       /* private void GetSelectedRank()
        {
            // Hook up the event handler for each checkbox
            poor.CheckedChanged += poor_CheckedChanged;
            good.CheckedChanged += poor_CheckedChanged;
            excellent.CheckedChanged += poor_CheckedChanged;
            // Add more checkboxes as needed
        }*/

        private string GetSelectedDate()
        {
            DateTime dob = date.Value;
            string dobString = dob.ToString("yyyy-MM-dd");
            return dobString;
        }

        //Check that email is already exist or not
        private bool IsEmailExists(string email, SqlConnection connection)
        {
            string query = "Select count(*) from Student where Email = @email";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@email", email);
            connection.Open();
            int count = 0;
            count = (int)cmd.ExecuteScalar();

            connection.Close();

            return (count > 0);
        }

        private bool IsPhoneExist(string Phone_No, SqlConnection connection)
        {

            string query = "Select count(*) from Student where PhoneNumber = @phone_No";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@Phone_No",Phone_No);
            connection.Open();
            int count = 0;
            count = (int)cmd.ExecuteScalar();

            connection.Close();

            return (count > 0);

        }

       /* private void poor_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox clickedCheckbox = (System.Windows.Forms.CheckBox)sender;

            // Uncheck other checkboxes
            foreach (Control control in Controls) // Assuming these checkboxes are direct children of the form
            {
                if (control is System.Windows.Forms.CheckBox checkbox && checkbox != clickedCheckbox)
                {
                    checkbox.Checked = false;
                }
            }
        }*/
    }
}
