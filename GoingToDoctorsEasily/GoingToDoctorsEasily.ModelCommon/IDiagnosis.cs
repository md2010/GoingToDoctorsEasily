using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoingToDoctorsMadeEasily.ModelCommon
{
    public interface IDiagnosis
    {
        Guid Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        string Therapy { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        Guid CreatedById { get; set; }
        Guid UpdatedById { get; set; }
        bool IsActive { get; set; }
    }
}
