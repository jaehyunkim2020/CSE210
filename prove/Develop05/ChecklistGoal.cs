using System;
using System.Collections.Generic;
using System.IO;

class ChecklistGoal : Goal
{
    public int _goalCount { get; private set; }
    public int _completedCount { get; private set; }
    public int _bonus { get; private set; }

    public ChecklistGoal(string name, string description, int points, int goalCount, int bonus)
    {
        _name = name;
        _description = description;
        _points = points;
        _goalCount = goalCount;
        _bonus = bonus;
        _completedCount = 0;
        _completed = false;
    }

    public override void RecordEvent()
    {
        _completedCount++;
        if (_completedCount >= _goalCount)
        {
            _completed = true;
        }
    }

    public override string ToString()
    {
        return $"[{(_completed ? "X" : " ")}] {_name} ({_description}) - Currently completed: {_completedCount}/{_goalCount}";
    }
}