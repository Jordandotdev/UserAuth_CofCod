using MySql.Data.MySqlClient;

namespace UserAuth.application
{
    public class UserData
    {
        public MySqlConnection _connection;
        private string _connectionString = "server=Localhost;user=root;database=user_authentication;port=3306;password=Root;";
        
        public UserData()
        {
            _connection = new MySqlConnection(_connectionString);
        }
        
        public bool AuthenticateUser(User user)
        {
            UserValidation userValidation = new UserValidation();
            if (!userValidation.ValidateUser(user))
            {
                return false;
            }

            try
            {
                _connection.Open();
                string query = "SELECT * FROM users WHERE BINARY username = @username AND BINARY password = @password";
                using (MySqlCommand cmd = new MySqlCommand(query, _connection))
                {
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.Password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
            finally
            {
                _connection.Close();
            }
        }
        
    }
}