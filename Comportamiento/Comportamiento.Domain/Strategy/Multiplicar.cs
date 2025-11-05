namespace Comportamiento.Domain.Strategy
{
    public class Multiplicar : IOperacion
    {
        public int Ejecutar(int a, int b) => a * b;
    }
}
