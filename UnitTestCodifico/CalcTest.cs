using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodificoConsola;

namespace UnitTestCodifico
{
    [TestClass]
    public class CalcTest
    {
        //Arrange
        [DataRow(2, 12.57)]
        [DataRow(4, 50.27)]
        [TestMethod]
        public void AreaCirculo_ShouldReturnAreaCirclePositiveRadio(double r, double expected )
        {
         
            //Act
            Circulo circulo = new Circulo();
            double res = circulo.AreaCirculo(r);

            //Assert

            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void AreaRectangulo_ShouldReturnAreaRectanglePositiveBaseHeight()
        {
            //Arrange
            double b = 2;
            double h = 5;
            double expected = 10;

            //Act
            Rectangulo rectangulo = new Rectangulo();
            double res = rectangulo.AreaRectangulo(b,h);

            //Assert

            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void AreaTriangulo_ShouldReturnAreaTrianglePositiveBaseHeight()
        {
            //Arrange
            double b = 20;
            double h = 50;
            double notExpected = 499;

            //Act
            Triangulo triangulo = new Triangulo();
            double res = triangulo.AreaTriangulo(b, h);

            //Assert

            Assert.AreNotEqual(notExpected, res);
        }
    }
}