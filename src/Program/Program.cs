using System;
using System.Collections.Generic;

namespace Library
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
        
        AndGate and1 = new AndGate("and1");

        OrGate or1 = new OrGate("or1");

        NotGate not1 = new NotGate("not1");

        IInput logicInput1 = new LogicInput(false);

        IInput logicInput2 = new LogicInput(true);

        IInput logicInput3 = new LogicInput(false);

        and1.AddInput(logicInput1);
        and1.AddInput(logicInput2);


        or1.AddInput(logicInput1);
        or1.AddInput(and1);

        not1.AddInput(or1);

        Console.WriteLine($"El resultado es {or1.Calculate()}");



        }
    }
}