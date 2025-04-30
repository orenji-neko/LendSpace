using LendSpace.Data;
using LendSpace.Models;

using Microsoft.EntityFrameworkCore;

namespace LendSpace.Services
{
    public class BookingManager
    {
        private readonly ApplicationDbContext _context;

        public BookingManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<FacilityBookingModel> GetFacilityBookingsList()
        {
            var bookings = _context.FacilityBookings.ToList();
            return bookings;
        }

        public FacilityBookingModel? GetFacilityBooking(string id)
        {
            var booking = _context.FacilityBookings.FirstOrDefault(b => b.Id!.Equals(id));
            return booking;
        }

        public async Task AddFacilityBooking(FacilityBookingModel booking)
        {
            await _context.FacilityBookings.AddAsync(booking);
            await _context.SaveChangesAsync();
        }

        public async Task EditFacilityBooking(FacilityBookingModel booking)
        {
            var local = _context.FacilityBookings.Local.FirstOrDefault(fb => fb.Id!.Equals(booking.Id));
            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached; 
            }

            _context.FacilityBookings.Update(booking);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFacilityBooking(FacilityBookingModel booking)
        {
            _context.FacilityBookings.Remove(booking);
            await _context.SaveChangesAsync();
        }
    }
}
