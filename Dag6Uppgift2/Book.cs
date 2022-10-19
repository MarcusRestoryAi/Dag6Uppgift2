using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag6Uppgift2
{
    internal class Book
    {
        //Attributes
        public string title;
        public int pages;
        public static int antalBooks = 0;

        //Statisk lista över Book-objekt
        public static List<Book> books = new List<Book>();

        //Konstruktor
        public Book(string title, int pages)
        {
            this.title = title;
            this.pages = pages;

            //Anropar statik attribut antalBooks och ökar med 1
            antalBooks++;
        }

        //Metod för att läsa boken
        public void Read()
        {
            Console.WriteLine("Nu läser vi {0}", title);
        }

        //Statisk metod för att få en slumpmässig bok
        public static Book RecommendBook(List<Book> listOfBooks)
        {
            //Skapar ett objekt av Random
            Random rnd = new Random();

            //Hämtar en slupmässig position
            int index = rnd.Next(listOfBooks.Count);

            //Hämtar en random book från listan
            Book book = listOfBooks[index];

            //Returnera book
            return book;

            // return listOfBooks[index];
        }
    }
}
