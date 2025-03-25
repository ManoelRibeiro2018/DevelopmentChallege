using DevelopmentChallenge.Data.Enum;

namespace DevelopmentChallenge.Data.Classes
{
    public class Idioma
    {
        public IdiomaEnum IdiomaEnum { get; set; }

        public static string Traduzir(string es, string en, int cantidad, int idioma)
        {
            if (idioma == (int)IdiomaEnum.Castellano)
                return cantidad == 1 ? es : es + "s";
            return cantidad == 1 ? en : en + "s";
        }
    }
}
