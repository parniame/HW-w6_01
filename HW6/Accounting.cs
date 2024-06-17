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


                if ((0 <= value) && (value < 1))
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


                if ((0 <= value))
                {
                    amount = value;
                }

            }


        }
        public Accounting(float tax = .1f,float amount = 100)
        {
            Tax = Tax;
            Amount = amount;

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
