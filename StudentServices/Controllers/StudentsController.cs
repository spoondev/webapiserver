using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using StudentDataAccess1;

namespace StudentServices.Controllers
{
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class StudentsController : ApiController
    {
        public IEnumerable<employeeV2> GET()
        {
            using (demo_front_end_V2Entities entities = new demo_front_end_V2Entities())
            {
                return entities.employeeV2.ToList();
            }
        }

        public employeeV2 Get(int id)
        {
            using (demo_front_end_V2Entities entities = new demo_front_end_V2Entities())
            {
                return entities.employeeV2.FirstOrDefault(e => e.EMPID == id);
            }
        }
    }
}
