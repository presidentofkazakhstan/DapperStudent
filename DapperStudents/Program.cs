using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperStudents.Models;
using DapperStudents.Repository;

namespace DapperStudents
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("1 - Вставить нового студента");
            Console.WriteLine("2 - изменить группу у студента");
            Console.WriteLine("3 - удалить студента");

            int selectnum = int.Parse(Console.ReadLine());

            if (selectnum == 1)
            {
                InsertStudent insertStudent = new InsertStudent();
            }
            else if (selectnum == 2)
            {
                UpdateGroupId updateGroupId = new UpdateGroupId();

            }

            else if (selectnum == 3)
            {
                DeleteStudent deleteStudent = new DeleteStudent();
            }



        }
    }
}
