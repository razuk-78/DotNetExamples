using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


    class MyScheduler:IDisposable
    {
    List<Task> _tasks = new List<Task>();
    CancellationTokenSource cs = new CancellationTokenSource();
    Task _task;
    int _taskNumber =0;
    public MyScheduler(int taskNumber)
    {
        _taskNumber = taskNumber;
       
       
    }
    public void addToQueue(Action action)
    {
        _tasks.Add(new Task(action,cs.Token));
        if (_tasks.Count < _taskNumber&& _tasks.Count>0)
        {
            _tasks[_tasks.Count - 1].Start();
        }

    }
     void RunTask(Task tsk)
    {
        Console.WriteLine("form RunTask");
    }
    void RemoveTaskWhenCompleted()
    {
       
    }
    public int GetTaskNumber()
    {
        return _tasks.Count;
    }

    public void Dispose()
    {
        cs.Cancel();
        _task = null;
    }
    void RemoveTaskFromList()
    {
        _task = Task.Run(() =>
        {
            while (true)
            {
                if (_tasks.Count > 0)
                {
                    _tasks.Remove(Task.WhenAny(_task));
                }
                cs.Token.ThrowIfCancellationRequested();
            }
        },cs.Token);
    }
    
    }

