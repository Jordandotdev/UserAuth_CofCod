namespace UserAuth.application
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    
    public class UserValidation
    {
        public bool ValidateUser(User user)
        {
            if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}