namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        public TrianguloEquilatero(int tipo, decimal ancho) : base(tipo, ancho)
        {
        }

        public override decimal CalcularArea()
        {
            return  this.ancho * 3;

        }

    }
