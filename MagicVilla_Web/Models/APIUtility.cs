namespace MagicVilla_Web.Models
{
    public static class APIUtility
    {
        public enum ApiType
        {
            GET, POST, PUT, DELETE
        }

        public static string SessionToken = "JwtToken";
        public static string APIv1Version = "api/v1";

    }
}
