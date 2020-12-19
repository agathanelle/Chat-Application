using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat_Application_For_PC
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.ToString();
            string password = PasswordTextBox.Text.ToString();
            string repeatPassword = RepeatPasswordTextBox.Text.ToString();

            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + "C:\\Users\\Agata\\Documents\\Project\\Chat Application For PC\\Chat Application For PC\\Database.mdf" + ";Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            string userExists = "SELECT COUNT(*) FROM [User] WHERE Username = '" + username + "'";
            string newUser = "INSERT INTO [User] (Username, Password) VALUES ('" + username + "', '"+ password + "')";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(userExists, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows[0][0].ToString() == "1")
            {
                Debug.WriteLine("User exists");
                ErrorPanel.Visible = true;
                UsernameLabel.ForeColor = Color.DarkRed;
                PasswordLabel.ForeColor = Color.DarkRed;
                RepeatPasswordTextBox.ForeColor = Color.DarkRed;
            }
            else
            {
                if(password!=repeatPassword)
                {
                    Debug.WriteLine("Wrong passwords");
                    ErrorPanel.Visible = true;
                    UsernameLabel.ForeColor = Color.DarkRed;
                    PasswordLabel.ForeColor = Color.DarkRed;
                }
                else
                {
                    SqlDataAdapter sqlData = new SqlDataAdapter();
                    SqlCommand sqlCommand = new SqlCommand(newUser, sqlConnection);
                    sqlData.InsertCommand = sqlCommand;
                    sqlData.InsertCommand.ExecuteNonQuery();
                    sqlCommand.Dispose();
                    sqlConnection.Close();

                    Chat chat = new Chat(username);
                    this.Hide();
                    chat.ShowDialog();
                    this.Close();
                }

            }
            sqlConnection.Close();
        }
        public void ChangingPasswordToDots(CheckBox checkBox, TextBox text)
        {
            if (checkBox.Checked) text.UseSystemPasswordChar = false;
            else text.UseSystemPasswordChar = true;
        }

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e) => ChangingPasswordToDots(checkBoxShowPassword, PasswordTextBox);

        private void CheckBoxShowRepeatPassword_CheckedChanged(object sender, EventArgs e) => ChangingPasswordToDots(checkBoxShowRepeatPassword, RepeatPasswordTextBox);
    }
}
