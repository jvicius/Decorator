using Decorator.Componente;

namespace Decorator.Decorador
{
    public abstract  class Decorator : Vehiculo
    {
        // Declaramos el método como abstracto para que todos los decoradores lo
        // reimplementen.
        public abstract override string Descripcion();
    }
}
