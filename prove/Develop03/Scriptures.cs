using System;
using System.Collections.Generic;

class Scriptures
{
    private string scriptureUnformatted = string.Empty;
    private string header = string.Empty;
    private string textBody = string.Empty;
    private string fileSep_1 = " ";

    public Scriptures(FileInteraction fileLine)
    {
        scriptureUnformatted = fileLine.getRandomLine();
    }

    public string getScriptureHeader()
    {
        TextConvert txtConvert = new TextConvert(scriptureUnformatted);
        string[] scriptureSplit = txtConvert.splitWord(fileSep_1);
        string book = scriptureSplit[0];
        string verse = scriptureSplit[1];
        textBody = txtConvert.JoinText(fileSep_1, scriptureSplit, 2);
        header = scriptureSplit[0] + " " + scriptureSplit[1] + " : ";

        return string.Format($"{header}");
    }

    public string getScriptureBody()
    {
        return textBody;
    }

    public string getNewTextBody(string stringToChange)
    {
        TextConvert txtConvert = new TextConvert(stringToChange);
        string[] newText = txtConvert.replaceText(stringToChange);
        string result = txtConvert.JoinText(fileSep_1, newText, 0);
        return result;
    }


}