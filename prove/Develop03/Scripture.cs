using System;
using System.Collections.Generic;

public class Scripture
{
    //Store the scripture reference, words as objects and a 
    // random for choosing words to dissapear
    private Reference _reference;
    private List<Word> _words;
    private Random _random;





    //recieves both a formatted referance and the scripture's text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>(); //create emoty list of word objects
        _random = new Random(); // create the random object

        //Make an array of individual words 
        string[] separateWords = text.Split(" ");

        
        
        //go through each word in the array 
        foreach (string wordText in separateWords)
        {
            //make word objects and add each to my list
            Word word = new Word(wordText); 
            _words.Add(word);
        }
    }







    //Go through my words and hides 3 NEW words
    public void HideWords()
    {
        int wordsHidden = 0; //track how many are hidden

        while (wordsHidden < 3 && !IsCompletelyHidden())//stop if all words are invisible
        {
            int randomNumber = _random.Next(_words.Count); //pick a random one from the list

            if (!_words[randomNumber].IsHidden()) //only hide it if its not already hidden
            {
                _words[randomNumber].Hide();
                wordsHidden++;
            }
        }
    }


    //Check to see if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words) //look at each word
        {
            if (!word.IsHidden()) //any word visible means script continues
            {
                return false;
            }
        }

        return true;
    }



    //create the text for the console
    public string GetDisplayText()
    {
        //show the reference first
        string displayText = _reference.GetReferenceText() + "\n";

        //add each word with a space between each like a normal sentence
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText;
    }
}