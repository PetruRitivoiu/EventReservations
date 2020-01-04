using System.Threading.Tasks;

namespace EventReservations.Data
{
    public interface IDbInitializer
    {
        Task Initialize();
    }
}
