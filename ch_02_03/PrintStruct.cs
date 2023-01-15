using Internal;
using System;

public struct Book
{
    public int price;
    public string title;
    public string author;
}

class MainClass
{
    static void Main()
    {
        Book book;
        book.price = 100;
        book.title = "AAA";
        book.author = "A氏";

        System.Console.WriteLine(book.price);
        System.Console.WriteLine(book.title);
        System.Console.WriteLine(book.author);
    }
}