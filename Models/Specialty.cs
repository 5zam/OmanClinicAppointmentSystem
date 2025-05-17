using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppointmentApp.Models
{
    public class Specialty
    {
        [Key]
        public int SpecialtyId { get; set; }

        [Required]
        [StringLength(100)]
        public string SpecialtyName { get; set; }

        // One specialty has many doctors
        public ICollection<Doctor> Doctors { get; set; }

        public Specialty()
        {
            Doctors = new List<Doctor>();
        }
    }
}
