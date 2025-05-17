using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppointmentApp.Models
{
    

      public class Patient
        {
            [Key]
            public int PatientId { get; set; }

            [Required]
            [StringLength(50)]
            public string FirstName { get; set; }

            [Required]
            [StringLength(50)]
            public string LastName { get; set; }

            [DataType(DataType.Date)]
            public DateTime DateOfBirth { get; set; }

            [Required]
            [StringLength(10)]
            public string Gender { get; set; }

            [Phone]
            [StringLength(20)]
            public string PhoneNumber { get; set; }

            [EmailAddress]
            public string Email { get; set; }

            // one to many with Appointment
            public ICollection<Appointment> Appointments { get; set; }

        public Patient()
        {
            Appointments = new List<Appointment>();
        }

    }

}

