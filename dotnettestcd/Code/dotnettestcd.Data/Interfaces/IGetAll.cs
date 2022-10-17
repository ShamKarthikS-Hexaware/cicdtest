using System.Collections.Generic;

namespace dotnettestcd.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
