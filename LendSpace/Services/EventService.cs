using LendSpace.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace LendSpace.Services
{
    public class EventService : EventManager
    {
        // You would typically inject a database context or repository here
        // private readonly IEventRepository _repository;

        // For now, we'll use an in-memory list for demonstration
        private readonly List<EventModel> _events = new List<EventModel>();

        public EventService()
        {
            // Constructor logic here
        }

        public async Task<IEnumerable<EventModel>> GetEventsAsync()
        {
            // In a real implementation, you'd query a database
            // return await _repository.GetAllEventsAsync();

            // For now, we'll just return our in-memory list
            return await Task.FromResult(_events);
        }

        public async Task<EventModel> GetEventByIdAsync(string id)
        {
            // In a real implementation, you'd query a database
            // return await _repository.GetEventByIdAsync(id);

            // For now, we'll just search our in-memory list
            var eventModel = _events.FirstOrDefault(e => e.Id == id);
            return await Task.FromResult(eventModel);
        }

        public async Task AddEventAsync(EventModel eventModel)
        {
            // In a real implementation, you'd add to a database
            // await _repository.AddEventAsync(eventModel);

            // For now, we'll just add to our in-memory list
            _events.Add(eventModel);
            await Task.CompletedTask;
        }

        public async Task UpdateEventAsync(EventModel eventModel)
        {
            // In a real implementation, you'd update in a database
            // await _repository.UpdateEventAsync(eventModel);

            // For now, we'll just update our in-memory list
            var existingEvent = _events.FirstOrDefault(e => e.Id == eventModel.Id);
            if (existingEvent != null)
            {
                var index = _events.IndexOf(existingEvent);
                _events[index] = eventModel;
            }
            await Task.CompletedTask;
        }

        public async Task DeleteEventAsync(string id)
        {
            // In a real implementation, you'd delete from a database
            // await _repository.DeleteEventAsync(id);

            // For now, we'll just remove from our in-memory list
            var eventToRemove = _events.FirstOrDefault(e => e.Id == id);
            if (eventToRemove != null)
            {
                _events.Remove(eventToRemove);
            }
            await Task.CompletedTask;
        }
    }
}