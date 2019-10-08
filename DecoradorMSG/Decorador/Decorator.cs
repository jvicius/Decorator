using DecoradorMSG.Componente;

namespace DecoradorMSG.Decorador
{
    public abstract class Decorator : Mensaje
    {
        public abstract override void EnviarMensaje(string mensaje, string destinatario);
    }
}
