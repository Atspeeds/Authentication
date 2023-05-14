namespace _01_Framework.Infrastrue
{
    public static class Textoptions
    {
        public static string FixViewText(this string txt)
        {
            return txt.Length >= 20 ? txt.Substring(0, 15) + "..." : txt;
        }
    }
}
