using static System.Console;

namespace CSharpFunConsole
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            WriteLine("Pattern matching C# 7");
            
            WriteLine("is expression");
            const string colorDescription = "blue";
            if (colorDescription is var newColorDescription)
            {
                newColorDescription += " and red";
                WriteLine(newColorDescription);
            }
            
            
            


            WriteLine("Hello World!");
        }
    }
}
    
    