using Polimorfismo.Exer1;
using Polimorfismo.Exer3;
using System.Net.Quic;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Geometria g = new Geometria();

            //double AreaQuadrado = g.CalcularArea(5);
            //double AreaRetangulo = g.CalcularArea(8, 20);
            //double AreaCirculo = g.CalcularArea(5, true);

            //Console.WriteLine("Área do Quadrado: " + AreaQuadrado);
            //Console.WriteLine("Área do Retângulo: " + AreaRetangulo);
            //Console.WriteLine("Área do Círculo: " + AreaCirculo);

            List<Animal> listAnimal = new List<Animal>();

            listAnimal.Add(new Leao());
            listAnimal.Add(new Macaco());
            listAnimal.Add(new Cobra());

            foreach (Animal animal in listAnimal)
            {
                animal.EmitirSom();
            }
        }
    }
}
