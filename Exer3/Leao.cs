using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Exer3
{
    internal class Leao : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Leão: ROAR");
        }
    }
}
