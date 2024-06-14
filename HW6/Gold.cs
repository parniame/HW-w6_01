namespace HW6
{
    public class Gold : Base<T>
    {
        public float Grammm { get; private set; }
        public static float PreisPerGramm { get; private set; }
        public static float Amount { get; private set; }
        public Gold(float gramm)
        {
            if (gramm > 0) Grammm = gramm;
            else
            {
                Grammm = 1;
            }
            PreisPerGrammSetter();
            Amount = this.PreisCalculator();

        }
        public static bool PreisPerGrammSetter(float preis = 3000f)
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
