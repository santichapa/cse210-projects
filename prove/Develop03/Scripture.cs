using System.Diagnostics;
using System.Net;
using Microsoft.VisualBasic;

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = TextToList(text);

    }

    private List<Word> TextToList(string text) {
        string[] words = text.Split(" ");
        List<Word> newList = new();
        
        foreach (string word in words)
        {
            Word newWord = new(word);
            newList.Add(newWord);
        }
        return newList;
    }
    public void HideWords() {
        Random random = new();
        int index = random.Next(0, _words.Count);
        if (IsCompletelyHidden() == false)
        {
            while (_words[index].GetHiddenStatus())
            {
                index = random.Next(0, _words.Count);
            }
        }
        
        if (_words[index].GetHiddenStatus() == false)
        {
            _words[index].SetHiddenStatus(true);
        }
    }
    public string GetRenderedText() {
        string text = "";
        foreach (Word w in _words)
        {
            if (w.GetHiddenStatus())
            {
                text = $"{text} {w.HideWord()}";
            }
            else if (w.GetHiddenStatus() == false)
            {
                text = $"{text} {w.GetWordText()}";
            }
            
        }
        return $"{text}";
    }
    public bool IsCompletelyHidden() {
        return _words.All(word => word.GetHiddenStatus());
    }

    // public void DisplayScripture() {
    //     Console.WriteLine($"{_reference} {}");
    // }
} 