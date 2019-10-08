using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoradorMSG.Componente;
using DecoradorMSG.ComponenteConcreto;
using DecoradorMSG.DecoradorConcreto;

namespace DecoradorMSG
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensaje msg = new MensajeConcreto();
            
            msg.EnviarMensaje("hola decorador", "jvicius@gmail.com");

            Console.ReadKey();

            msg = new Gmail(msg);
            msg.EnviarMensaje("hola decorador", "jvicius@gmail.com");

            Console.ReadKey();

            msg = new Yahoo(msg);
            msg.EnviarMensaje("hola decorador", "jvicius@gmail.com");

            Console.ReadKey();

        }
    }
}
