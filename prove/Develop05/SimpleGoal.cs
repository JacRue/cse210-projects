using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class SimpleGoal : Goal 
{
    
    public override string GetStatus()
    {
        return (CurrentValue == PointValue)? "[X]" : "[ ]";
    }

    public override void RecordEvent()
    {
        CurrentValue = PointValue;
    }

}