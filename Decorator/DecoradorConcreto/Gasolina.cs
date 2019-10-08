using Decorator.Componente;

namespace Decorator.DecoradorConcreto
{
    public class Gasolina : Decorador.Decorator
    {
        // Instancia de la clase vehiculo
        private readonly Vehiculo _vehiculo;

        // Constructor que recibe el vehículo que encapsulará el decorator
        public Gasolina(Vehiculo vehiculo)
        {
            this._vehiculo = vehiculo;
        }

        // Los métodos utilizan la información del objeto encapsulado y le
        // incorporan su propia funcionalidad.
        public override string Descripcion()
        {
            return _vehiculo.Descripcion() + " Gasolina";
        }

        // Un vehículo gasolina proporciona más potencia, por lo que "decora" el
        // vehiculo añadiendo mayor velocidad máxima
        public override int VelocidadMaxima()
        {
            return _vehiculo.VelocidadMaxima() + 60;
        }

        // La gasolina es menos energética que el diesel, por lo que el consumo
        // de combustible es mayor. Decoraremos el vehículo añadiéndole un consumo
        // de 1.2 litros adicionales a los 100 km.
        public override double Consumo()
        {
            return _vehiculo.Consumo() + 1.2;
        }
    }
}
