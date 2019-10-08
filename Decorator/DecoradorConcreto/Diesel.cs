using Decorator.Componente;

namespace Decorator.DecoradorConcreto
{
    public class Diesel : Decorador.Decorator
    {
        // Instancia de la clase vehiculo
        private readonly Vehiculo _vehiculo;

        // Constructor que recibe el vehículo que encapsulará el decorator
        public Diesel(Vehiculo vehiculo)
        {
            this._vehiculo = vehiculo;
        }

        
        public override string Descripcion()
        {
            return _vehiculo.Descripcion() + " Diesel";
        }

        public override int VelocidadMaxima()
        {
            return _vehiculo.VelocidadMaxima() + 20;
        }

        public override double Consumo()
        {
            return _vehiculo.Consumo() - 0.8;
        }
    }
}
