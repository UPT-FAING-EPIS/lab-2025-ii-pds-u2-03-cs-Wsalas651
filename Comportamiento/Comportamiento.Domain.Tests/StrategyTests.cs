using Comportamiento.Domain.Strategy;
using Xunit;

namespace Comportamiento.Domain.Tests
{
    public class StrategyTests
    {
        [Fact]
        public void SumarTest()
        {
            var contexto = new Contexto(new Sumar());
            Assert.Equal(5, contexto.EjecutarOperacion(2, 3));
        }

        [Fact]
        public void RestarTest()
        {
            var contexto = new Contexto(new Restar());
            Assert.Equal(1, contexto.EjecutarOperacion(3, 2));
        }

        [Fact]
        public void MultiplicarTest()
        {
            var contexto = new Contexto(new Multiplicar());
            Assert.Equal(6, contexto.EjecutarOperacion(2, 3));
        }
    }
}
