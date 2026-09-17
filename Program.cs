using Polimorfismo.Exer1;
using System.Net.Quic;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Geometria g = new Geometria();

            double AreaQuadrado = g.CalcularArea(5);
            double AreaRetangulo = g.CalcularArea(8, 20);
            double AreaCirculo = g.CalcularArea(5, true);

            Console.WriteLine("Área do Quadrado: " + AreaQuadrado);
            Console.WriteLine("Área do Retângulo: " + AreaRetangulo);
            Console.WriteLine("Área do Círculo: " + AreaCirculo);


        }
    }
}
