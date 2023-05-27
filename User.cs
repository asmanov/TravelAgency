namespace TravelAgency
{
    public class User
    {
        public User(int id, string logIn, string password)
        {
            Id = id;
            LogIn = logIn;
            Password = password;
        }

        public int Id { get; set; }
        public string LogIn { get; set; }
        public string Password { get; set; }


    }
}
