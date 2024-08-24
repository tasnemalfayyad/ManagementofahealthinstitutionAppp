using ApplictionData.Repositories;
using ApplictionData;
using Domain;
using System;
using System.Collections.Generic;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // اضافة الطبيب مع عنوان والمريض مع عنوان وحجز موعد والفاتورة

            using (ManagementofahealthinstitutionAppDbContext context = new ManagementofahealthinstitutionAppDbContext())
            {
                var addressA = new Address
                {
                    City = "City",
                    StreetNumber = "123",
                    BuildingName = "Building A",
                    Country = "country"
                };

                var appointment = new Appointment
                {
                    Data = DateTime.Now,
                    Status = Status.Awaiting
                };

                var Clinician = new Clinician
                {
                    FirstName = "Ahmad",
                    LastName = "Abohmaid",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    Gender = Gender.Male,
                    Specializing = Specialization.Psychiatry,
                    WorkShift = WorkingShift.EveningShift,
                    Addresses = new List<Address> { addressA },
                    //Appointments = new List<Appointment> { appointment }
                };

                var addressB = new Address
                {
                    City = "City",
                    StreetNumber = "123",
                    BuildingName = "Building B",
                    Country = "country"
                };

                var billing = new Billing
                {
                    Amount = 150,
                    Date = DateTime.Now,
                    Method = Method.Card,
                    Status = BillingStatus.Paid
                };

                var Patient = new Patient
                {
                    FirstName = "Ahmad",
                    LastName = "Abohmaid",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    Gender = Gender.Male,
                    Phone = "11-333-455",
                    Addresses = new List<Address> { addressB },
                    Appointments = new List<Appointment> { appointment },
                    Clinicians = new List<Clinician> { Clinician },
                    Billings = new List<Billing> { billing }
                };

                var clinicianRep = new ClinicianRepository(context);
                var patientRep = new PatientRepository(context);

                // Add 
                clinicianRep.Add(Clinician);
                patientRep.Add(Patient);
            }
        }
    }
}