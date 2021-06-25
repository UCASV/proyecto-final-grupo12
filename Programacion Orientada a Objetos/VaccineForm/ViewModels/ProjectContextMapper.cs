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

        public static CitizenVm MapCitizenToCitizenVm(Citizen e)
        {

            return new CitizenVm
            {
                Dui = e.Dui,
                FullName = e.FullName,
                CitizenAddress = e.CitizenAddress,
                PhoneNumber = e.PhoneNumber,
                Email = e.Email,
                Age = e.Age

            };

        }

        public static AppointmentVm MapAppointmentToAppointmentVm(Appointment a)
        {
            return new AppointmentVm
            {
                Dui = a.IdCitizen,
                IdCabin = a.IdCabin,
                DateVaccination = a.DateVaccination1,
                DateSecondDose = a.DateVaccination2
            };
        }
    }
}
