using NUnit.Framework;

namespace Library
{
    
    [TestFixture]
    public class OrGateTest
    {  

        [Test]
        public void OrTrueTest()
        {
            /// <summary>
            /// Hardcodeamos el LogicInput
            /// </summary>
            
            LogicInput True = new LogicInput(true);
            
            /// <summary>
            /// Creamos la OrGate
            /// </summary>
            
            OrGate or1 = new OrGate ("OR_1");

            or1.AddInput(True);
            or1.AddInput(True);
            
            Assert.True(or1.Calculate());

            LogicInput False = new LogicInput(false);
        }

        [Test]
        public void OrFalseTest()
        {
            /// <summary>
            /// Hardcodeamos el LogicInput
            /// </summary>
            
            LogicInput False = new LogicInput(false);
            LogicInput True = new LogicInput(true);

            /// <summary>
            /// Creamos la OrGate
            /// </summary>

            OrGate or2 = new OrGate ("OR_2");
            
            or2.AddInput(False);
            or2.AddInput(True);
            
            Assert.True(or2.Calculate());
        }

    }
}