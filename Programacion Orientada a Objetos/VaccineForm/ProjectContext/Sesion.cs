using System;
using System.Collections.Generic;

#nullable disable

namespace VaccineForm.ProjectContext
{
    public partial class Sesion
    {
        public int Id { get; set; }
        public int? IdCabin { get; set; }
        public int? IdEmployee { get; set; }
        public DateTime? DateHour { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
    }
}
