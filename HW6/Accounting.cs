using System.Transactions;

namespace HW6
{
    public class Accounting<T> : 
    {
        public int hourCountMonthly
        {
            get { return hourCountMonthly; }



            set
            {


                if ((0 <= value) && (value <= 300))
                {
                    hourCountMonthly = value;
                }

            }
        }
        public float IncomePerHour
        {
            get { return IncomePerHour; }



            set
            {


                if ((0 <= value))
                {
                    IncomePerHour = value;
                }

            }


        }
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
        public float Amount { get; private set; }

        public Accounting()
        {
            Tax = .1f;

        }

        public virtual float TaxCalculator()
        {
            return Tamount * Tax;
        }
        
        public virtual float IncomeCalculator()
        {
            return hourCountMonthly * IncomePerHour;
        }

    }
}
