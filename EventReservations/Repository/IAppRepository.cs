namespace EventReservations.Repository
{
    interface IAppRepository
    {
        IEventEntityRepository EventEntityRepository { get; }
    }
}
