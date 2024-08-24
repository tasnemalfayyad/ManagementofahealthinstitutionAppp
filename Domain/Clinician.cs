namespace Domain
{
    public enum Gender
    {
        Male,
        Female
    }
    public enum Specialization
    {
        Cardiology,
        Dermatology,
        Neurology,
        Pediatrics,
        Orthopedics,
        Ophthalmology,
        Psychiatry,
        Surgery,
        Other
    }
    public enum WorkingShift
    {
        DayShift,
        NightShift,
        EveningShift
    }
    public class Clinician
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; } = "example@example.com"; // قيمة افتراضية للبريد الإلكتروني
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Specialization Specializing { get; set; }
        public WorkingShift WorkShift { get; set; }
       // public List<Appointment> Appointments { get; set; } = new List<Appointment>();
        public List<Patient> Patients { get; set; } = new List<Patient>();

        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
