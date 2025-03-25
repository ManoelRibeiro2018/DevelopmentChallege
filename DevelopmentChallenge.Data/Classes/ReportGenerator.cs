using DevelopmentChallenge.Data.Enum;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class ReportGenerator
    {
        public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            if (!formas.Any())
                return idioma == (int)IdiomaEnum.Castellano ? "<h1>Lista vacía de formas!</h1>" : "<h1>Empty list of shapes!</h1>";

            var sb = new StringBuilder();
            sb.Append(idioma == (int)IdiomaEnum.Castellano ? "<h1>Reporte de Formas</h1>" : "<h1>Shapes report</h1>");

            var resumen = formas.GroupBy(f => f.GetType())
                                .Select(g => new {
                                    Forma = g.First(),
                                    Cantidad = g.Count(),
                                    Area = g.Sum(f => f.CalcularArea()),
                                    Perimetro = g.Sum(f => f.CalcularPerimetro())
                                });

            foreach (var item in resumen)
            {
                sb.Append($"{item.Cantidad} {item.Forma.TraducirForma(idioma, item.Cantidad)} | Area {item.Area:#.##} | Perimetro {item.Perimetro:#.##} <br/>");
            }

            sb.Append("TOTAL:<br/>");
            sb.Append($"{formas.Count} {(idioma == (int)IdiomaEnum.Castellano ? "formas" : "shapes")} ");
            sb.Append((idioma == (int)IdiomaEnum.Castellano ? "Perimetro " : "Perimeter ") + resumen.Sum(r => r.Perimetro).ToString("#.##") + " ");
            sb.Append("Area " + resumen.Sum(r => r.Area).ToString("#.##"));

            return sb.ToString();
        }
    }
}
