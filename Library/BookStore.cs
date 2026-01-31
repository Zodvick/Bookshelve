namespace Library;

public class BookStore
{
    private Book[] _assortmentOfBooks = new Book[5];
    private int _bookCount = 0;
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

    public string ReadBooks()
    {
        int total = 0;
        for (int i = 0; i < _bookCount; i++)
        { 
            total += _assortmentOfBooks[i].Amount;
        }
        return total.ToString();
    }

    public bool UpdateBook(int index, Book newBook)
    {
        if (index >= 0 && index < _bookCount)
        {
            _assortmentOfBooks[index] = newBook;
            return true;
        }

        return false;
    }

    public bool DeleteBook(int index)
    {
        if (index >= 0 && index < _bookCount)
        {
            for (int i = index; i < _bookCount - 1; i++)
            {
                _assortmentOfBooks[i] = _assortmentOfBooks[i + 1];
            }
            _bookCount--;
            _assortmentOfBooks[_bookCount] = null!;
            return true;
        }
        return false;
    }
    
    public bool SellBooks(int index)
    {
        if (index >= 0 && index < _bookCount)
        {
            _assortmentOfBooks[index].SellBooks(1);
            return true;
        }
        else
        {
            return false;
        }
    }
    
    public void ChangePrice(int index, decimal newPrice)
    {
        _assortmentOfBooks[index].ChangePrice(newPrice);
    }
    
    public void RefillStock(int index, int bookCount)
    {
        if (_bookCount >= 0)
        {
            _amount += _bookCount;
        }
    }
}