namespace MorningRoutineFromScratch;

public class RoutineAssistant
{
    private TimeOnly currentTime;
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
        return "";
    }
}