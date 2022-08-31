using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    [Table("Track")]
    public class Programme
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // this doesn't auto increment the id column
        public int Id { get; set; }

        [Required]
        [Column("CourseName")]
        [MaxLength(5)]
        public string Title{ get; set; }
        public int Duration{ get; set; }
        public float Fees{ get; set; }

        //navigation property
        public virtual ICollection<Student> Students { get; set; } 
        public virtual ICollection<Subject> Subjects { get; set; } 

    }
}
