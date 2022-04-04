using System;

namespace struc
{
    enum bookType
    {
        Magazine=1, Novel, ReferenceBook, Miscellaneous
    }
    struct Book {
        int bookId;
        string title;
        int price;
        String Types;
        public Book(int id, string name, int cost, bookType type ) {
            bookId = id;
            title = name;
            price = cost;
            Types = type.ToString();
        }
        public void print() {
            Console.WriteLine("BOOK ID: {0} NAME: {1} PRICE: {2} Type: {3}", bookId, title, price,Types);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter book details");

            int id, price;

            Console.WriteLine("Enter book ID");
            int.TryParse(Console.ReadLine(), out id);

            Console.WriteLine("Enter book name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter book price");
            int.TryParse(Console.ReadLine(), out price);

            Console.WriteLine("Select 1 to 4 for booktype");
            string types= Console.ReadLine();
            bookType type = (bookType)Convert.ToInt32(types);

            Book B1 = new Book(id, name, price,type);
            B1.print();
        }
    }
}
