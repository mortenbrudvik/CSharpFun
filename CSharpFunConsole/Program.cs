using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Linq;
using static System.Console;

namespace CSharpFunConsole
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            CSharp7_Examples.Run();
            
            WriteLine("Collection of fun");
            
            WriteLine("KeyedCollection Example");
            var persons = new PersonCollection {new Person("1", "Bob")};
            foreach (var person in persons)
            {
                WriteLine(person);
            }
            

        }

        public class PersonCollection : KeyedCollection<string, Person>
        {
            protected override string GetKeyForItem(Person person)
            {
                return person.Id;
            }
        }

        internal record Person (string Id, string Name);

    }
}
    
    