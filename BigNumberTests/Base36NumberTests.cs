using BigNumber;

namespace BigNumberTests
{
    [TestClass]
    public class Base36NumberTests
    {
        [TestMethod]
        public void CanCreateNewBase36NumberFromString()
        {
            var number = new Base36Number("2S");
            Assert.IsTrue(number.IntValue > 0);
        }

        [TestMethod]
        public void CanCreateNewBase36NumberFromGuid()
        {
            var number = Guid.NewGuid().ToBase36Number();
            Assert.IsTrue(number.IntValue != 0);
        }

        [TestMethod]
        public void CanCreateNewBase36NumberFromIntNumber()
        {
            var number = 100.ToBase36Number();
            Assert.IsTrue(number.IntValue > 0);
        }

        [TestMethod]
        public void CanCreateNewBase36NumberFromLongNumber()
        {
            var number = ((long)1000).ToBase36Number();
            Assert.IsTrue(number.IntValue > 0);
        }

        [TestMethod]
        public void CanCreateNewBase36NumberFromDecimalNumber()
        {
            var number = ((decimal)1000.1).ToBase36Number();
            Assert.IsTrue(number.IntValue > 0);
        }

        [TestMethod]
        public void CanGetDecimalFromABase36NumberOfADecimal()
        {
            var number = (10M).ToBase36Number();
            Assert.AreEqual(10, number.AsDecimal());
        }

        [TestMethod]
        public void CanCreateNewBase36NumberFromString_02()
        {
            var number = new Base36Number("H2DEFX8YV");
            Assert.AreEqual(48144768197287, number.IntValue);
        }

        [TestMethod]
        public void CanConvertToBase36FromNumber_01()
        {
            var number = 64.ToBase36Number();
            Assert.AreEqual("1S", number.ToString());
        }

        [TestMethod]
        public void CanConvertToBase36FromNumber_02()
        {
            var number = 4525.ToBase36Number();
            Assert.AreEqual("3HP", number.ToString());
        }

        [TestMethod]
        public void CanConvertToBase36FromString()
        {
            var number = new Base36Number("3HP");
            Assert.AreEqual(4525, number.IntValue);
        }
    }
}