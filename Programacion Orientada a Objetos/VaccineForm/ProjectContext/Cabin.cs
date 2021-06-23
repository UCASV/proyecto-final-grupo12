using System;
using System.Collections.Generic;

#nullable disable

namespace VaccineForm.ProjectContext
{
    public partial class Cabin
    {
        public Cabin()
        {
            Appointments = new HashSet<Appointment>();
            Sesions = new HashSet<Sesion>();
        }

        public int Id { get; set; }
        public string CabinAddress { get; set; }
        public string CabinPhone { get; set; }
        public string EmployeeInCharge { get; set; }
        public string CabinEmail { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Sesion> Sesions { get; set; }
    }
}
