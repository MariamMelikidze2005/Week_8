using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9
{
    internal class Teacher : Person
    {
        public string Subject { get; set; }
        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(Subject);
        }

        public override void Describe()
        {

            Console.WriteLine("i am teacher");
        }

        public override string GetOccupation()
        {
            return "Teacher";
        }
    }
}
