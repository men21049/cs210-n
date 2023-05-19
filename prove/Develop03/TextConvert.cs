using System;
using System.Collections.Generic;

class TextConvert
{
    private string _newText = string.Empty;
    private string[] _text = new string[] { };
    private string[] newTextBody = new string[] { };
    public TextConvert(string text)
    {
        _newText = text;
    }

    public string[] splitWord(string SplitVar)
    {
        _text = _newText.Split($"{SplitVar}");
        return _text;
    }

    public string[] replaceText(string textBody)
    {
        int rnd = new Random().Next(2, 4);
        int wordsRemoved = 0;
        newTextBody = textBody.Split(" ");

        while (rnd != wordsRemoved)
        {
            int randomIdx = new Random().Next(0, newTextBody.Length);
            if (!newTextBody[randomIdx].Contains('_'))
            {
                newTextBody[randomIdx] = new string('_', newTextBody[randomIdx].Count());
            }

            wordsRemoved++;
        }
        return newTextBody;
    }

    public string JoinText(string sep, string[] sepText, int initial)
    {
        string joinText = string.Join(sep, sepText, initial, sepText.Count() - initial);
        return joinText;
    }

}
