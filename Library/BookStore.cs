namespace Library;

public class BookStore
{
    private Book[] assortmentOfBooks = new Book[5];
    private int _bookCount = 0;
    
    public void CreateBook(Book book)
    {
        if (_bookCount >= assortmentOfBooks.Length)
        {
            Array.Resize(ref assortmentOfBooks, _bookCount * 2);
        }
        assortmentOfBooks[_bookCount] = book;
        _bookCount++;
    }

    public string[] ReadBooks()
    {
        string[] newBooks = new string[_bookCount];
        for (int i = 0; i < _bookCount; i++)
        {
            newBooks[i] =  assortmentOfBooks[i].Title;
        }
        return newBooks;
    }

    public bool UpdateBook(int id, Book newBook)
    {
        if (id >= 0 && id < _bookCount)
        {
            assortmentOfBooks[id] = newBook;
            return true;
        }

        return false;
    }

    public bool DeleteBook(int id)
    {
        if (id >= 0 && id < _bookCount)
        {
            for (int i = 0; i < _bookCount; i++)
            {
                assortmentOfBooks[i] = assortmentOfBooks[i + 1];
            }
            assortmentOfBooks[_bookCount - 1] = null;
            return true;
        }
        return false;
    }
    
    public void SellBooks(int id)
    {
        if (id >= 0 && id < _bookCount)
        {
            Console.WriteLine($"{assortmentOfBooks[id].Title} \nThe book is sold!");
            DeleteBook(id);
        }
        else
        {
            Console.WriteLine("Book not found!");
        }
    }
}