using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
  
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; } = "example@example.com"; // قيمة افتراضية للبريد الإلكتروني
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Phone { get; set; }

        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

        public List<Billing> Billings { get; set; } = new List<Billing>();
        public List<Clinician> Clinicians { get; set; } = new List<Clinician>();

        public List<Address> Addresses { get; set; } = new List<Address>();


    }
}
