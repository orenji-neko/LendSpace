using System.Collections.Generic;
using System.Threading.Tasks;
using LendSpace.Models;

namespace LendSpace.Services
{
    public interface IEventService
    {
        Task<IEnumerable<EventModel>> GetEventsAsync();
        Task<EventModel> GetEventByIdAsync(string id);
        Task AddEventAsync(EventModel eventModel);
        Task UpdateEventAsync(EventModel eventModel);
        Task DeleteEventAsync(string id);
    }
}