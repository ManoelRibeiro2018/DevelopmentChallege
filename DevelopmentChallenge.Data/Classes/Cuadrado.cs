using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado :  FormaGeometrica
    {
        public decimal Lado { get; set; }
        public Cuadrado(decimal lado)
        {
            Lado = lado;
        }
        public override decimal CalcularPerimetro() 
            => Lado * 4;

        public override decimal CalcularArea()
            => Lado * Lado;

        public override string TraducirForma(int tipo, int cantidad, int idioma)
            => ""; // TODO - Segregar responsabilidade de Idoma para uma classe separada
    }
}
