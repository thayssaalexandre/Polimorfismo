using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Polimorfismo.Exer4
{
    internal class NotificacaoEmail : Inotificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando Notificação por E-mail...");
        }
    }
}
