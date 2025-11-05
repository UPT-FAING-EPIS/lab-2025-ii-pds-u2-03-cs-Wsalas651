namespace Comportamiento.Domain.Strategy
{
    public class Sumar : IOperacion
    {
        public int Ejecutar(int a, int b) => a + b;
    }
}
