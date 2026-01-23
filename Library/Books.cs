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
        if (_commentCount == 0)
        {
            Console.WriteLine("No comments found!");
            return;
        }

        for (int i = 0; i < _commentCount; i++)
        {
            Console.WriteLine($"Read the comment: {_comments[i]}");
        }
    }
    
    //Updating comments
    public void UpdateComments(int index, string comments)
    {
        for (int i = 0; i < _commentCount; i++)
        {
            if (index >= 0 && index < _comments.Length)
            {
                _comments[i] = comments;
            }
        }
    }
    
    //Deleting comments
    public void DeleteComments(int index)
    {
        if (index >= 0 && index < _comments.Length)
        {
            _comments[index] = null;
        }
    }
}