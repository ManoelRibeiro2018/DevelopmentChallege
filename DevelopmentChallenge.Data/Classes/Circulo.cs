using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        public decimal Radio { get; set; }
        public Circulo(decimal radio)
        {
            Radio = radio;
        }

        public override decimal CalcularPerimetro()
            => (decimal)Math.PI * Radio;

        public override decimal CalcularArea() =>
            (decimal)Math.PI * (Radio / 2) * (Radio / 2);

        public override string TraducirForma(int cantidad, int idioma)
            => Idioma.Traduzir("Círculo", "Circle", cantidad, idioma);
    }
}