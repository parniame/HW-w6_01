using System.Transactions;

namespace HW6
{
    public class Accounting
    {
        public static float Tax
        {
            get { return Tax; }



            set
            {


                if ((0 <= value) && (value < 1))
                {
                    Tax = value;
                }

            }


        }
        private float Amount
        {
            get { return Amount; }



            set
            {


                if ((0 <= value))
                {
                    Amount = value;
                }

            }


        }
        public Accounting(float tax = .1f)
        {
            Tax = Tax;
            Amount = 100;

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
