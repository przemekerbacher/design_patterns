using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Ala", "Jan", "Alina", "Rafał" };

            var list = new ListCollection<string>(names);

            for (var item = list.CreateIterator(); item.HasNext();)
            {
                var name = (string)item.Next();

                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
