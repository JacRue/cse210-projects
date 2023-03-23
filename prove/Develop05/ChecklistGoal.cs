using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class ChecklistGoal : Goal
{
    public int RequiredValue { get; set; }
    public int BonusValue { get; set; }

    public override string GetStatus()
    {
        return $"Completed {CurrentValue}/{RequiredValue} times";
    }

    public override void RecordEvent()
    {
        CurrentValue++;
        if (CurrentValue == RequiredValue)
        {
            PointValue += BonusValue;
            CurrentValue = 0;
            
        }
        else if (CurrentValue > RequiredValue)
        {
            CurrentValue = RequiredValue;
        }
    }
}