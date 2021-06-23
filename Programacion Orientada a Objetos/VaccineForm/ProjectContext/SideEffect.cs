using System;
using System.Collections.Generic;

#nullable disable

namespace VaccineForm.ProjectContext
{
    public partial class SideEffect
    {
        public SideEffect()
        {
            Citizens = new HashSet<Citizen>();
        }

        public int Id { get; set; }
        public string SecondaryEffect { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}
