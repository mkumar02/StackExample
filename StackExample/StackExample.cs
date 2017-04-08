using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    class StackExample
    {
        public Stack<Book> books = new Stack<Book>();
        public void AddBook(Book book)
        {
            books.Push(book);
        }
        public Book DeleteBook()
        {
            return books.Pop();
        }
        public void DisplayBooks()
        {
            foreach(Book book in books)
            {
                Console.WriteLine("{0},{1},{2},{3}\n", book.Id, book.Title, book.Author, book.Genre);
            }
        }
    }
}
