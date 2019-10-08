using DecoradorMSG.Decorador;
using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using DecoradorMSG.Componente;

namespace DecoradorMSG.DecoradorConcreto
{
    public class Gmail : Decorator
    {
        // Instancia de la clase vehiculo
        private readonly Mensaje _msg;

        public Gmail(Mensaje msg)
        {
            _msg = msg;
        }

        public override void EnviarMensaje(string mensaje, string destinatario)
        {
            _msg.EnviarMensaje(mensaje, destinatario);
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("jvicius@gmail.com", ConfigurationManager.AppSettings["emailpass"]),
                EnableSsl = true
            };

            try
            {
                client.Send("jvicius@gmail.com", destinatario, "c# GMailService", mensaje);
            }
            catch (Exception e)
            {

            }

            Console.WriteLine("Sending using gmail");
        }
    }
}
