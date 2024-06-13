namespace HW6
{
    public class Accounting
    {
        public int hourCountMonthly {
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
        public float Tax
        {
            get { return Tax; }



            set
            {
                
                
                if ( (0 <= value) && (value  < 1))
                {
                    Tax = value;
                }
                
            }


        }
        public Accounting()
        {
            Tax = .1f;
            
        }
        public  virtual float TaxCalculator(float amount)
        {
            return amount*Tax;
        }
        public virtual float IncomeCalculator()
        {
            return hourCountMonthly*IncomePerHour;
        }

    }
    public class Gold
    {

    }
    public class GoldSale : Accounting
    {

    }
}
