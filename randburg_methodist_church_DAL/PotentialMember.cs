using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randburg_methodist_church_DAL
{
    class PotentialMember
    {
        public Guid Potential_Id { get; set; }
        public string Potential_Fullname { get; set; }
        public string Potential_CellNumber { get; set; }
        public string Potential_EmailAddress { get; set; }
        public string Potential_Location { get; set; }
        public Guid Leader_Id { get; set; }
    }
}
