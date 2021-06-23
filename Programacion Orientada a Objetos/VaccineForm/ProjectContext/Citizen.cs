using System;
using System.Collections.Generic;

#nullable disable

namespace VaccineForm.ProjectContext
{
    public partial class Citizen
    {
        public Citizen()
        {
            Appointments = new HashSet<Appointment>();
        }

        public string Dui { get; set; }
        public string FullName { get; set; }
        public string CitizenAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int? IdDisease { get; set; }
        public int? IdInstitution { get; set; }
        public int? IdSecEffect { get; set; }

        public virtual Disease IdDiseaseNavigation { get; set; }
        public virtual Institution IdInstitutionNavigation { get; set; }
        public virtual SideEffect IdSecEffectNavigation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
