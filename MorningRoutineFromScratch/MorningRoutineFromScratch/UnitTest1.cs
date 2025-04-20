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
        
        Assert.AreEqual(sut.WhatShouldIDo(), "Read and study");
    }

    [Test]
    public void BreakfastBetween8And9()
    {
        RoutineAssistant sut = new RoutineAssistant();

        sut.CurrentHour(8,30);
        
        Assert.AreEqual(sut.WhatShouldIDo(), "Have breakfast");
    }
    
    [Test]
    public void NoActivityAtOtherTimes()
    {
        RoutineAssistant sut = new RoutineAssistant();

        sut.CurrentHour(9,30);
        
        Assert.AreEqual(sut.WhatShouldIDo(), "Do nothing");
    }
}