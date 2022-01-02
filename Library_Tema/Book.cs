using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Tema
{
    class Book
    {
        string name;
        int year;
        Author author;
        double price;

        public Book(string name, int year, Author author, double price)
        {
            this.name = name;
            this.year = year;
            this.author = author;
            this.price = price;
        }
        public string getName()
        {
            return name;
        }
        public int getYear()
        {
            return year;
        }
        public Author getAuthor()
        {
            return author;
        }
        public double getPrice()
        {
            return price;
        }
    }
}
