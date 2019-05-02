using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperStudents.Models
{   
        
     public class VisitsStudent
    {
        public int Id { get; set; }
        public int Student_Id { get; set; }
        public int Group_Id { get; set; }
        public DateTime Date { get; set; }
    }
}
