using System.Globalization;
using System.Xml.Linq;

namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gold:");
            var seller = new GoldSale();
            seller.AddGold(new Gold(2));
            seller.WhatchGolds();
            seller.SaleGold(0, out float fullPreis);
            
            Console.WriteLine($"Gold Full Price : {Accounting.PrintThreeDigit(fullPreis)}");
            Console.WriteLine($"Gold Tax : {Accounting.PrintThreeDigit(seller.TaxCalculator())} ");
            var emplowees = new List<Employee>()
        {
            new Employee(10 ,  300f),
            new Employee(8  ,235f),
            new Employee(7 ,69f)
            
        };
            Console.WriteLine("Employees :");
            foreach (var emp in emplowees)
            {


                Console.WriteLine($"Income : {Accounting.PrintThreeDigit(emp.IncomeCalculator())}");
                Console.WriteLine($"Tax : {Accounting.PrintThreeDigit(emp.TaxCalculator())}");
                Console.WriteLine("".PadLeft(50, '*'));
            }


        }
        
    }

}
