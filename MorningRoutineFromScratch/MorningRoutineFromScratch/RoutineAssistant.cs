namespace MorningRoutineFromScratch;

public class RoutineActivity
{
    public string Activity;
    private TimeOnly StartTime;
    private TimeOnly EndTime;

    public RoutineActivity(string activity, TimeOnly startTime, TimeOnly endTime)
    {
        Activity = activity;
        StartTime = startTime;
        EndTime = endTime;
    }

    public bool IsTimeForActivity(TimeOnly time)
    {
        return time >= StartTime && time <= EndTime;
    }
}

public class RoutineAssistant
{
    private TimeOnly currentTime;
    private List<RoutineActivity> routines = new List<RoutineActivity>();

    public void AddRoutine(string activity, TimeOnly startTime, TimeOnly endTime)
    {
        routines.Add(new RoutineActivity(activity, startTime, endTime));
    }
    
    public void CurrentHour(int hour, int minute)
    {
        currentTime = new TimeOnly(hour, minute);
    }

    public string WhatShouldIDo()
    {
        foreach (var routine in routines.Where(routine => routine.IsTimeForActivity(currentTime)))
        {
            return routine.Activity;
        }

        return "Do nothing";
    }
}