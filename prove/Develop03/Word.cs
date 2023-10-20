public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public string HideWord() {
        int len = _word.Length;
        string hiddenWord = new('_', len);
        return hiddenWord;
    }
    // public void ShowWord() {
    //     _isHidden = false;
    // }

    public Word GetWord() {
        Word newWord = new(_word);
        return newWord;
    }
    public string GetWordText() {
        return _word;
    }
    public bool GetHiddenStatus() {
        return _isHidden;
    }
    public void SetHiddenStatus(bool status) {
        _isHidden = status;
    }
//     public void SetWord(string word) {
//         _word = word;
//     }
}