using MongoDB.Driver;

namespace dotnettestcd.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
