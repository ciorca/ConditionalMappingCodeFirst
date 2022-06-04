using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConditionalMappingCodeFirst
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public bool IsTerminated { get; set; }

    }
}