using Microsoft.EntityFrameworkCore;
using Doctor_Resrvation_System.Models;

namespace Doctor_Resrvation_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<Appointment> Appointments => Set<Appointment>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Booking> Bookings => Set<Booking>();

        protected override void OnModelCreating(ModelBuilder b)
        {
            base.OnModelCreating(b);

            b.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = 1,
                    Name = "Dr. Malak Mahmoud",
                    Specialization = "Cardiology",
                    SubSpecialization = "Interventional Cardiology",
                    PhoneNumber = "01000000001",
                    Image = "/images/d1.png"
                },
                new Doctor
                {
                    Id = 2,
                    Name = "Dr. Menna Sharaf",
                    Specialization = "Dermatology",
                    SubSpecialization = "Cosmetic Dermatology",
                    PhoneNumber = "01000000002",
                    Image = "/images/d2.png"
                },
                new Doctor
                {
                    Id = 3,
                    Name = "Dr. Doaa Badawy",
                    Specialization = "Pediatrics",
                    SubSpecialization = "Neonatology",
                    PhoneNumber = "01000000003",
                    Image = "/images/d3.png"
                },
                new Doctor
                {
                    Id = 4,
                    Name = "Dr. Layla Yasser",
                    Specialization = "Dentistry",
                    SubSpecialization = "Orthodontics",
                    PhoneNumber = "01000000004",
                    Image = "/images/d4.png"
                },
                new Doctor
                {
                    Id = 5,
                    Name = "Dr. Amr El-Sayed",
                    Specialization = "Orthopedics",
                    SubSpecialization = "Sports Medicine",
                    PhoneNumber = "01000000005",
                    Image = "/images/d5.png"
                },
                new Doctor
                {
                    Id = 6,
                    Name = "Dr. Mohamed Ibrahim",
                    Specialization = "Neurology",
                    SubSpecialization = "Stroke Neurology",
                    PhoneNumber = "01000000006",
                    Image = "/images/d6.png"
                },
                new Doctor
                {
                    Id = 7,
                    Name = "Dr. Youssef Osama",
                    Specialization = "Ophthalmology",
                    SubSpecialization = "Retina",
                    PhoneNumber = "01000000007",
                    Image = "/images/d7.png"
                });

            b.Entity<Appointment>().HasData(
                // Dr. Malak (1)
                new Appointment { Id = 1, DoctorId = 1, Day = "Sunday", Time = "10:00" },
                new Appointment { Id = 2, DoctorId = 1, Day = "Monday", Time = "12:00" },
                new Appointment { Id = 3, DoctorId = 1, Day = "Wednesday", Time = "09:00" },
                new Appointment { Id = 4, DoctorId = 1, Day = "Thursday", Time = "14:00" },

                // Dr. Menna (2)
                new Appointment { Id = 5, DoctorId = 2, Day = "Sunday", Time = "11:00" },
                new Appointment { Id = 6, DoctorId = 2, Day = "Tuesday", Time = "09:00" },
                new Appointment { Id = 7, DoctorId = 2, Day = "Wednesday", Time = "15:00" },
                new Appointment { Id = 8, DoctorId = 2, Day = "Thursday", Time = "10:00" },

                // Dr. Doaa (3)
                new Appointment { Id = 9, DoctorId = 3, Day = "Sunday", Time = "13:00" },
                new Appointment { Id = 10, DoctorId = 3, Day = "Monday", Time = "10:00" },
                new Appointment { Id = 11, DoctorId = 3, Day = "Wednesday", Time = "13:00" },
                new Appointment { Id = 12, DoctorId = 3, Day = "Thursday", Time = "16:00" },

                // Dr. Layla (4)
                new Appointment { Id = 13, DoctorId = 4, Day = "Monday", Time = "15:00" },
                new Appointment { Id = 14, DoctorId = 4, Day = "Tuesday", Time = "11:00" },
                new Appointment { Id = 15, DoctorId = 4, Day = "Wednesday", Time = "12:00" },
                new Appointment { Id = 16, DoctorId = 4, Day = "Thursday", Time = "14:00" },

                // Dr. Amr (5)
                new Appointment { Id = 17, DoctorId = 5, Day = "Sunday", Time = "15:00" },
                new Appointment { Id = 18, DoctorId = 5, Day = "Monday", Time = "09:00" },
                new Appointment { Id = 19, DoctorId = 5, Day = "Wednesday", Time = "10:00" },
                new Appointment { Id = 20, DoctorId = 5, Day = "Thursday", Time = "13:00" },

                // Dr. Mohamed (6)
                new Appointment { Id = 21, DoctorId = 6, Day = "Sunday", Time = "12:00" },
                new Appointment { Id = 22, DoctorId = 6, Day = "Monday", Time = "16:00" },
                new Appointment { Id = 23, DoctorId = 6, Day = "Tuesday", Time = "14:00" },
                new Appointment { Id = 24, DoctorId = 6, Day = "Thursday", Time = "12:00" },

                // Dr. Youssef (7)
                new Appointment { Id = 25, DoctorId = 7, Day = "Sunday", Time = "09:00" },
                new Appointment { Id = 26, DoctorId = 7, Day = "Tuesday", Time = "13:00" },
                new Appointment { Id = 27, DoctorId = 7, Day = "Wednesday", Time = "11:00" },
                new Appointment { Id = 28, DoctorId = 7, Day = "Thursday", Time = "15:00" });
        }
    }
}