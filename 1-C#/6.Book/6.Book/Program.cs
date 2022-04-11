using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
   struct Book
    {
        int BookId;
        string Title;
        double Price;
        

        enum BookType
        {
            Magazine,
            Novel,
            ReferenceBook,
            Miscellaneous
        }
        public void AcceptDetails()
        {
            Console.WriteLine("Enter The BookId:");
            BookId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Title :");
            Title = Console.ReadLine();
            Console.WriteLine("Enter The Book Price :");
            Price = Convert.ToDouble(Console.ReadLine());
            
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Select Booktype:  Magazine or Novel or ReferenceBook or Miscellaneous");
            string c = Console.ReadLine();
            if (c == "Magazine")
            {
                Console.WriteLine("The BookId:" + BookId);
                Console.WriteLine("The Title Of The Book is :" + Title);
                Console.WriteLine("The Price Of The Book is :" + Price);
                Console.WriteLine("The BookType is :" + BookType.Magazine);
            }
            else if (c=="Novel")
            {
                Console.WriteLine("The BookId:" + BookId);
                Console.WriteLine("The Title Of The Book is :" + Title);
                Console.WriteLine("The Price Of The Book is :" + Price);
                Console.WriteLine("The BookType is :" + BookType.Novel);
            }
            else if (c == "ReferenceBook")
            {
                Console.WriteLine("The BookId:" + BookId);
                Console.WriteLine("The Title Of The Book is :" + Title);
                Console.WriteLine("The Price Of The Book is :" + Price);
                Console.WriteLine("The BookType is :" + BookType.ReferenceBook);
            }
            else if (c == "Miscellaneous")
            {
                Console.WriteLine("The BookId:" + BookId);
                Console.WriteLine("The Title Of The Book is :" + Title);
                Console.WriteLine("The Price Of The Book is :" + Price);
                Console.WriteLine("The BookType is :" + BookType.Miscellaneous);
            }
            else
            {
                Console.WriteLine("Check Spelling of BookType");
                    }
        }

        public static void Main()
        {
            Book b1 = new Book();
            b1.AcceptDetails();
            b1.DisplayDetails();
            Console.ReadKey();
        }
    }
    
}