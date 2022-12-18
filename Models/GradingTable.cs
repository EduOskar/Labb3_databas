using System;
using System.Collections.Generic;

namespace Labb3_databas_AhlingsSchoolProject.Models
{
    public partial class GradingTable
    {
        public int GradingId { get; set; }
        public int Grade { get; set; }
        public DateTime GradeSet { get; set; }
        public int FkStudentId { get; set; }
        public int FkClassId { get; set; }

        public virtual Class FkClass { get; set; } = null!;
        public virtual Student FkStudent { get; set; } = null!;
    }
}
