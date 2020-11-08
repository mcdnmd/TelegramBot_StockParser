using System.Collections.Generic;
using StockParser.App.BotTask;

namespace StockParser.App
{
    public static class BotTaskQueue
    {
        private static readonly Queue<IBotTask> TaskQueue = new Queue<IBotTask>();

        public static IBotTask GetTask()
        {
            return TaskQueue.Dequeue();
        }

        public static void AddTask(IBotTask task)
        {
            TaskQueue.Enqueue(task);
        }
    }
}