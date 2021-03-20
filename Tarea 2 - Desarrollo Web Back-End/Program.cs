using System;
using System.Linq;
using Tarea_2___Desarrollo_Web_Back_End.BackEnd;
using Tarea_2___Desarrollo_Web_Back_End.DataAccess;

namespace Tarea_2___Desarrollo_Web_Back_End
{
    class Program
    {
        public static void Ejercicio()
        {
            var output = new EmployeeSC().GetEmployees();
            Console.WriteLine(output);
        }

        static void Main(string[] args)
        {
            Ejercicio();
        }

    }
}
