using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineForm.ProjectContext;

namespace VaccineForm.ViewModels
{
    public static class ProjectContextMapper
    {

        public static CitizenVM MapCitizenToCitizenVM(Citizen e)
        {

            return new CitizenVM
            {
                Dui = e.Dui,
                FullName = e.FullName,
                CitizenAddress = e.CitizenAddress,
                PhoneNumber = e.PhoneNumber,
                Email = e.Email,
                Age = e.Age

            };

        }
    }
}
