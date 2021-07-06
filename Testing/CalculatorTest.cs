using ExampleTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing
{
    public class CalculatorTest
    {
        [Fact]
        public void TestSuma()
        {
            //Arrange
            CalculadoraService service = new CalculadoraService();

            //Act
            int resultado = service.suma(2, 3);

            //Assert
            Assert.Equal(5, resultado);

        }

        [Fact]
        public void TestResta()
        {

            CalculadoraService service = new CalculadoraService();

            int resultado = service.resta(5, 3);

            Assert.Equal(2, resultado);

        }

        [Fact]
        public void TestDivision()
        {

            CalculadoraService service = new CalculadoraService();

            int resultado = service.division(20, 10);

            Assert.Equal(2, resultado);

        }

        [Fact]
        public void TestMultiplicacion()
        {

            CalculadoraService service = new CalculadoraService();

            int resultado = service.multiplicacion(2, 3);

            Assert.Equal(6, resultado);

        }

        [Fact]
        public void TestLogin()
        {
            Login service = new Login();

            var result = service.login("miguel", "123456");

            Assert.True(result);
        }
      
    }
}
