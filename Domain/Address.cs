using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
  public class Address

    {
        public int AddressId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string StreetNumber { get; set; }
        public string BuildingName { get; set; } = string.Empty;


        public Clinician Clinician { get; set; }
        public int? ClinicianId { get; set; }
      
        public Patient Patient { get; set; }
        public int? PatientId { get; set; }
    }
}
