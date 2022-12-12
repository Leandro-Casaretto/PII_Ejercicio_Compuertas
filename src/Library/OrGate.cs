using System;
using System.Collections.Generic;

namespace Library;

/// <summary>
/// Clase OrGate, hereda de la clase Gate
/// </summary>
public class OrGate : Gate
{
    public OrGate(string name) : base(name)
    {
        
    }

    /// <summary>
    /// En este caso, sí hacemos la implementación del método "Calculate", orientado a lo que necesita la clase OrGate 
    /// </summary>
    public override bool Calculate()
    {
        ///<summary>
        /// Excepción generada cuando no hay dos inputs en la compuerta
        ///<summary>
        
        if (Inputs.Count != 2)
        {
            throw new IndexOutOfRangeException("ERROR. SE NECESITAN DOS INPUTS");
        }

        bool resultado = true;

        foreach (IInput elemento in this.Inputs)
        {
            resultado = resultado || elemento.Calculate();
        }

        return resultado;
        
    }

}