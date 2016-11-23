using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KarensResumeAPI.Data.Objects
{
    public class Education
    {
        public virtual Guid Id { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Area_Of_Study { get; set; }
        public virtual string Completed { get; set; }
        public virtual string School { get; set; }
        public virtual string Degree { get; set; }
    }
}