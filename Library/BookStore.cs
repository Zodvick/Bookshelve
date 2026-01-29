namespace Library;

public class BookStore
{
    private Book[] _assortmentOfBooks = new Book[5];
    private int _bookCount = 0;
    private decimal _price;
    private int _amount;
    public void CreateBook(Book book)
    {
        if (_bookCount >= _assortmentOfBooks.Length)
        {
            Array.Resize(ref _assortmentOfBooks, _bookCount * 2);
        }
        _assortmentOfBooks[_bookCount] = book;
        _bookCount++;
    }

    public int ReadBooks()
    {
        int _total = 0;
        for (int i = 0; i < _bookCount; i++)
        {
            _total += _assortmentOfBooks[i].Amount;
        }
        return _total;
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
            Console.WriteLine($"\nThe book is sold! \n{_assortmentOfBooks[id].Title} - {_assortmentOfBooks[id].Amount - 1}");
            DeleteBook(id);
        }
        else
        {
            Console.WriteLine("Book not found!");
        }
    }
    
    public void ChangePrice(int id, decimal newPrice)
    {
        if (newPrice > 0)
        {
            _price = newPrice;
        }
    }
    
    public void RefillStock(int id, int _bookCount)
    {
        if (_bookCount >= 0)
        {
            _amount += _bookCount;
        }
    }
    
    
}