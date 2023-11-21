using Domain.Entities;

namespace Domain.Ports
{
    internal interface IGuestRepository
    {
        Task<Guest> Get(int id);
        Task<int> Save(Guest guest);
    }
}
