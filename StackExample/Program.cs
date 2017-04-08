using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StackExample stackBooks = new StackExample();
            stackBooks.AddBook(new Book(1, "book1", "author1", "boring"));
            Console.WriteLine("Displaying All Books");
            stackBooks.DisplayBooks();
            string choice;
            do
            {
                Console.WriteLine("Enter id of next book");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter title of next book");
                string title = Console.ReadLine();
                Console.WriteLine("Enter author of next book");
                string author = Console.ReadLine();
                Console.WriteLine("Enter genre of next book");
                string genre = Console.ReadLine();
                stackBooks.AddBook(new Book(id, title, author, genre));
                Console.WriteLine("Displaying All Books");
                stackBooks.DisplayBooks();

                Console.WriteLine("Press Y/y to enter another record.Press any other character to exit");
                choice = Console.ReadLine().ToUpperInvariant();
            } while (choice == "Y");

            //Console.Write("here");
            //Console.Write("here2");
            //Console.ReadLine();
            //Derived d = new Derived();
            //d.Display(3);
            //Base b = new Base();
            //b.Display(2);
            Console.ReadLine();
        }
    }
}
