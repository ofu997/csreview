using System;
using System.Collections.Generic;

namespace CSharpIntermediate 
{
  //   Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
  // provide two methods: Start and Stop. We call the start method first, and the stop method next.
  // Then we ask the stopwatch about the duration between start and stop. Duration should be a
  // value in TimeSpan. Display the duration on the console.
  // We should also be able to use a stopwatch multiple times. So we may start and stop it and then
  // start and stop it again. Make sure the duration value each time is calculated properly.
  // We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
  // start time). So the class should throw an InvalidOperationException if its started twice.
  // 1
  // Educational tip: The aim of this exercise is to make you understand that a class should be
  // always in a valid state. We use encapsulation and information hiding to achieve that. The class
  // should not reveal its implementation detail. It only reveals a little bit, like a blackbox. From the
  // outside, you should not be able to misuse a class because you shouldn’t be able to see the
  // implementation detail. 
  public class Stopwatch
  {
    private DateTime _start { get; set;}
    private DateTime _stop { get; set; }

    private int _timespan { get; set; }
    // private int _timespan 
    // { 
    //   get {
    //     var timespan = _stop - _start; 
    //     var seconds = timespan.Seconds; 
    //     return seconds;
    //   }
    // }


    private bool _hasStarted { get; set; }

    private bool _hasStopped { get; set; }

    public Stopwatch()
    {
      _hasStopped = false; 
    }

    public void Start()
    {
      if (_hasStarted == true) 
      {
        System.Console.WriteLine("Stopwatch can't be restarted.");
        return;
      }
        _start = DateTime.Now;
        _hasStarted = true;
    }

    public void Stop()
    {
      _stop = DateTime.Now;
      _hasStopped = false;
        var timespan = _stop - _start; 
        var seconds = timespan.Seconds; 
        System.Console.WriteLine("{0} seconds", seconds);
    }

    public static void makeStopwatch()
    {
      var myStopwatch = new Stopwatch();
      bool run = true;
      while (run)
      {
        System.Console.WriteLine("type 'start'to start or 'stop' to stop.");
        string answer = Console.ReadLine();
        if (answer == "start")
        {
          myStopwatch.Start();
        }
        if (answer == "stop")
        {
          myStopwatch.Stop();
          run = false;
        }
      }
    }
  }
}