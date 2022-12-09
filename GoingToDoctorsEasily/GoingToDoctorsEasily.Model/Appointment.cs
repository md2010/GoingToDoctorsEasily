using GoingToDoctorsEasily.ModelCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoingToDoctorsEasily.Model
{
    public class Appointment : IAppointment
    {
        public Guid Id { get; set; }
        public Guid PatientId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }
        public bool IsActive { get; set; }
    }
}
