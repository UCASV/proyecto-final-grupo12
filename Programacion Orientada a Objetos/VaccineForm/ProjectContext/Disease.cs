using System;
using System.Collections.Generic;

#nullable disable

namespace VaccineForm.ProjectContext
{
    public partial class Disease
    {
        public Disease()
        {
            Citizens = new HashSet<Citizen>();
        }

        public int Id { get; set; }
        public string IllnessName { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}
