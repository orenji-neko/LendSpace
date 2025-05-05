using LendSpace.Data;
using LendSpace.Models;
using LendSpace.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LendSpace.Services
{
    public class ReservationService
    {
        private readonly ApplicationDbContext _context;

        public ReservationService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ReservationModel>> GetAllReservationsAsync()
        {
            return await _context.Reservations
                .Include(r => r.User)
                .Include(r => r.Facility)
                .OrderByDescending(r => r.StartsAt)
                .ToListAsync();
        }

        public async Task<List<ReservationModel>> GetReservationsByUserIdAsync(string userId)
        {
            return await _context.Reservations
                .Include(r => r.Facility)
                .Where(r => r.UserId == userId)
                .OrderByDescending(r => r.StartsAt)
                .ToListAsync();
        }

        public async Task<List<ReservationModel>> GetReservationsByFacilityIdAsync(string facilityId)
        {
            return await _context.Reservations
                .Include(r => r.User)
                .Where(r => r.FacilityId == facilityId)
                .OrderByDescending(r => r.StartsAt)
                .ToListAsync();
        }

        public async Task<ReservationModel> GetReservationByIdAsync(string id)
        {
            return await _context.Reservations
                .Include(r => r.User)
                .Include(r => r.Facility)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<bool> IsFacilityAvailableAsync(string facilityId, DateOnly startDate, DateOnly endDate)
        {
            // Check if there are any overlapping approved reservations
            var overlappingReservations = await _context.Reservations
                .Where(r => r.FacilityId == facilityId &&
                           r.Status == ReservationStatus.Approved &&
                           !(r.EndsAt < startDate || r.StartsAt > endDate))
                .AnyAsync();

            return !overlappingReservations;
        }

        public async Task<string> CreateReservationAsync(ReservationModel reservation)
        {
            // Set a unique ID
            reservation.Id = Guid.NewGuid().ToString();

            // If not specified, set status to Pending
            if (reservation.Status == 0)
            {
                reservation.Status = ReservationStatus.Pending;
            }

            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();

            return reservation.Id;
        }

        public async Task<bool> UpdateReservationStatusAsync(string id, ReservationStatus status)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return false;
            }

            reservation.Status = status;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateReservationAsync(ReservationModel updatedReservation)
        {
            var reservation = await _context.Reservations.FindAsync(updatedReservation.Id);
            if (reservation == null)
            {
                return false;
            }

            // Update properties
            reservation.Title = updatedReservation.Title;
            reservation.Description = updatedReservation.Description;
            reservation.StartsAt = updatedReservation.StartsAt;
            reservation.EndsAt = updatedReservation.EndsAt;
            reservation.Status = updatedReservation.Status;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteReservationAsync(string id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return false;
            }

            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<decimal> CalculateReservationTotalAsync(string facilityId, DateOnly startDate, DateOnly endDate)
        {
            var facility = await _context.Facility.FindAsync(facilityId);
            if (facility == null)
            {
                return 0;
            }

            int days = endDate.DayNumber - startDate.DayNumber;
            return (decimal)facility.Pricing * days;
        }
    }
}