using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class BookClass
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        private bool isAvailable = true;

        public void BorrowBook() 
        { 
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine("kitab movcud idi size verildi");
            }
            else
            {
                Console.WriteLine("kitab movcud deyil");
            }
        }
        public void ReturnBook()
        {
            isAvailable = true;
            Console.WriteLine("kitab qaytarildi");
        }

    }
}
