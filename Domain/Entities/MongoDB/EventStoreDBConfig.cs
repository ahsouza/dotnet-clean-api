namespace Domain.Entities.MongoDB
{
  public class EventStoreDBConfig : IEventStoreDBConfig
  {
    public string EventsCollectionName { get; set; }
    public string ConnectionString { get; set; }
    public string DatabaseName { get; set; }
  }

  public interface IEventStoreDBConfig
  {
    string EventsCollectionName { get; set; }
    string ConnectionString { get; set; }
    string DatabaseName { get; set; }
  }
}