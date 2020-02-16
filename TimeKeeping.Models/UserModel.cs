namespace TimeKeeping.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string UserFullName { get; set; }
    }

    public class UserForResetPassword
    {
        public int UserId { get; set; }
        public string strPassword { get; set; }
    }

    public class UserForSelect
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserFullName { get; set; }
    }

    public class UserForAuthModel
    {
        public int UserId { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
