using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineForm.ProjectContext;

namespace VaccineForm.ViewModels
{
    
        public class CitizenVM
        {
            public string Dui { get; set; }
            public string FullName { get; set; }
            public string CitizenAddress { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public int Age { get; set; }
            public int? IdDisease { get; set; }
            public int? IdInstitution { get; set; }
            public virtual Disease IdDiseaseNavigation { get; set; }
            public virtual Institution IdInstitutionNavigation { get; set; }
        }
    
}
