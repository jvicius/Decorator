using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Componente;
using Decorator.ComponenteConcreto;
using Decorator.DecoradorConcreto;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo moto = new Motocicleta();
            Vehiculo auto = new Automovil();

            MostrarCaracteristicas(moto);
            MostrarCaracteristicas(auto);
            Console.ReadKey();
            
            moto = new Gasolina(moto);
            auto = new Diesel(auto);

            MostrarCaracteristicas(moto);
            MostrarCaracteristicas(auto);

            Console.ReadKey();

        }

        private static void MostrarCaracteristicas(Vehiculo v)
        {
            Console.WriteLine(
                $"{v.Descripcion()}\n\t- Velocidad punta de {v.VelocidadMaxima()} km/h \n\tConsumo medio de {v.Consumo()} l/100km\n");
        }
    }
}
