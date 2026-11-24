using System.Text.RegularExpressions;
using Doctor_Resrvation_System.Data;
using Doctor_Resrvation_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Doctor_Resrvation_System.Controllers
{
    public class AppointmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppointmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int doctorId)
        {
            var doctor = await _context.Doctors
                .Include(d => d.Appointments)
                .FirstOrDefaultAsync(d => d.Id == doctorId);

            if (doctor == null)
                return NotFound();

            return View(doctor);
        }

        [HttpGet]
        public async Task<IActionResult> Book(int appointmentId)
        {
            var appointment = await _context.Appointments
                .Include(a => a.Doctor)
                .FirstOrDefaultAsync(a => a.Id == appointmentId);

            if (appointment == null)
                return NotFound();

            return View(appointment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Book(int appointmentId, string name, string phone, string nationalId)
        {
            var appointment = await _context.Appointments
                .Include(a => a.Doctor)
                .FirstOrDefaultAsync(a => a.Id == appointmentId);

            if (appointment == null)
                return NotFound();

            string? error = null;
            if (string.IsNullOrWhiteSpace(name))
                error = "Please enter your name.";
            else if (!Regex.IsMatch(phone ?? "", @"^01\d{9}$"))
                error = "Phone must be 11 digits and start with 01.";
            else if (!Regex.IsMatch(nationalId ?? "", @"^\d{14}$"))
                error = "National ID must be exactly 14 digits.";

            if (error != null)
            {
                ViewBag.Error = error;
                ViewBag.Name = name;
                ViewBag.Phone = phone;
                ViewBag.NationalId = nationalId;
                return View(appointment);
            }

            var user = await _context.Users.FirstOrDefaultAsync(u => u.NationalId == nationalId);
            if (user == null)
            {
                user = new User { Name = name, Phone = phone, NationalId = nationalId };
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
            }

            var booking = new Booking { UserId = user.Id, AppointmentId = appointment.Id };
            _context.Bookings.Add(booking);
            await _context.SaveChangesAsync();

            TempData["Success"] = "Booking saved successfully!";
            return RedirectToAction("Index", new { doctorId = appointment.DoctorId });
        }
    }
}