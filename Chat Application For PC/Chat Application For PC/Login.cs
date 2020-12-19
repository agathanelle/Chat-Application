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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide(); //hides Login()
            registration.ShowDialog(); //shows Registration() 
            this.Close(); //closes Login() without closing Registration()
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.ToString();
            string password = PasswordTextBox.Text.ToString();

            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ "C:\\Users\\Agata\\Desktop\\Chat Application For PC\\Chat Application For PC\\Database.mdf" + ";Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();

            string CorrectUser = "SELECT COUNT(*) FROM [User] WHERE Username = '"+username+"' AND  Password = '"+password+"'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(CorrectUser, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows[0][0].ToString() == "1")
            {
                sqlConnection.Close();
                Chat chat = new Chat(username);
                this.Hide();
                chat.ShowDialog();
                this.Close();
                
            }
            else
            {
                Debug.WriteLine("User do not exist");
                ErrorPanel.Visible = true;
                UsernameLabel.ForeColor = Color.DarkRed;
                PasswordLabel.ForeColor = Color.DarkRed;
            }
            sqlConnection.Close();
         
        }

        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e) => ChangingPasswordToDots(checkBoxShowPassword, PasswordTextBox);

        public void ChangingPasswordToDots(CheckBox checkBox, TextBox text)
        {
            if (checkBox.Checked) text.UseSystemPasswordChar = false;
            else text.UseSystemPasswordChar = true;
        }
    }
}
