using System.Globalization;
using System.Xml.Linq;

namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emplowees = new List<Employee>()
        {
            new Employee(10 ,  300f),
            new Employee(8  ,235f),
            new Employee(7 ,69f)
        };
            foreach (var emp in emplowees)
            {
                
                
                PrintThreeDigit(emp.IncomeCalculator() * 10000);
                Console.WriteLine("".PadLeft(50, '*'));
            }


        }
        static void PrintThreeDigit(float number)
        {
            Console.WriteLine(number.ToString("N0", new NumberFormatInfo()
            {
                NumberGroupSizes = new[] { 3 },
                NumberGroupSeparator = ","
            }));
        }
    }

}
