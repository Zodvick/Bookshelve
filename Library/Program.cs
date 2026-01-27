namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[3];

            books[0] = new Book( "Charli", "The Hobbit", 354, 1937, 978054579);
            books[1] = new Book("Alice in the Country of Clover: Nightmare", "QuinRose (writer), Yobu (artist)", 192, 2014, 978054579);
            books[2] = new Book("Another Book", "Some Author", 100, 2020, 978054579);
            
            books[0].CreateComments("I am delighted with this book");
            books[0].CreateComments("very bad book((");
            books[1].CreateComments("Interesting");
            books[1].CreateComments("I don't like it");
            books[2].CreateComments("I am like this book");
            books[2].CreateComments("complete nonsense");

            if (books[2].UpdateComments(1, "OMG"))
            {
                Console.WriteLine("Comment updated");
            }
            
            books[1].DeleteComments(1);
            
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Book: {books[i].Title}");
                
                string[] comments = books[i].ReadComments();
                for (int j = 0; j < comments.Length; j++)
                {
                    Console.WriteLine($"Comment: {comments[j]}");
                }

            }
            
            BookStore bookStoreInSpanish = new BookStore();
            bookStoreInSpanish.CreateBook(books[0]);
            bookStoreInSpanish.CreateBook(books[1]);
            BookStore bookStoreInBritish = new BookStore();
            bookStoreInBritish.CreateBook(books[0]);
            bookStoreInBritish.CreateBook(books[1]);

            bookStoreInBritish.UpdateBook(0, new Book("FirstBook", "Gazel", 231, 2000, 978054579));
            bookStoreInBritish.UpdateBook(1, new Book("SecondBook", "Bob", 342, 1998, 978054579));
            
            bookStoreInSpanish.UpdateBook(0, new Book("ThirdBook", "Bob", 193, 2001, 978054579));
            bookStoreInSpanish.UpdateBook(1, new Book("FourthBook", "Bob", 494, 2002, 978054579));
            
            bookStoreInBritish.DeleteBook(0);
            
            
            bookStoreInBritish.SellBooks(0);
            bookStoreInSpanish.SellBooks(1);
            
            
        }
    }
}