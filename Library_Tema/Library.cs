using System;

namespace Library_Tema
{
    class Library
    {
        static void Main(string[] args)
        {

            Author author = new Author("Sergiu Bobar", "sergiu.bobar@gmail.com");
            Book book = new Book("Become a millionaire playing crypto games!", 2022, author, 149);

            Console.WriteLine("Book {0}({1} RON), by {2}, published in {3}", 
                book.getName(),
                book.getPrice(),
                author.getName(), 
                book.getYear());
        }
    }
}


