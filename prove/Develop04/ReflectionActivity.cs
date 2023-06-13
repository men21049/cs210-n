using System;
using System.Collections.Generic;
using static System.Linq.Enumerable;

class ReflectionActivity : Activity
{
    private int _numberOfSecondsTothink;
    List<string> _QuestionList = new List<string>{"Why was this experience meaningful to you?"
                                                ,"Have you ever done anything like this before?"
                                                ,"How did you get started?"
                                                ,"How did you feel when it was complete?"
                                                ,"What made this time different than other times when you were not as successful?"
                                                ,"What is your favorite thing about this experience?"
                                                ,"What could you learn from this experience that applies to other situations?"
                                                ,"What did you learn about yourself through this experience?"
                                                ,"How can you keep this experience in mind in the future?"};
    public ReflectionActivity(string activityName) : base(activityName)
    {
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        SetActivityList(new List<string> { "Think of a time when you stood up for someone else."
                                                ,"Think of a time when you did something really difficult."
                                                ,"Think of a time when you helped someone in need."
                                                ,"Think of a time when you did something truly selfless."});
    }

    public void SetNumberOfSecondsToThink(int numSecondsToRun)
    {
        _numberOfSecondsTothink = numSecondsToRun / 5;
    }

    public int GetNumberOfSecondsToThink()
    {
        return _numberOfSecondsTothink;
    }
    public List<string> GetQuestionList()
    {
        return _QuestionList;
    }

    public void GetRandomReflectionActivity()
    {
        Random random = new Random();
        int index = random.Next(GetActivityList().Count);
        Console.WriteLine("Consider the following prompt:");
        Thread.Sleep(200);
        Console.WriteLine($"---{GetActivityList()[index]}---");
        Thread.Sleep(500);
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Thread.Sleep(200);
    }

    public List<string> GetRandomReflectionQuestionActivity()
    {
        int numberOfIndexes = _numberOfSecondsTothink;
        Random random = new Random();
        List<string> list = new List<string>();
        foreach (int i in Range(1, _QuestionList.Count))
        {
            int index = random.Next(_QuestionList.Count);
            if (!list.Contains(_QuestionList[index]) & list.Count <= numberOfIndexes)
            {
                list.Add(_QuestionList[index]);
            }

        }
        return list;
    }

}