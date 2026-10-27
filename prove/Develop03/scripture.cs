//  what scripture I will do is: D&C 3:3 "remeber"

public class Scripture
{
    private List<Word> _words;

    private Reference _reference;

    public Scripture (Reference reference , List<Word> words)
    {
        _reference = reference;
        _words = words;
    }

    public string GetDisplayText()
    {
        string scriptureText = "";

        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return _reference.GetDisplayText() + " " + scriptureText.TrimEnd();
    }

    public void HideRandomWords()
    {
        Random random = new Random();

        for (int i = 0; i < 3; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

   public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}