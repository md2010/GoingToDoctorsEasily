using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoingToDoctorsEasily.ModelCommon
{
    public interface IAppointment
    {
        Guid Id { get; set; }
        Guid PatientId { get; set; }
        DateTime From { get; set; }
        DateTime To { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        Guid CreatedById { get; set; }
        Guid UpdatedById { get; set; }
        bool IsActive { get; set; }
    }
}
