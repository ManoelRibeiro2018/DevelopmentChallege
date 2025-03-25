namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
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

        public override string TraducirForma(int cantidad, int idioma)
            => Idioma.Traduzir("Cuadrado", "Square", cantidad, idioma);
    }
}
