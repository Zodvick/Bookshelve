namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Books[] books = new Books[3];

            books[0] = new Books( "Charli", "The Hobbit", 354, 1937, 978054579);
            books[1] = new Books("Alice in the Country of Clover: Nightmare", "QuinRose (writer), Yobu (artist)", 192, 2014, 978054579);
            books[2] = new Books("Another Book", "Some Author", 100, 2020, 978054579);
            
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
                Console.WriteLine($"Книга: {books[i].Title}");
                string[] commentsForDisplay = books[i].ReadComments();
                Books.DisplayComments(commentsForDisplay);
                Console.WriteLine();
                
            }
        }
    }
}