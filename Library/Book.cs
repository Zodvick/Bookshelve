namespace Library;

public class Book
{
    // private fields
    private string _title;
    private string _author;
    private int _pages;
    private int _year;
    private decimal _price;
    private int _amount;

    //constructor
    public Book(string title, string author, int pages, int year, decimal price, int amount)
    {
        _title = title;
        _author = author;
        _pages = pages;
        _year = year;
        _price = price;
        _amount = amount;
    }

    //Properties
    public string Title
    {
        get { return _title; }
    }

    public string Author
    {
        get { return _author; }
    }

    public int Pages
    {
        get { return _pages; }
    }

    public int Year
    {
        get { return _year; }
    }

    public decimal Price
    {
        get { return _price; }
    }

    public int Amount
    {
        get { return _amount; }
    }

    public string[] Comments
    {
        get { return _comments; }
    }

    //Create a comment
    private string[] _comments = new string[5];
    private int _commentCount = 0;

    public void CreateComments(string comment)
    {
        if (_commentCount >= _comments.Length)
        {
            Array.Resize(ref _comments, _comments.Length + 5);
        }

        _comments[_commentCount] = comment;
        _commentCount++;
    }

    //Read the comments
    public string[] ReadComments()
    {
        string[] newComments = new string[_commentCount];
        for (int i = 0; i < _commentCount; i++)
        {
            newComments[i] = _comments[i];
        }

        return newComments;
    }

    //Updating comments
    public bool UpdateComments(int index, string comments)
    {
        if (index >= 0 && index < _commentCount)
        {
            _comments[index] = comments;
            return true;
        }

        return false;
    }

    //Deleting comments
    public bool DeleteComments(int index)
    {
        if (index >= 0 && index < _commentCount)
        {
            for (int i = index; i < _commentCount - 1; i++)
            {
                _comments[i] = _comments[i + 1];
            }

            _commentCount--;
            _comments[_commentCount] = null!;
            return true;
        }

        return false;
    }
    
    public void ChangePrice(decimal newPrice)
    {
        if (newPrice > 0)
        {
            _price = newPrice;
        }
    }
    
    public void SellBooks(int amount)
    {
        _amount -= amount;
    }
    
    public void RefillStock(int amount)
    {
        _amount += amount;
    }
}