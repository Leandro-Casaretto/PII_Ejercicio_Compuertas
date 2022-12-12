using NUnit.Framework;

namespace Library
{
    
    [TestFixture]
    public class OrGateTest
    {  

        [Test]
        public void OrTrueTest()
        {
            LogicInput True = new LogicInput(true);
            OrGate or1 = new OrGate ("OR_1");

            or1.AddInput(True);
            or1.AddInput(True);
            
            Assert.True(or1.Calculate());

            LogicInput False = new LogicInput(false);
        }

        [Test]
        public void OrFalseTest()
        {
            LogicInput False = new LogicInput(false);
            OrGate or1 = new OrGate ("OR_1");
            
            or1.AddInput(False);
            or1.AddInput(False);
            
            Assert.True(or1.Calculate());
        }

    }
}