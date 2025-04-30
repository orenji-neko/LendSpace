using LendSpace.Data;
using LendSpace.Models;

using Microsoft.EntityFrameworkCore;

namespace LendSpace.Services
{
    public class ReservationManager
    {
        private readonly ApplicationDbContext _context;

        public ReservationManager(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ReservationModel> GetReservationsList()
        {
            var reservations = _context.Reservations.ToList();
            return reservations;
        }

        public ReservationModel? GetReservation(string id)
        {
            var reservation = _context.Reservations.FirstOrDefault(b => b.Id!.Equals(id));
            return reservation;
        }

        public async Task AddReservation(ReservationModel booking)
        {
            await _context.Reservations.AddAsync(booking);
            await _context.SaveChangesAsync();
        }

        public async Task EditReservation(ReservationModel reservation)
        {
            var local = _context.Reservations.Local.FirstOrDefault(fb => fb.Id!.Equals(reservation.Id));
            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached; 
            }

            _context.Reservations.Update(reservation);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteReservation(ReservationModel reservation)
        {
            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
        }
    }
}
