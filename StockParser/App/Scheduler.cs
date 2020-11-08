using System;
using System.Threading;

namespace StockParser.App
{
    public static class Scheduler
    {
        private static TimerCallback timerCallback = UpdateStockData;
        private static Timer timer;

        public static void Launch()
        {
            timer = new Timer(timerCallback, null, 0, 2000);
        }
        
        private static void UpdateStockData(object obj)
        {
            
        }
    }
}