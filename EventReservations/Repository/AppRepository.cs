namespace EventReservations.Repository
{
    public class AppRepository : IAppRepository
    {
        private readonly IEventEntityRepository _eventEntityRepository;

        public AppRepository(IEventEntityRepository eventEntityRepository)
        {
            _eventEntityRepository = eventEntityRepository;
        }

        public IEventEntityRepository EventEntityRepository => _eventEntityRepository;
    }
}
