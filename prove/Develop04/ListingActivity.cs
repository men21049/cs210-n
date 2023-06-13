using System;

class ListingActivity : Activity
{
    List<string> _listingList = new List<string>();
    public ListingActivity(string activityName) : base(activityName)
    {
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        SetActivityList(new List<string> {"Who are people that you appreciate?"
                                                  ,"What are personal strengths of yours?"
                                                  ,"Who are people that you have helped this week?"
                                                  ,"When have you felt the Holy Ghost this month?"
                                                  ,"Who are some of your personal heroes?"});
    }

    public void DisplayActivity()
    {

        Random random = new Random();
        int index = random.Next(GetActivityList().Count);
        Console.WriteLine("List as many reponses you can to the following prompt");
        Console.WriteLine($"---- {GetActivityList()[index]} ----");
    }

    public void SetListingList(List<string> ll)
    {
        _listingList = ll;
    }

    public int GetListingListCount()
    {
        return _listingList.Count;
    }

    public void DisplayTotalListingCount()
    {
        Console.WriteLine($"You listed {GetListingListCount()} items");
    }
}