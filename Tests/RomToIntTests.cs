using NUnit.Framework;
using DataWorksTasks;

namespace Tests
{
    public class RomToIntTests
    {
        [Test]
        public void ConvertTest()
        {
            Assert.AreEqual(1, RomToInt.Convert("I")); 
            Assert.AreEqual(2,RomToInt.Convert("II"));
            Assert.AreEqual(3,RomToInt.Convert("III"));
            Assert.AreEqual(4,RomToInt.Convert("IV"));
            Assert.AreEqual(5,RomToInt.Convert("V"));
            Assert.AreEqual(6,RomToInt.Convert("VI"));
            Assert.AreEqual(7,RomToInt.Convert("VII"));
            Assert.AreEqual(8,RomToInt.Convert("VIII"));
            Assert.AreEqual(9,RomToInt.Convert("IX"));
            Assert.AreEqual(10,RomToInt.Convert("X"));
            Assert.AreEqual(31,RomToInt.Convert("XXXI"));
            Assert.AreEqual(46,RomToInt.Convert("XLVI"));
            Assert.AreEqual(99,RomToInt.Convert("XCIX"));
            Assert.AreEqual(583,RomToInt.Convert("DLXXXIII"));
            Assert.AreEqual(888,RomToInt.Convert("DCCCLXXXVIII"));
            Assert.AreEqual(1668,RomToInt.Convert("MDCLXVIII"));
            Assert.AreEqual(1989,RomToInt.Convert("MCMLXXXIX"));
            Assert.AreEqual(2010,RomToInt.Convert("MMX"));
            Assert.AreEqual(2011,RomToInt.Convert("MMXI"));
            Assert.AreEqual(3000,RomToInt.Convert("MMM"));
        }
    }
}