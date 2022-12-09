using GoingToDoctorsEasily.ModelCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoingToDoctorsEasily.Model
{
    public class WorkingHours : IWorkingHours
    {
        public Guid Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }
        public bool IsActive { get; set; }
    }
}
