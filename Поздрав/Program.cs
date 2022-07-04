using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поздрав
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName, courseName;

            Console.Write("Име на ученик: ");
            studentName = Console.ReadLine();

            Console.Write("Наименование на курс: ");
            courseName = Console.ReadLine();

            //работи само на английски
            Console.WriteLine("Здравейте " + studentName + " и добре дошли в " + courseName + "!");
          
            Console.ReadLine();
        }
    }
}
