namespace Downtime.Data
{
    public interface IRequestRepository
    {
        NotificationRequest GetRequest(int id);
    }
}
