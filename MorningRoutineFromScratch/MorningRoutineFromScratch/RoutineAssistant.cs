namespace MorningRoutineFromScratch;

public class RoutineActivity
{
    private string Activity;
    private TimeOnly StartTime;
    private TimeOnly EndTime;

    public RoutineActivity(string activity, TimeOnly startTime, TimeOnly endTime)
    {
        Activity = activity;
        StartTime = startTime;
        EndTime = endTime;
    }
}

public class RoutineAssistant
{
    private TimeOnly currentTime;
    private List<RoutineActivity> routines = new List<RoutineActivity>();

    public void CurrentHour(int hour, int minute)
    {
        currentTime = new TimeOnly(hour, minute);
    }

    public string WhatShouldIDo()
    {
        if (currentTime.Hour == 6)
            return "Do exercise";
        if (currentTime.Hour == 7)
            return "Read and study";
        if (currentTime.Hour == 8)
            return "Have breakfast";
        return "Do nothing";
    }
}