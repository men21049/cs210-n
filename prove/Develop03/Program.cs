using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        FileInteraction fileInt = new FileInteraction();
        Scriptures scripture = new Scriptures(fileInt);
        string userInput = string.Empty;

        string header = scripture.getScriptureHeader();
        string textBody = scripture.getScriptureBody();
        string newTextBody = scripture.getNewTextBody(textBody);

        Console.WriteLine($"{header}{textBody}");

        while (userInput != "quit")
        {
            userInput = Console.ReadLine();
            Console.Clear();
            newTextBody = scripture.getNewTextBody(newTextBody);
            Console.WriteLine($"{header}{newTextBody}");
        }

    }
}