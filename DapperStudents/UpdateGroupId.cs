using DapperStudents.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperStudents
{
    public class UpdateGroupId
    {
        public UpdateGroupId()
        {

            StudentDataAccess _userRep = new StudentDataAccess();


            var resStudent = _userRep.GetAllStudent(@"SELECT * FROM Students");
            resStudent.ForEach(f => Console.WriteLine($"{f.Id}. \t {f.FullName} \t\tGroupId:  {f.Group_Id}"));

            Console.Write("Выберите студента у которого надо изменить группу: ");
            int idStudent = int.Parse(Console.ReadLine());

            Console.Write("На какую надо изменить группу: ");
            int idGroup = int.Parse(Console.ReadLine());

           _userRep.UpdateGroupId($"update Students set Group_Id= {idGroup} where Id = {idStudent}");

        }
    }
}
