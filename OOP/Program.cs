using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BookClass> books = new List<BookClass>();
            books.Add(new BookClass { Title = "Olum Adasi", Author = "Agatha Christie", ISBN = "123" });
            books.Add(new BookClass { Title = " Cinayet ve ceza", Author = " Fyodor Dostoevsky", ISBN = "456" });
            books.Add(new BookClass { Title = "Cinayet Sirri", Author = "Agatha Christie", ISBN = "789" });
            books.Add(new BookClass { Title = "Indinin Gucu", Author = " Eckart Tolle", ISBN = "101" });
            books.Add(new BookClass { Title = "Melek ", Author = " Qaraqan", ISBN = "102" });
            books[0].BorrowBook();
            books[0].BorrowBook();
            books[0].ReturnBook();
            books[0].BorrowBook();
        }
    }

}