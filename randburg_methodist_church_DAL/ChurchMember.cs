﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randburg_methodist_church_DAL
{
    class ChurchMember
    {
        public Guid Member_Id { get; set; }
        public string Member_Fullname { get; set; }
        public string Member_CellNumber { get; set; }
        public string Member_EmailAddress { get; set; }
        public string Member_Location { get; set; }
        public Guid Leader_Id { get; set; }
    }
}
