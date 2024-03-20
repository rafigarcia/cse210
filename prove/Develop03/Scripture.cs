using System;

class Scripture 
{
    private Reference _reference;
    
    private List<Word> _words = new List<Word>();
    


    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        List<string> wordsList = text.Split(" ").ToList();
        foreach (string word in wordsList)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords (int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            if (IsCompletelyHidden())
            {
                break;
            }
            int radomIndex = random.Next(0, _words.Count);
            if (_words[radomIndex].isHidden())
            {
                i--;
                continue;
            }
            else {
                _words[radomIndex].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return text;
    }
     
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }

    public int getScriptureLength()
    {
        return _words.Count;
    }
}