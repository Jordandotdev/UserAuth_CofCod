using System;
using System.Windows.Forms;

namespace UserAuth.application
{
    public partial class Login : Form
    {
        private UserData userData;
        public Login()
        {
            InitializeComponent();
            userData = new UserData();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password =  txtPassword.Text;
            
            User user = new User { Username = username, Password = password };

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                if(userData.AuthenticateUser(user))
                {
                    Home home = new Home();
                    home.Show();
                    MessageBox.Show("Login successful");
                    Close();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect");
                }
                
            }
        }
    }
}