using System;
using System.Collections.Generic;

#nullable disable

namespace VaccineForm.ProjectContext
{
    public partial class Employee
    {
        public Employee()
        {
            Sesions = new HashSet<Sesion>();
        }

        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string InstitutionalEmail { get; set; }
        public string Password { get; set; }
        public string EmployeeAddress { get; set; }
        public int? IdType { get; set; }

        public virtual EmployeeType IdTypeNavigation { get; set; }
        public virtual ICollection<Sesion> Sesions { get; set; }
    }
}
