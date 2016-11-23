using KarensResumeAPI;
using KarensResumeAPI.Data.Objects;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KarensResumeAPI.Data.Daos
{
    public class EducationDao
    {
        private static readonly Lazy<EducationDao> _instance = new Lazy<EducationDao>();
        public static EducationDao Instance = _instance.Value;

        public IEnumerable<Education> GetEducations()
        {
            IEnumerable<Education> myList = new List<Education>();
            ISession session = NHibernateHelper.GetCurrentSession();
            ITransaction tx = session.BeginTransaction();
            IQuery query = session.CreateQuery("select p from KarensResumeAPI.Data.Objects.Education as p");
            myList = query.List<Education>();

            return myList;
        }
    }
}