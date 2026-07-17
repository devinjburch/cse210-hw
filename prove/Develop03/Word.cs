public class Word
{
    private string _text; //stores the word
    private bool _isHidden; //store if the word is hidden







    //this constructor recieves one word
    public Word(string text)
    {
        _text = text;
        _isHidden = false; //each word starts of visible
    }







    //This hides the word
    public void Hide()
    {
        _isHidden = true;
    }






     // This method tells the Scripture clas if the word is hidden.
    public bool IsHidden()
    {
        return _isHidden;
    }




    //Decide if a word should dissapear
    public string GetDisplayText()
    {
        if (_isHidden) //If a word is hidden, replace the letters with ___
        {
            string hiddenWord = "";

            for (int i = 0; i < _text.Length; i++)
            {
                hiddenWord += "_";
            }

            return hiddenWord;
        }
        else //if the word isnt hidden just show the word
        {
            return _text;
        }
    }
}