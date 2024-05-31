namespace JWT_JSON_WEB_TOCKEN_.Models
{
    public class UserModel
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
    }
    public class UserLogin
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }

    public class UserConstants
    {
        // fetch the user & its role from DB
        public static List<UserModel> Users = new()
            {
                    new UserModel(){ Username="admin",Password="admin",Role="Admin"},
                    new UserModel(){ Username="user",Password="user",Role="Customer"}
            };
    }

}
