using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineForm.ViewModels
{
    public class AppointmentVm
    {
        public string Dui { get; set; }
        public int IdCabin { get; set; }
        public DateTime? DateVaccination { get; set; }
        public DateTime? DateSecondDose { get; set; }
    }
}
