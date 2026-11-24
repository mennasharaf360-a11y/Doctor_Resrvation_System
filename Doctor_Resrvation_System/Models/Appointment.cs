namespace Doctor_Resrvation_System.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Day { get; set; } = "";
        public string Time { get; set; } = "";
        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
    }
}