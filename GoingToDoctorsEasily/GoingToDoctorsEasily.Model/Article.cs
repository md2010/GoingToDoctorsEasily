using GoingToDoctorsEasily.ModelCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoingToDoctorsEasily.Model
{
    public class Article : IArticle
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid CreatedById { get; set; }
        public Guid UpdatedById { get; set; }
        public bool IsActive { get; set; }
    }
}
