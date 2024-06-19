using System.Globalization;
using System.Transactions;

namespace HW6
{
    public class Accounting
    {
        private static float tax;
        public static float Tax

        {
            get { return tax; }



            set
            {


                if (IsPercentage(value))
                {
                    tax = value;
                }

            }


        }
        private float amount;
        private float Amount
        {
            get { return amount; }



            set
            {


                if (IsPositive(value))
                {
                    amount = value;
                }

            }


        }
        public Accounting(float tax = .1f,float amount = 100)//10% پیش فرض
        {
            Tax = Tax;
            Amount = amount;

        }
        protected static bool IsPercentage(float num)
        {
            if (num >= 0 && num < 1) { return true; } else { return false; }
        }
        protected static bool IsPositive(float num)
        {
            if (num >= 0) { return true; } else { return false; };
        }
         public static string PrintThreeDigit(float number)
        {
            number *= 10000;
            return number.ToString("N0", new NumberFormatInfo()
            {
                NumberGroupSizes = new[] { 3 },
                NumberGroupSeparator = ","
            }) ;
            
        }
        public virtual float TaxCalculator()
        {

            return Amount * Tax;
        }

        public virtual float IncomeCalculator()
        {
            return Amount;
        }

    }
}
