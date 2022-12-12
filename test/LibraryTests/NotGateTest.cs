using NUnit.Framework;

namespace Library
{
    
    [TestFixture]
    public class NotGateTest
    {  

        [Test]
        public void NotTrueGate()
        {
            /// <summary>
            /// Hardcodeamos el LogicInput
            /// </summary>
            /// 
            LogicInput True = new LogicInput(true);
            
            /// <summary>
            /// Creamos la NotGate
            /// </summary>
            
            NotGate not1 = new NotGate("Not_1");

            not1.AddInput(True);

            Assert.False(not1.Calculate());
            
        }

        [Test]
        public void NotFalseTest()
        {
            /// <summary>
            /// Hardcodeamos el LogicInput
            /// </summary>
            
            LogicInput False = new LogicInput(false);
            
            /// <summary>
            /// Creamos la NotGate
            /// </summary>
            
            NotGate not1 = new NotGate("Not_1");

            not1.AddInput(False);

            Assert.True(not1.Calculate());
        }

    }
}