using System;
using System.Collections.Generic;

#nullable disable

namespace VaccineForm.ProjectContext
{
    public partial class Appointment
    {
        public int IdAppointment { get; set; }
        public string IdCitizen { get; set; }
        public int IdCabin { get; set; }
        public DateTime? DateVaccination1 { get; set; }
        public DateTime? DateVaccination2 { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Citizen IdCitizenNavigation { get; set; }
    }
}
