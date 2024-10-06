using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordsArray = text.Split(' ');
        foreach (string wordText in wordsArray)
        {
            _words.Add(new Word(wordText));
        }
    }
    public void HideRandomWords()
    {
        Random random = new Random();
        int numberOfWordsToHide = 3;

        for (int i = 0; i < numberOfWordsToHide; i++)
        {
            int indexToHide = random.Next(_words.Count);
            if (!_words[indexToHide].IsHidden())
            {
                _words[indexToHide].Hide();
            }
        }
    }
    public string GetDisplayText()
    {
        List<String> displayedWords = new List<string>();

        foreach (Word word in _words)
        {
            displayedWords.Add(word.GetDisplayText());
        }

        return string.Join(" ", displayedWords);
    }
    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden()) return false;
        }
        return true;
    }

}