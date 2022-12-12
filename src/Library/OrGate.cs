using System;
using System.Collections.Generic;

namespace Library;

public class OrGate : Gate
{
    public OrGate(string name) : base(name)
    {
        
    }

    public override bool Calculate()
    {
        bool resultado = true;

        foreach (IInput elemento in this.Inputs)
        {
            resultado = resultado || elemento.Calculate();
        }

        return resultado;
        
    }

}