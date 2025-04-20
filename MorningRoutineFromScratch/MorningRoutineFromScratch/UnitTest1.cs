namespace MorningRoutineFromScratch;

public class Tests
{
    [Test]
    public void DoExerciseBetween6And7()
    {
        RoutineAssistant sut = new RoutineAssistant();

        sut.CurrentHour(6,30);
        
        Assert.AreEqual(sut.WhatShouldIDo(), "Do exercise");
    }

    [Test]
    public void StudyBetween7And8()
    {
        RoutineAssistant sut = new RoutineAssistant();

        sut.CurrentHour(7,30);
        
        Assert.AreEqual(sut.WhatShouldIDo(), "Read and study");
    }
}