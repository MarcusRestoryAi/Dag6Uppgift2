namespace Dag6Uppgift2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa ett antal böcker
            //Spara dem i statisk lista inuti Book klassen
            Book.books.Add(new Book("Lord of the Rings", 300));
            Book.books.Add(new Book("Harry Potter", 400));
            Book.books.Add(new Book("Mordet på Orientexpressen", 350));
            Book.books.Add(new Book("Lord of the Flies", 700));
            Book.books.Add(new Book("Mitt liv som Bert", 700));

            //ForEach loop för att läsa varje book samt skriva ut info
            foreach (Book book in Book.books)
            {
                Console.WriteLine("{0} har {1} sidor.", book.title, book.pages);
                book.Read();
            }

            //Skriv ut hur många böcker som har blivit skapta
            Console.WriteLine("Det finns sammanlagt {0} antal böcker!", Book.antalBooks);

            //Bli rekommenderad en slumpmässig book
            Book recommendedBook = Book.RecommendBook(Book.books);

            //Skriv ut titel av rekommenderad book
            Console.WriteLine("Nu skall jag läsa {0} igen!", recommendedBook.title);
        }
    }
}