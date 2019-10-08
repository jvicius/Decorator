using System;
using DecoradorMSG.Componente;

namespace DecoradorMSG.ComponenteConcreto
{
    public class MensajeConcreto : Mensaje
    {
        public override void EnviarMensaje(string mensaje, string destinatario)
        {
            Console.WriteLine("Sending Message");
        }
    }
}
