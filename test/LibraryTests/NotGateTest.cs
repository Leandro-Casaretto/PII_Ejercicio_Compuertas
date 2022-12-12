using NUnit.Framework;

namespace Library
{
    
    [TestFixture]
    public class NotGateTest
    {  

        [Test]
        public void NotTrueGate()
        {
            LogicInput True = new LogicInput(true);
            NotGate not1 = new NotGate("Not_1");

            not1.AddInput(True);

            Assert.False(not1.Calculate());
            
        }

        [Test]
        public void NotFalseTest()
        {
            LogicInput False = new LogicInput(false);
            NotGate not1 = new NotGate("Not_1");

            not1.AddInput(False);

            Assert.True(not1.Calculate());
        }

    }
}