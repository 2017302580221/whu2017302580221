﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Alarm alarm = new Alarm("Test");
            alarm.Timing += TimeOut;
            alarm.DoTiming(0, 0, 60);
        }

        static void TimeOut(object sender, String message)
        {
            Alarm that = (Alarm)sender;
            Console.WriteLine("已经过了" + that.Duration + " ；备注：" + message);
        }
    }

    public delegate void AlarmTimer(object sender, String message);

    public class Alarm
    {
        private TimeSpan duration;
        private String message;

        public String Duration { get => duration.ToString(); }

        public event AlarmTimer Timing;

        public Alarm(String message = "")
        {
            this.message = message;
        }

        public void DoTiming(int hours, int minutes, int seconds)
        {
            duration = new TimeSpan(hours, minutes, seconds);
            DateTime start = DateTime.Now;
            while (GetDuration(start).CompareTo(duration) < 0)
            {
            }
            if (Timing != null)
            {
                Timing(this, message);
            }
        }

        private TimeSpan GetDuration(DateTime start)
        {
            TimeSpan begin = new TimeSpan(start.Ticks);
            TimeSpan now = new TimeSpan(DateTime.Now.Ticks);
            return now.Subtract(begin);
        }
    }
}