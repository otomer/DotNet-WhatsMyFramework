using System;

namespace TO.WhatsMyDotNetFramework
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Environment Information");
            Console.WriteLine("-----------------------");

            GetDotNetVersion.Get45PlusFromRegistry();
            Console.WriteLine($"Environment Version: {Environment.Version}");

            Console.WriteLine($"{Environment.NewLine}You've been using tomero's tool to let you know which .NET version you have installed. :-)");
            AsciiArt.Draw();
            Console.WriteLine($"{Environment.NewLine}Press <Enter> Key to exit...");
            Console.ReadLine();
        }
    }
}
