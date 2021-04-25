namespace PrioList
{
    public class RegisteredUser : User
    {
        private string userID;
        private string userPassword;
        public RegisteredUser(string userID, string userPassword)
        {
            this.userID = userID;
            this.userPassword = userPassword;
        }
    }
}