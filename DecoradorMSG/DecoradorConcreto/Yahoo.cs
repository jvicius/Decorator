using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using DecoradorMSG.Componente;
using DecoradorMSG.Decorador;

namespace DecoradorMSG.DecoradorConcreto
{
    public class Yahoo : Decorator
    {
        // Instancia de la clase vehiculo
        private readonly Mensaje _msg;

        public Yahoo(Mensaje msg)
        {
            _msg = msg;
        }

        public override void EnviarMensaje(string mensaje, string destinatario)
        {
            _msg.EnviarMensaje(mensaje, destinatario);
            var client = new SmtpClient
            {
                Host = "smtp.mail.yahoo.com",
                Port = 465,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential
                    ("eq9lce1@yahoo.com.mx", ConfigurationManager.AppSettings["emailpass"]),
                EnableSsl = true
            };

            try
            {
                client.Send("jvicius@gmail.com", mensaje, "c# GMailService", destinatario);
            }
            catch (Exception e)
            {

            }

            Console.WriteLine("Sending using yahoo mail");
        }
    }
}
