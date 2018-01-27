using System;
using BookUserDefined;
namespace BookStart
{
    class Start
    {
        static void Main(string[] args)
        {
            Book a = new Book();

            a.BookName = "A";
            a.BookId = "1";
            a.BookAuthor = "AA";
            a.BookType = "AAA";
            a.BookCopy = 100;

            Book b = new Book("B", "BB", "2", "BBB", 50);

            a.ShowInfo();
            b.AddBookCopy(20);
            b.ShowInfo();
            Book.ShowTotalBookInfo();

        }
    }
}
