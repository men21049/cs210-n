using System;
using System.Collections.Generic;

class FileInteraction
{
    private string filename = "Scriptures.txt";
    private List<string> lineList = new List<string>();
    public FileInteraction()
    {

    }

    public void FileAppend(string text)
    {
        using (StreamWriter outputFile = File.AppendText(filename))
        {
            outputFile.WriteLine(text);
        }
    }

    public List<string> getFileLines()
    {

        using (StreamReader _sr = File.OpenText(filename))
        {
            string _s = "";
            while ((_s = _sr.ReadLine()) != null)
            {
                lineList.Add(_s);
            }
        }
        return lineList;
    }

    public string getRandomLine()
    {
        Random rnd = new Random();
        getFileLines();
        string randomText = lineList[rnd.Next(0, lineList.Count() - 1)];
        return randomText;
    }

}