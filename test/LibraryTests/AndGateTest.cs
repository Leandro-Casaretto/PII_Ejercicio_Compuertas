using NUnit.Framework;

namespace Library
{
    
    [TestFixture]
    public class AndGateTest
    {  

        [Test]
        public void AndTrueTest()
        {
            LogicInput True = new LogicInput(true);
            AndGate and1 = new AndGate ("And_1");
            
            and1.AddInput(True);
            and1.AddInput(True);
            
            Assert.True(and1.Calculate());
        }

        [Test]
        public void AndFalseTest()
        {
            LogicInput False = new LogicInput(false);
            LogicInput True = new LogicInput(true);

            AndGate and1 = new AndGate ("And_1");
            
            and1.AddInput(False);
            and1.AddInput(True);
            
            Assert.False(and1.Calculate());
        }

    }
}