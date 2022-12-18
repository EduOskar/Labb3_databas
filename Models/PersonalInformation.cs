using System;
using System.Collections.Generic;

namespace Labb3_databas_AhlingsSchoolProject.Models
{
    public partial class PersonalInformation
    {
        public PersonalInformation()
        {
            Employees = new HashSet<Employee>();
            Students = new HashSet<Student>();
        }

        public int PersonId { get; set; }
        public string Fname { get; set; } = null!;
        public string Lname { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public string Ssnumber { get; set; } = null!;
        public DateTime Birthdate { get; set; }
        public int Type { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
