namespace Library;

public class Books
{
    // private fields
    private string _title;
    private string _author;
    private int _pages;
    private int _year;
    private int _isbn;
    
    //constructor
    public Books(string title, string author, int pages, int year, int isbn)
    {
        _title = title;
        _author = author;
        _pages = pages;
        _year = year;
        _isbn = isbn;
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

    public int Isbn
    {
        get { return _isbn; }
    }

    //Create a comment
    private string[] _comments = new string[5];
    private int _commentCount = 0;
    public void CreateComments(string comments)
    {
        _comments[_commentCount] = comments;
        _commentCount++;
    }
    
    //Read the comments
    public void ReadComments()
    {
        for (int i = 0; i < _commentCount; i++)
        {
            Console.WriteLine($"Read the comment: {_comments[i]}");
        }
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
        if (index >= 0 && index < _comments.Length)
        {
            for (int i = 0; i < _commentCount; i++)
            {
                _comments[i] = _comments[i + 1];
            }
            _commentCount--;
            return true;
        }
        return false;
    }
}