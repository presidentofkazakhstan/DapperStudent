using DapperStudents.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperStudents
{
   public class DeleteStudent
    {
        public DeleteStudent()
        {
            StudentDataAccess _userRep = new StudentDataAccess();

            var resStudent = _userRep.GetAllStudent(@"SELECT * FROM Students");
            resStudent.ForEach(f => Console.WriteLine($"{f.Id}. \t {f.FullName} \t\tGroupId:  {f.Group_Id}"));

            Console.Write("Выберите студента  которого надо удалить: ");
            int idStudent = int.Parse(Console.ReadLine());

            var res = _userRep.DeleteStudent($"DELETE from Students where Id = {idStudent}");

            Console.ReadLine();
        }
    }
}
