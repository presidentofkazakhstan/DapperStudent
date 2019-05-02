using DapperStudents.Models;
using DapperStudents.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperStudents
{
    public class InsertStudent
    {
        public InsertStudent()
        {
            StudentDataAccess _userRep = new StudentDataAccess();

            Console.Write("Введите имя студента: ");
            string name = Console.ReadLine();


            var resGroup = _userRep.GetAllGroup(@"SELECT * FROM [Group]");
            resGroup.ForEach(f => Console.WriteLine($"{f.Id} \t {f.Name}"));

            Console.Write("Введите id группы(1-3): ");
            int groupId = int.Parse(Console.ReadLine());


            _userRep.InsertStudent(@"insert into Students (FullName ,Group_Id) values(@FullName ,
                                     @Group_Id) ", new Student()

            {
                FullName = name,
                Group_Id = groupId

            });

        }
    }
}
