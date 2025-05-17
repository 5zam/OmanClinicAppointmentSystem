using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppointmentApp.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Phone]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public int SpecialtyId { get; set; }

        
        [ForeignKey("SpecialtyId")]
        public Specialty Specialties { get; set; }

        // one doctor has many appointments
        public ICollection<Appointment> Appointments { get; set; }

        public Doctor()
        {
            Appointments = new List<Appointment>();
        }
    }
}
