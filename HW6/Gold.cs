namespace HW6
{
    public class Gold 
    {
        public float Grammm { get; private set; }
        public static float PreisPerGramm { get; private set; }
        


        public Gold(float gramm,float preis = 3000f)
        {
            if (gramm > 0) Grammm = gramm;
            else
            {
                Grammm = 1;
            }
            PreisPerGrammSetter(preis);
            

        }
        public static bool PreisPerGrammSetter(float preis )
        {   if (preis > 0)
            {
                PreisPerGramm = preis;
                return true;
            }

            return false;
        }
        public float PreisCalculator()
        {
            return Grammm * PreisPerGramm;
        }
        
    }
}
