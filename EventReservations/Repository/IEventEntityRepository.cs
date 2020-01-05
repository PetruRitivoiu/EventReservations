using EventReservations.Entities;
using System.Collections.Generic;

namespace EventReservations.Repository
{
    public interface IEventEntityRepository
    {
        IEnumerable<EventEntity> GetAll();

        EventEntity Find(int id);

        void Add(EventEntity eventEntity);

        void Update(EventEntity eventEntity);

        void Remove(EventEntity eventEntity);
    }
}
