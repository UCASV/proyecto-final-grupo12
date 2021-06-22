using System;
using System.Collections.Generic;

#nullable disable

namespace VaccineForm.ProjectContext
{
    public partial class SideEffect
    {
        public SideEffect()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string SecondaryEffect { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
