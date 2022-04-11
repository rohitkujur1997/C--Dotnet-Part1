using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Book
{
    struct Book
    {
        public int bookId;
        public string title;
        public int price;
        public string bookType;

        public void getId(int bookId)
        {
            Console.WriteLine("bookId: " + bookId);
            Console.WriteLine("title: " + title);
            Console.WriteLine("price: " + price);
            Console.WriteLine("bookType: " + bookType);
        }

        public void setId(int bookId)
        {
            Console.WriteLine("Employee Id: " + bookType);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book bo;

            // accesses and sets struct field
            bo.bookId = 1;

            // accesses struct methods
            bo.getId(bo.bookId);
        }
    }
}
