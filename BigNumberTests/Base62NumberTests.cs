using BigNumber;

namespace BigNumberTests
{
    [TestClass]
    public class Base62NumberTests
    {
        [TestMethod]
        public void CanCreateNewBase62NumberFromString()
        {
            var number = new Base62Number("2S");
            Assert.IsTrue(number.IntValue > 0);
        }

        [TestMethod]
        public void CanCreateNewBase62NumberFromGuid()
        {
            var number = Guid.NewGuid().ToBase62Number();
            Assert.IsTrue(number.IntValue != 0);
        }

        [TestMethod]
        public void CanCreateNewBase62NumberFromIntNumber()
        {
            var number = 100.ToBase62Number();
            Assert.IsTrue(number.IntValue > 0);
        }

        [TestMethod]
        public void CanCreateNewBase62NumberFromLongNumber()
        {
            var number = ((long)100).ToBase62Number();
            Assert.IsTrue(number.IntValue > 0);
        }

        [TestMethod]
        public void CanCreateNewBase62NumberFromDecimalNumber()
        {
            var number = ((decimal)1000.1).ToBase62Number();
            Assert.IsTrue(number.IntValue > 0);
        }

        [TestMethod]
        public void CanGetDecimalFromABase62NumberOfADecimal()
        {
            var number = (10M).ToBase62Number();
            Assert.AreEqual(10, number.AsDecimal());
        }

        [TestMethod]
        public void CanCreateNewBase62NumberFromString_02()
        {
            var number = new Base62Number("H2DEFX8YV");
            Assert.AreEqual(3719576482620643, number.IntValue);
        }

        [TestMethod]
        public void CanConvertToBase62FromNumber_01()
        {
            var number = 64.ToBase62Number();
            Assert.AreEqual("12", number.ToString());
        }

        [TestMethod]
        public void CanConvertToBase62FromNumber_02()
        {
            var number = 4525.ToBase62Number();
            Assert.AreEqual("1Az", number.ToString());
        }

        [TestMethod]
        public void CanConvertToBase62FromString()
        {
            var number = new Base62Number("1Az");
            Assert.AreEqual(4525, number.IntValue);
        }
    }
}