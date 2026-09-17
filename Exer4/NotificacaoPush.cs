using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Exer4
{
    internal class NotificacaoPush : Inotificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando Notificação Push para o app...");
        }
    }
}
