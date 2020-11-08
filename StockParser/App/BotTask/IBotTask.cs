using System.Collections.Generic;

namespace StockParser.App.BotTask
{
    public interface IBotTask
    {
        string UserApi { get; }
        BotTask Type { get; }
        Dictionary<string, string> Parameters { get; }
    }

    /*
     * Typical IBotTask
     *
     *     telegram-48489-chat-api-4324
     *     AddSymbol
     *     {"symbol": "APPL"}
     *    
     *     telegram-48489-chat-api-4324
     *     RemoveSymbol
     *     {"symbol": "APPL"}
     *
     *     telegram-48489-chat-api-4324
     *     GetSymbolInfo
     *     {"symbol": "APPL",
     *      "time": Last15Minutes}
     *
     * 
     */
}