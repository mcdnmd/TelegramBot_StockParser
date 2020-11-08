using System;
using StockParser.App.BotTask;

namespace StockParser.App
{
    public static class BotLogic
    {
        public static void ExecuteTask(IBotTask task)
        {
            var userId = task.UserApi;
            var type = task.Type;
            switch (type)
            {
                case BotTask.BotTask.AddSymbol:
                    break;
                case BotTask.BotTask.RemoveSymbol:
                    break;
                case BotTask.BotTask.GetSymbolInfo:
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}