using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniversitySystem.Data.Entities
{
    public class DepartmetSubject
    {
        [Key]
        public int DepartmentSubjectID { get; set; }
        public int DepartmentID { get; set; }
        public int SubjectID { get; set; }

        [ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }

        [ForeignKey("SubjectID")]
        public virtual Subjects Subject { get; set; }
    }
}
