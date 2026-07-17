public class Reference
{
    //these can only be accessed in this class
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;





    // Constructor for one verse reference
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }





    // Constructor for a range of verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }





    //This returns my reference as a string
    public string GetReferenceText()
    {
        //if the start and end are the same its one verse
        //return the single verse formatted right
        if (_startVerse == _endVerse)
        {
            return _book + " " + _chapter + ": " + _startVerse;
        }
        //return the multi-verse formated like a range
        else
        {
            return _book + " " + _chapter + ": " +
                   _startVerse + " - " + _endVerse;
        }
    }
}   