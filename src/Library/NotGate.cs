using System;
using System.Collections.Generic;

namespace Library;

public class NotGate : Gate
{
    public NotGate(string name) : base(name)
    {
        
    }

    public override bool Calculate()
    {
        return !this.Inputs[0].Calculate();
        
    }

}