using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoingToDoctorsMadeEasily.ModelCommon
{
    public interface IDoctor
    {
        Guid Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string AmbulanceAddress { get; set; }
        int PhoneNumber { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        Guid CreatedById { get; set; }
        Guid UpdatedById { get; set; }
        bool IsActive { get; set; }
    }
}
