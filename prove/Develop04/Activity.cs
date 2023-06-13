using System;


class Activity
{

    private string _activityName = string.Empty;
    private List<string> _activityList;
    private string _description = string.Empty;

    public Activity(string activityName)
    {
        _activityName = activityName;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetActivityList(List<string> activityList)
    {
        _activityList = activityList.ToList();
    }
    public int DisplayMenu()
    {
        ClearConsole();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1.- Start breathing activity");
        Console.WriteLine("   2.- Start reflection activity");
        Console.WriteLine("   3.- Start listing activity");
        Console.WriteLine("   4.- Quit");
        Console.WriteLine("Select a choice from the menu: ");
        int choice = int.Parse(Console.ReadLine());

        return choice;
    }

    public int DisplayWelcomeMessage()
    {
        ClearConsole();
        Console.WriteLine($"Welcome to the {char.ToUpper(_activityName[0])}{_activityName.Substring(1)} Activity");
        Console.WriteLine($"{_description}");
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        return seconds;
    }

    public void DisplayGetReady()
    {
        ClearConsole();
        Console.WriteLine("Get ready...");
    }

    public void ClearConsole()
    {
        Console.Clear();
    }

    public void FinishActivity(int numSecondsToRun, string activityName)
    {
        Console.WriteLine("Well Done!!");
        Console.WriteLine($"Ÿou have completed another {numSecondsToRun} seconds of the {activityName} Activity");
    }

    public string GetActivityName()
    {
        return _activityName;
    }

    public List<string> GetActivityList()
    {
        return _activityList;
    }
}