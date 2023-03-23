using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


// Base class to contain any shared attributes or behaviors for different goals.
public abstract class Goal
{
    public string Name { get; set; }
    public int PointValue { get; set; }
    public int CurrentValue { get; set; }

    public abstract string GetStatus();
    
    public abstract void RecordEvent();
}

