using System;

class BreathingActivity : Activity
{
    public BreathingActivity(string activityName) : base(activityName)
    {
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        SetActivityList(new List<string> { "Breath in", "Now breath out" });
    }

}