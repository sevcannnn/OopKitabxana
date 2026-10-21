using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopKitabxana
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
                Console.WriteLine("kitab movcud idi ve size verildi");
            }
            else
            {
                Console.WriteLine("kitab movcud deyil");
            }
        }
        public void ReturnBook()
        {
            Console.WriteLine("kitab qaytarildi");
            isAvailable = true;
         
        }

    }
}
