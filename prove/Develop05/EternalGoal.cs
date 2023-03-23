using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class EternalGoal : Goal
{
    public override string GetStatus()
    {
        return $"Completed {CurrentValue} times";
    }

    public override void RecordEvent()
    {
        CurrentValue++;
    }
}