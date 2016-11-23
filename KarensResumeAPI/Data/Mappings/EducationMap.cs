using FluentNHibernate.Mapping;
using KarensResumeAPI.Data.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KarensResumeAPI.Data.Mappings
{
    public class EducationMap : ClassMap<Education>
    {
        public EducationMap()
        {
            Id(x => x.Id);
            Map(x => x.Area_Of_Study);
            Map(x => x.City);
            Map(x => x.State);
            Map(x => x.Degree);
            Map(x => x.School);
            Map(x => x.Completed);
            Table("Education");
        }
    }
}