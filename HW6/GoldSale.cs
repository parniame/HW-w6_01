namespace HW6
{
    public class GoldSale : Accounting
    {
        public List<Gold> Golds
        {
            get;
            private set;
        }
        private Gold SellingGold { get; set; }

        private static float vat;
        public static float VAT
        {
            get
            {
                return vat;
            }
            private set
            {
                vat = value;
                FullTaxCalculator();
            }
        }
        private static float financialTransactionTax;
        public static float FinancialTransactionTax
        {
            get
            {
                return financialTransactionTax;
            }
            private set
            {
                financialTransactionTax = value;
                FullTaxCalculator();
            }
        }
        public GoldSale()
        {
            Golds = new List<Gold>();
            VAT = .1f;
            FinancialTransactionTax = .15f;
            SellingGold = new Gold(2);
            //Tax = FinancialTransactionTax + VAT;
            
            

        }
        public void WhatchGolds()
        {   int i = 0;
            foreach (var item in Golds)
            {
                Console.WriteLine($"{i+1} : Gramm : {item.Grammm}" +
                    $",Preis : {item.PreisCalculator()}");
                i++;

            }
        }
        public void SaleGold(int indexOfGold, out float fullPreis)
        {   SellingGold = Golds.ElementAt(indexOfGold);
            fullPreis = SellingGold.PreisCalculator() + TaxCalculator();
            Golds.Remove(SellingGold);
        }
        private static new void  FullTaxCalculator()
        {
            Tax = VAT + FinancialTransactionTax;
        }
        public void AddGold(Gold gold)
        {
            Golds.Add(gold);
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
        public override float TaxCalculator()
        {
            return SellingGold.PreisCalculator()*Tax;
        }

    }
}
