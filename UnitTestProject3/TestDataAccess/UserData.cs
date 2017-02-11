namespace TestDataAccess
{
    public class UserData
    {
        public string Key { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CaseId { get; set; }

        public static UserData GetUserData()
        {
            
            return userData;
        }
    }
}
