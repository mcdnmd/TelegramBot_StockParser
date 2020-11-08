using System;
using System.Threading;
using StockParser.App;

namespace StockParser
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Scheduler.LaunchScheduler();
        }
    }
}