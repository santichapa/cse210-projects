using System.Diagnostics;
using System.Net;
using Microsoft.VisualBasic;

public class Scripture
{
    private List<Word> Words;
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        Words = TextToList(text);

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
        int index = random.Next(0, Words.Count);
        if (IsCompletelyHidden() == false)
        {
            while (Words[index].GetHiddenStatus())
            {
                index = random.Next(0, Words.Count);
            }
        }
        
        if (Words[index].GetHiddenStatus() == false)
        {
            Words[index].SetHiddenStatus(true);
        }
    }
    public string GetRenderedText() {
        string text = "";
        foreach (Word w in Words)
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
        return Words.All(word => word.GetHiddenStatus());
    }

    // public void DisplayScripture() {
    //     Console.WriteLine($"{_reference} {}");
    // }
} 