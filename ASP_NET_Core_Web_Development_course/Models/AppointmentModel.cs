using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_Core_Web_Development_course.Models
{
    public class AppointmentModel
    {
        [Required]
        [StringLength(20,MinimumLength = 4)]
        [DisplayName("Patient's full name")]
        public string PatientName { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Appointment date")]
        public DateTime AppointmentDate { get; set; }

        [DataType(DataType.Currency)]
        [DisplayName("Patient's approximate Net Worth")]
        public decimal PatientNetWorth { get; set; }

        [DisplayName("Doctor's full name")]
        public string DoctorName { get; set; }

        [Range(1,10)]
        [DisplayName("Patient's pain level (1 low 10 high)")]
        public int PainLevel { get; set; }
    }
}
