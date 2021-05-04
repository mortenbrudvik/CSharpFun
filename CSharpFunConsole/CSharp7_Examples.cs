using System;
using static System.Console;

namespace CSharpFunConsole
{
    public static class CSharp7_Examples
    {
        public static void Run()
        {
            WriteLine("Pattern matching C# 7");
            
            WriteLine("is expression");
            const string colorDescription = "blue";
            if (colorDescription is var newColorDescription)
            {
                newColorDescription += " and red";
                WriteLine(newColorDescription);
            }
            
            WriteLine("Switch expression - any type can be used");
            TestingSwitch( "data" );

            WriteLine("Hello World!");
        }

        private static string TestingSwitch(string data)
        {
            switch (data)
            {
                case null: throw new NullReferenceException("yay");
                default: throw new InvalidOperationException("not good");
                case "": break;
                case string s when s.Length > 5: return s; 
            }

            return "";
        }
        
    }
}