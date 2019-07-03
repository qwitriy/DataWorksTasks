using NUnit.Framework;
using DataWorksTasks;

namespace Tests
{
    public class BracketsVerifyTests
    {
        [Test]
        public void VerifyTest()
        {
            Assert.IsTrue(BracketsVerificator.Verify("()"));
            Assert.IsFalse(BracketsVerificator.Verify("(("));
            Assert.IsFalse(BracketsVerificator.Verify("))"));
            Assert.IsFalse(BracketsVerificator.Verify(")("));
            Assert.IsTrue(BracketsVerificator.Verify("((1+3)()(4+(3-5)))"));
        }
    }
}
