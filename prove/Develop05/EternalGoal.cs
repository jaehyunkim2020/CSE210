using System;
using System.Collections.Generic;
using System.IO;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = false;
    }

    public override void RecordEvent()
    {
        
    }

    public override string ToString()
    {
        return $"[] {_name} ({_description})";
    }
}