using System;
using System.Collections.Generic;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> library = new List<String>();

            library.Add("Axundov Kitabxanasi");
            library.Add("Baku Book Center");

            foreach (var item in library)
            {
                List<String> books = new List<string>();
                books.Add("Kitab1");
                books.Add("Kitab2");
                books.Add("Kitab3");

                Console.WriteLine(item);
                foreach (var item2 in books)
                {
                    Console.WriteLine(item2);
                }
            }
        }
    }
}
