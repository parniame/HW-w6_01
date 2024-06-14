namespace HW6
{
    public class GoldSale : Accounting
    {
        public List<Gold> Golds
        {
            get;
            private set;
        }
        public static float VAT
        {
            get
            {
                return VAT;
            }
            private set
            {
                VAT = value;
                TaxCalculator();
            }
        }
        public static float FinancialTransactionTax
        {
            get
            {
                return FinancialTransactionTax;
            }
            private set
            {
                FinancialTransactionTax = value;
                TaxCalculator();
            }
        }
        public GoldSale()
        {
            Golds = new List<Gold>();
            VAT = .1f;
            FinancialTransactionTax = .15f;
            //Tax = FinancialTransactionTax + VAT;
            
            

        }
        private static  void  TaxCalculator()
        {
            Tax = VAT + FinancialTransactionTax;
        }
        public void AddGold(Gold gold)
        {
            Golds.Add(gold);
        }
        public void SaleGold(Gold gold,out float fullPreis)
        {
            fullPreis = gold.PreisCalculator() + TaxCalculator(gold);
            Golds.Remove(gold);
        }
        public static bool  SetVAT(float vat)
        {
            if (vat >= 0 && vat < 1)
            {
                VAT = vat;
                
                return true;
            }

            
            else 
                return false;
            
        }
        public static bool SetFinancialTransactionTax(float FTT)
        {
            if (FTT >= 0 && FTT < 1)
            {
                FinancialTransactionTax = FTT;
                return true;
            }


            else
                return false;

        }
        
        public override float IncomeCalculator()
        {
            int monthDay = 30 - 6;
            return monthDay * 1500;
        }
        public virtual float TaxCalculator(Gold gold)
        {
            return gold.PreisCalculator()*Tax;
        }

    }
}
