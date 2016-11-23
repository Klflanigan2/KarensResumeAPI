using KarensResumeAPI.Data.Daos;
using KarensResumeAPI.Data.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace KarensResumeAPI.Controllers
{
    public class EducationController : ApiController
    {
        //Gets all the stuff in the table
        public IEnumerable<Education> GetAllEducations()
        {
            return EducationDao.Instance.GetEducations();
        }
    }
}