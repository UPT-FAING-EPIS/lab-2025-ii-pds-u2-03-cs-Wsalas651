namespace Comportamiento.Domain.Strategy
{
    public class Contexto
    {
        private IOperacion _operacion;

        public Contexto(IOperacion operacion)
        {
            _operacion = operacion;
        }

        public int EjecutarOperacion(int a, int b)
        {
            return _operacion.Ejecutar(a, b);
        }
    }
}
