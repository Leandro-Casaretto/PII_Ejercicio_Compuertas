using System;
using System.Collections.Generic;

namespace Library;

/// <summary>
/// Clase AndGate, hereda de la clase Gate
/// </summary>

public class AndGate : Gate
{
    public AndGate(string name) : base(name)
    {
        
    }

    /// <summary>
    /// /// En este caso, sí hacemos la implementación del método "Calculate", orientado a lo que necesita la clase AndGate
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
            resultado = resultado && elemento.Calculate();
        }

        return resultado;
        
    }

}