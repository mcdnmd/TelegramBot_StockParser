using System.Collections.Generic;

namespace StockParser.Infrastructure
{
    public interface IDataBase
    {
        string host { get; }
        string userName { get; }
        string password { get; }
        void InitializationСonnection();
        void CloeConnection();
        void AddUser(string userId);
        void RemoveUser(string userId);
        void SelectUser(string userId);
        Dictionary<string, string> GetUserInfo(string userId);
        List<Dictionary<string, string>> GetUsersWhere(); //Здесь будут перечислены все столбцы базы и они будут иметь стандартное значение
                                                            //Например ( id = ""; token = "" и тд)
    }
}