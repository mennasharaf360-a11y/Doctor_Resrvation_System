namespace Doctor_Resrvation_System.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int AppointmentId { get; set; }
        public Appointment? Appointment { get; set; }
    }
}
