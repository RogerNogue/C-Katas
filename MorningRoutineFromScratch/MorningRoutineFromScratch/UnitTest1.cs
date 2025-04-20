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
}