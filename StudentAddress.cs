using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    public class StudentAddress
    {
        [Key,ForeignKey("Student")]
        public int StudentId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        //navigation property
        public virtual Student Student{ get; set; } // dont need ICollection here becaus its a one to one relationship
    }
}
