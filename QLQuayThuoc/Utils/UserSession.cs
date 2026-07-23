namespace QLQuayThuoc.Utils
{
    public static class UserSession
    {
        public static int UserId { get; private set; }

        public static string FullName { get; private set; }
            = string.Empty;

        public static string Role { get; private set; }
            = string.Empty;

        public static bool IsLoggedIn => UserId > 0;

        public static void SetUser(int userId, string fullName, string role)
        {
            UserId = userId;
            FullName = fullName;
            Role = role;
        }

        public static void Clear()
        {
            UserId = 0;
            FullName = string.Empty;
            Role = string.Empty;
        }
    }
}