using System;
using System.Collections.Generic;

#nullable disable

namespace VaccineForm.ProjectContext
{
    public partial class EmployeeType
    {
        public EmployeeType()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }
        public string TypeEm { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
