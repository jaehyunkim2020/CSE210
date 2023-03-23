using System;
using System.Collections.Generic;
using System.IO;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = false;
    }

    public override void RecordEvent()
    {
        _completed = true;
    }

    public override string ToString()
    {
        return $"[{(_completed ? "X" : " ")}] {_name} ({_description})";
    }
}