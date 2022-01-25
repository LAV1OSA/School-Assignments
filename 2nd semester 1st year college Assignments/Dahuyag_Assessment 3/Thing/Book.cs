public class Book : Thing
{
    private string _title;
    private string _author;
    private int _numberOfPages;

    public string Title { get => _title; set => _title = value; }
    public string Author { get => _author; set => _author = value; }

    public int NumberOfPages
    {
        get => _numberOfPages;
        private set
        {
            _numberOfPages = value;
            Value = _numberOfPages * 1.25f;
        }
    }
    public Book() { }
    public Book(string name, 
                string itemId, 
                string title,
                string author,
                int numberOfPages): 
        base(name, itemId)
    {
        _title = title;
        _author = author;
        NumberOfPages = numberOfPages;
    }
}
