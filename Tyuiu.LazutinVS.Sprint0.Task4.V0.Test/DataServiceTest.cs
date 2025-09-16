using Tyuiu.LazutinVS.Sprint0.Task3.V0.Lib;
namespace Tyuiu.LazutinVS.Sprint0.Task3.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheckedSubstractionValid()
        {
            Assert.AreEqual(5, DataService.Addition(10, 5));
        }

        [TestMethod]
        public void CheckedMuplitplicationValid()
        {
            Assert.AreEqual(50, DataService.Addition(10, 5));
        }

        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Addition(9, 3));
        }
    }
}