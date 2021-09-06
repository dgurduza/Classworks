using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void Print(string line);

class Logger
{
    List<LogPair> list = new List<LogPair>();

    public void OutputLogs()
    {
        foreach (LogPair str in list)
        {
            str.Method?.Invoke(str.Log);
        }
    }

    public void MakeLog(Print method, string line)
    {
        LogPair log = new LogPair(method, line);
        list.Add(log);
    }
}

