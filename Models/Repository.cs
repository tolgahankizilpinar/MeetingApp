namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "Metin", Email = "metin@gmail.com", Phone = "1234567", WillAttend = true });
            _users.Add(new UserInfo() { Id = 2, Name = "Tolga", Email = "tolga@gmail.com", Phone = "765765", WillAttend = true });
            _users.Add(new UserInfo() { Id = 3, Name = "Derya", Email = "derya@gmail.com", Phone = "2938475", WillAttend = false });
        }

        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }
    }
}