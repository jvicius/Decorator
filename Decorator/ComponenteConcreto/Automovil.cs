using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Componente;

namespace Decorator.ComponenteConcreto
{
    public class Automovil : Vehiculo
    {

        public Automovil()
        {
            descripcion = "Automovil";
        }

        public override int VelocidadMaxima()
        {
            return 180;
        }

        public override double Consumo()
        {
            return 6.2;
        }
    }
}
