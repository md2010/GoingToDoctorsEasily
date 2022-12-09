using GoingToDoctorsMadeEasily.ModelCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoingToDoctorsMadeEasily.Model
{
    public class Diagnosis : IDiagnosis
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Therapy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }
        public bool IsActive { get; set; }
    }
}
