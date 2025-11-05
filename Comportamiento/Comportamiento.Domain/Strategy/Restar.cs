namespace Comportamiento.Domain.Strategy
{
    public class Restar : IOperacion
    {
        public int Ejecutar(int a, int b) => a - b;
    }
}
