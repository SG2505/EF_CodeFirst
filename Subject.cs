using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CodeFirst
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int Marks { get; set; }

        //navigation property
        public virtual ICollection<Programme> Programmes { get; set; }
    }
}
