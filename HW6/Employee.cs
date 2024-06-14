namespace HW6
{
    public class Employee : Accounting
    {
        public int HourCountDaily
        {
            get { return HourCountDaily; }



            set
            {


                if ((0 <= value) && (value <= 300))
                {
                    HourCountDaily = value;
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
        public Employee(int hourCountDaily = 10, float incomePerHour = 200f)
        {
            HourCountDaily = hourCountDaily;
            IncomePerHour = incomePerHour;
            Tax = TaxCalculator();

        }
        public override float TaxCalculator()
        {
            float income = IncomeCalculator();
            
             if (income == 6000)
            {
                return 0;
            }
            else if ((6000 < income) && (income < 7500))
            {
                Tax = .07f;
                
            }
            else if ((income <= 7500) &&  (income < 9000))
            {
                Tax = .08f;
                
            }
            else if ((income <= 9000) && (income < 10000))
            {
                Tax = .09f;
                
            }
           
            return income * Tax;










        }

        public override float IncomeCalculator()
        {
            return HourCountDaily * IncomePerHour * 30;
        }


    }
}
