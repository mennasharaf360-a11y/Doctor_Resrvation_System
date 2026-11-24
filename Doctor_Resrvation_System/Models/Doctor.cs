namespace Doctor_Resrvation_System.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Image { get; set; } = "";
        public string Specialization { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public List<Appointment> Appointments { get; set; } = new();
        public string SubSpecialization { get; set; } = string.Empty;
    }
}
