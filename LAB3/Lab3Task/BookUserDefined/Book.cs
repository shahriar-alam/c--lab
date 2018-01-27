using System;
namespace BookUserDefined
{
    public class Book
    {
        string bookName;
        string bookAuthor;
        string bookId;
        string bookType;
        int bookCopy;
        static int bookCounter = 0;

        public Book()
        {
            bookName = bookAuthor = bookId = bookType = "A";
            bookCopy = 0;
            ++bookCounter;
        }
        public Book(string bookName, string bookAuthor, string bookid, string bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookid;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
            ++bookCounter;
        }
        public string BookName
        {
            set
            {
                this.bookName = value;
            }
            get
            {
                return this.bookName;
            }
        }
        public string BookAuthor
        {
            set
            {
                this.bookAuthor = value;
            }
            get
            {
                return this.bookAuthor;
            }
        }
        public string BookId
        {
            set
            {
                this.bookId = value;
            }
            get
            {
                return this.bookId;
            }
        }
        public string BookType
        {
            set
            {
                this.bookType = value;
            }
            get
            {
                return this.bookType;
            }
        }
        public int BookCopy
        {
            set
            {
                this.bookCopy = value;
            }
            get
            {
                return this.bookCopy;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("\nBook Name: " + BookName + "\nAuthor: " + BookAuthor + "\nID: " + BookId + "\nType: " + BookType + "\nCopy: " + BookCopy);
        }
        public void AddBookCopy(int x)
        {
            this.bookCopy += x;
        }
        static public void ShowTotalBookInfo()
        {
            Console.WriteLine("\nTotal Book: " + bookCounter);
        }

    }
}
