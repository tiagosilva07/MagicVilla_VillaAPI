namespace MagicVilla_VillaAPI.Logging
{
    public class Logging : ILogging
    {
        public void Log(string message, string type)
        {
            if( type == "error" )
            {
                Console.WriteLine($"ERROR - {message}");
            }
            else if( type == "info" )
            {
                Console.WriteLine($"INFO - {message}");
            }
            else 
            {
                Console.WriteLine($"{message}");
            }
        }
    }
}
