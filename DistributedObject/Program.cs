using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributedObject
{
    class Program
    {
        static void Main(string[] args)
        {
            CStudent student = new CStudent();
            student["Ho ten"] = "Dang Anh Hao";
            student["DTB"] = 9.0;

            Console.WriteLine(student["Ho ten"]);
            Console.WriteLine(student["DTB"]);
        }
    }
}
