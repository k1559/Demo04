using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one teacher from Teacher class
            Teacher teacher = new Teacher();
            teacher.Firstname = "Kirsi";
            teacher.Lastname = "Kernel";
            teacher.Age = 30;
            teacher.Address = "Piippukatu2 ";
            teacher.PhoneNumber = "010-12345678";
            teacher.Room = "D444";
            Console.WriteLine(teacher.ToString());

            Student student = new Student("Timo", "Koljonen", "K11421");
            student.Age = 49;
            student.PhoneNumber = "044-63453243";
            Console.WriteLine(student.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();
            Console.ReadLine();
        }
    }
}
