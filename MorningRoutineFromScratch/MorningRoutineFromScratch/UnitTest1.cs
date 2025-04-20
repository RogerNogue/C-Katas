namespace MorningRoutineFromScratch;

public class Tests
{
    [Test]
    public void DoExerciseBetween6And7()
    {
        RoutineAssistant sut = new RoutineAssistant();

        sut.CurrentHour(6,30);
        sut.AddRoutine("Do exercise", new TimeOnly(6, 0), new TimeOnly(6, 59));
        
        Assert.AreEqual(sut.WhatShouldIDo(), "Do exercise");
    }

    [Test]
    public void StudyBetween7And8()
    {
        RoutineAssistant sut = new RoutineAssistant();

        sut.CurrentHour(7,30);
        sut.AddRoutine("Read and study", new TimeOnly(7, 0), new TimeOnly(7, 59));
        
        Assert.AreEqual(sut.WhatShouldIDo(), "Read and study");
    }

    [Test]
    public void BreakfastBetween8And9()
    {
        RoutineAssistant sut = new RoutineAssistant();

        sut.CurrentHour(8,30);
        sut.AddRoutine("Have breakfast", new TimeOnly(8, 0), new TimeOnly(8, 59));
        
        Assert.AreEqual(sut.WhatShouldIDo(), "Have breakfast");
    }
    
    [Test]
    public void NoActivityAtOtherTimes()
    {
        RoutineAssistant sut = new RoutineAssistant();

        sut.CurrentHour(9,30);
        
        Assert.AreEqual(sut.WhatShouldIDo(), "Do nothing");
    }

    [Test]
    public void TakeAShowerInFullDayOfRoutines()
    {
        RoutineAssistant sut = new RoutineAssistant();

        sut.CurrentHour(6,45);
        sut.AddRoutine("Do exercise", new TimeOnly(6, 0), new TimeOnly(6, 44));
        sut.AddRoutine("Take a shower", new TimeOnly(6, 45), new TimeOnly(6, 59));
        sut.AddRoutine("Read", new TimeOnly(7, 0), new TimeOnly(7, 59));
        
        Assert.AreEqual(sut.WhatShouldIDo(), "Take a shower");
    }
}