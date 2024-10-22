using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace week9
{
    internal class Student : Person
    {
        public int StudentId { get; set; }
        public Student(string name, int age, int studentId) : base(name, age)
        {
            StudentId = studentId;
        }


        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(StudentId);
        }

        public override void Describe()
        {

            Console.WriteLine("i am Student");
        }

        public override string GetOccupation()
        {
            return "student";
        }
    }
}
