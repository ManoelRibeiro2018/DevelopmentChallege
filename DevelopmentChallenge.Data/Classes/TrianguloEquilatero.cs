using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        public decimal Lado { get; set; }
        public TrianguloEquilatero(decimal lado)
        {
            Lado = lado;
        }

        public override decimal CalcularPerimetro()
            => Lado * 3;

        public override decimal CalcularArea() =>
            ((decimal)Math.Sqrt(3) / 4) * Lado * Lado;

        public override string TraducirForma(int tipo, int cantidad, int idioma)
            => ""; // TODO - Segregar responsabilidade de Idoma para uma classe separada
            
    }
}
