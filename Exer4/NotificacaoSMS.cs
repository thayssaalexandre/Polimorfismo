using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo.Exer4
{
    internal class NotificacaoSMS : Inotificacao
    {
        public override void Enviar()
        {
            Console.WriteLine("Enviando Notificação por SMS...");
        }
    }
}
