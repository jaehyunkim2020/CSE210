using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    public string _name { get; protected set; }
    public string _description { get; protected set; }
    public int _points { get; protected set; }
    public bool _completed { get; protected set; }

    public abstract void RecordEvent();
    public abstract override string ToString();
}