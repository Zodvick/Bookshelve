namespace Library;

public class BookStore
{
    private Book[] _assortmentOfBooks = new Book[5];
    private int _bookCount = 0;
    
    public void CreateBook(Book book)
    {
        if (_bookCount >= _assortmentOfBooks.Length)
        {
            Array.Resize(ref _assortmentOfBooks, _bookCount * 2);
        }
        _assortmentOfBooks[_bookCount] = book;
        _bookCount++;
    }

    public string[] ReadBooks()
    {
        string[] newBooks = new string[_bookCount];
        for (int i = 0; i < _bookCount; i++)
        {
            newBooks[i] =  _assortmentOfBooks[i].Title;
        }
        return newBooks;
    }

    public bool UpdateBook(int id, Book newBook)
    {
        if (id >= 0 && id < _bookCount)
        {
            _assortmentOfBooks[id] = newBook;
            return true;
        }

        return false;
    }

    public bool DeleteBook(int id)
    {
        if (id >= 0 && id < _bookCount)
        {
            for (int i = id; i < _bookCount - 1; i++)
            {
                _assortmentOfBooks[i] = _assortmentOfBooks[i + 1];
            }
            _bookCount--;
            _assortmentOfBooks[_bookCount] = null!;
            return true;
        }
        return false;
    }
    
    public void SellBooks(int id)
    {
        if (id >= 0 && id < _bookCount)
        {
            Console.WriteLine($"{_assortmentOfBooks[id].Title} - {_assortmentOfBooks[id].Amount} \nThe book is sold!");
            DeleteBook(id);
        }
        else
        {
            Console.WriteLine("Book not found!");
        }
    }
}