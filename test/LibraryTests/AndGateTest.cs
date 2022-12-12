using NUnit.Framework;

namespace Library
{
    
    [TestFixture]
    public class AndGateTest
    {  

        [Test]
        
        public void AndTrueTest()
        {
            /// <summary>
            /// Hardcodeamos el LogicInput
            /// </summary>
            
            LogicInput True = new LogicInput(true);
            
            /// <summary>
            /// Creamos la AndGate
            /// </summary>
            
            AndGate and1 = new AndGate ("And_1");
            
            and1.AddInput(True);
            and1.AddInput(True);
            
            Assert.True(and1.Calculate());
        }

        [Test]
        public void AndFalseTest()
        {
            /// <summary>
            /// Hardcodeamos los LogicInput
            /// </summary>
            /// 
            LogicInput False = new LogicInput(false);
            LogicInput True = new LogicInput(true);

            /// <summary>
            /// Creamos la AndGate
            /// </summary>
            
            AndGate and1 = new AndGate ("And_1");
            
            and1.AddInput(False);
            and1.AddInput(True);
            
            Assert.False(and1.Calculate());
        }

    }
}