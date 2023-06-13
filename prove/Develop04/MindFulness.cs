using System;


class MindFulness
{
    WaitingDisplay _display = new WaitingDisplay();
    public MindFulness()
    {

        Activity newAct = new Activity("Initial Activity");
        SetActivity(newAct.DisplayMenu());
    }

    public void SetActivity(int choice)
    {
        if (choice == 1)
        {
            BreathingActivity breath = new BreathingActivity("Breathing");
            int numSecondsToRun = breath.DisplayWelcomeMessage();
            breath.DisplayGetReady();
            _display.DisplaySpinner(3);
            _display.DisplayCountDown(4, numSecondsToRun, breath.GetActivityList());
            breath.FinishActivity(numSecondsToRun, breath.GetActivityName());
            _display.DisplaySpinner(5);
            SetActivity(breath.DisplayMenu());
        }
        else if (choice == 2)
        {
            ReflectionActivity reflect = new ReflectionActivity("Reflection");
            int numSecondsToRun = reflect.DisplayWelcomeMessage();
            reflect.SetNumberOfSecondsToThink(numSecondsToRun);
            reflect.DisplayGetReady();
            _display.DisplaySpinner(3);
            reflect.GetRandomReflectionActivity();
            _display.DisplayCountDown(4, numSecondsToRun, null, "You may begin in ");
            _display.DisplaySpinnerWithText(reflect.GetRandomReflectionQuestionActivity(), reflect.GetNumberOfSecondsToThink());
            reflect.FinishActivity(numSecondsToRun, reflect.GetActivityName());
            _display.DisplaySpinner(5);
            SetActivity(reflect.DisplayMenu());
        }
        else if (choice == 3)
        {
            ListingActivity listing = new ListingActivity("Listing");
            int numSecondsToRun = listing.DisplayWelcomeMessage();
            listing.DisplayGetReady();
            _display.DisplaySpinner(3);
            listing.DisplayActivity();
            _display.DisplayCountDown(4, numSecondsToRun, null, "You may begin in ");
            listing.SetListingList(_display.GetMultipleLinesWithTimer(numSecondsToRun));
            listing.DisplayTotalListingCount();
            listing.FinishActivity(numSecondsToRun, listing.GetActivityName());
            _display.DisplaySpinner(5);
            SetActivity(listing.DisplayMenu());

        }
        else
        {
            Environment.Exit(0);
        }
    }
}