using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace UniversitySystem.Data.Entities
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Address { get; set; }
        [StringLength(500)]
        public string Phone { get; set; }
        public int? DepartmentID { get; set; }

        [ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }
    }
}
