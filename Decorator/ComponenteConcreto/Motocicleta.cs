using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Componente;

namespace Decorator.ComponenteConcreto
{
    public class Motocicleta : Vehiculo
    {
        public Motocicleta()
        {
            descripcion = "Motocicleta";
        }

        // Funcionalidad básica
        public override int VelocidadMaxima()
        {
            return 160;
        }

        // Funcionalidad básica
        public override double Consumo()
        {
            return 7.5;
        }
    }
}
