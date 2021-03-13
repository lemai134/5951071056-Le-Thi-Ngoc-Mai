using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebService.Models;

namespace WebService.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            var StudentInfList = new List<StudentInfo>();

            for(int i = 0; i < 5; i++)
            {
                var newStudent = new StudentInfo
                {
                    ID = "595107" + i,
                    Name = "Le Thi Ngoc Mai",
                    Gender = "Nu",
                    Address = "Quan " + i + " , TP.Ho Chi Minh"
                };
                StudentInfList.Add(newStudent);
            }
            return StudentInfList;
        }

        // GET: api/Student/5
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {
                ID = "595107" + id,
                Name = "Le Thi Ngoc Mai",
                Gender = "Nu",
                Address = "Quan " + id + " , TP.Ho Chi Minh"
            }; ;
        }

        // POST: api/Student
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
