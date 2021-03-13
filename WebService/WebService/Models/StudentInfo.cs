using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebService.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "id")]
        public String ID { get; set; }

        [DataMember(Name = "name")]
        public String Name { get; set; }

        [DataMember(Name = "gender")]
        public String Gender { get; set; }

        [DataMember(Name = "address")]
        public String Address { get; set; }
    }
}