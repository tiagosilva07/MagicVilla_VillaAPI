namespace MagicVilla_VillaAPI.CustomLog
{
    public class Logging : ILogging
    {
        public void Log(string message, string type)
        {
            if( type == "error" )
            {
                Console.BackgroundColor= ConsoleColor.Red;
                Console.Write("ERROR:");
                Console.BackgroundColor= ConsoleColor.Black;
                Console.WriteLine($" {message}");
            }
            else if( type == "info" )
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write("INFO:");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($" {message}");
            }
            else if(type == "warning" )
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write("WARNING:");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($" {message}");
            }
        }
    }
}
