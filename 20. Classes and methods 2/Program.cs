using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Classes_and_methods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creation of the book object, it gets all the attributes of the book class
            Book book1 = new Book();

            //create the first book
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 99;

            //create a second book
            Book book2 = new Book();
            book2.title = "Lord of Rings";
            book2.author = "Tolkein";
            book2.pages = 999;

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book2.title);

            //3rd book
            Book book3 = new Book();
            book3.title = "Cinderella";
            book3.author = "Beyonce R";
            book3.pages = 890;

            //4th book
            Book book4 =new Book();
            book4.title = "Mover of men and mountains";
            book4.author = "JJ Mkhonza";
            book4.pages = 666;

            //print to screen
            Console.WriteLine(book3.title + " by " + book3.author + " with " + book3.pages + " pages");
            Console.WriteLine(book4.title + " by " + book4.author + " with " + book4.pages + " pages");


            //freeze
            Console.ReadLine();
        }
    }
}
