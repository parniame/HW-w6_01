using static System.Net.WebRequestMethods;

namespace HW6
{
    public class GoldSale : Accounting
    {
        public List<Gold> Golds
        {
            get;
            private set;
        }
        private Gold SellingGold { get; set; }//The gold that is being Selled

        
        private static float VAT//ارزش افزوده
        {
            get;

            set;
            
        }
        
        private static float FinancialTransactionTax// مالیات معامله
        {
            get; set;
        }
        private float dailyIncome;
        public  float DailyIncome
        {
            get
            {
                return dailyIncome;
            }
             set
            {
                if(IsPositive(value))
                {
                    dailyIncome = value;
                }
            }
        }
        public GoldSale(float vAT = .1f,//درصد مالیات بر ارزش افزوده10 و 15 درصد مالیات معامله ی طلا
        float financialTransactionTax = .15f,float dailyIncome = 1500f)//روزی یکو نیم ملیون
        {
            Golds = new List<Gold>();
            VAT = vAT;
            FinancialTransactionTax = financialTransactionTax;
            FullTaxCalculator();//  (parent property)Tax = VAT + FinancialTransactionTax;
            DailyIncome = dailyIncome;
            SellingGold = new Gold(2);//initialize so we dont get null refrence error
            



        }
        public void WhatchGolds()
        {   if(Golds.Capacity != 0) {
                int i = 0;
                foreach (var item in Golds)
                {
                    Console.WriteLine($"index :{i + 1}" +$"\nGramm : {item.Grammm}" +
                        $"\nPreis : {PrintThreeDigit(item.PreisCalculator())}");
                    i++;

                }
            }
        else
            {
                Console.WriteLine("There is No Gold!");
            }
            
        }
        public void SaleGold(int indexOfGold, out float fullPreis)
        {
            SellingGold = Golds.ElementAt(indexOfGold);
            fullPreis = SellingGold.PreisCalculator() + TaxCalculator();
            Golds.Remove(SellingGold);
        }
        private static new void FullTaxCalculator()//Update Tax
        {
            Tax = VAT + FinancialTransactionTax;
        }
        public void AddGold(Gold gold)
        {
            Golds.Add(gold);
        }

        public static bool SetVAT(float vat)
        {
            if (IsPercentage(vat))
            {
                VAT = vat;
                FullTaxCalculator();//Update Tax
                return true;
            }


            else
                return false;

        }
        public static bool SetFinancialTransactionTax(float FTT)
        {
            if (IsPercentage(FTT))
            {
                FinancialTransactionTax = FTT;
                FullTaxCalculator();//Update Tax
                return true;
            }


            else
                return false;

        }

        public override float IncomeCalculator()
        {
            int monthDay = 30 - 6;
            return monthDay * DailyIncome;
        }
        public override float TaxCalculator()
        {
            return SellingGold.PreisCalculator() * Tax;
        }
        

    }
}
