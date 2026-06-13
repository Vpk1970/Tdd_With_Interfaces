using Tdd_With_Interfaces;

namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange & act
            IClass1<int> c = new Class_Product<int>("Test");

            // Assert
            Assert.AreEqual("Test", c.Name);
            Assert.AreEqual(2, c.Calculate(1, 2));
        }

        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            IClass1<double> c = new Class_Product<double>();

            // Act
            var result = c.Calculate(2.5, 4.0);

            // Assert
            Assert.AreEqual(10.0, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            IClass2<decimal> c = new CalculateSqr<decimal>();
            // Act
            var result = c.CalcSqr(4.0m);
            // Assert
            //Assert.AreEqual("DecimalTest", c.Name);
            Assert.AreEqual(16.0m, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            IName<string> c = new Name<string>("TestName");


            // Act
            var name = "TestName";

            //var result = c.Calculate(3, 5);
            // Assert
            Assert.AreEqual(name, c.Name);

            //Assert.AreEqual(15, result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            // Arrange
            IIndexer<string> c = new Indexer<string>();
            // Act
            var result = c; // Just to use the variable and avoid warnings

            // Assert
            //Assert.IsNotNull(result);
            Assert.AreEqual("", result[0]);

        }
    }
}


