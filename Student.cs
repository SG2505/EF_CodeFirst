using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string ContactInfo { get; set; }

        [ForeignKey("Programme")]
        public int ProgrammeId { get; set; }

        //navigation property
        public virtual Programme Programme { get; set; }
        public virtual StudentAddress StudentAddress { get; set; }
    }
}
