using System;
using System.Collections.Generic;

namespace Library;

/// <summary>
/// Clase NotGate, hereda de la clase Gate
/// </summary>

public class NotGate : Gate
{
    public NotGate(string name) : base(name)
    {
        
    }

    /// <summary>
    /// En este caso si hacemos la implementación del método "Calculate", orientado a lo que necesita la clase NotGate
    /// </summary>
    public override bool Calculate()
    {
        ///<summary>
        /// Excepción generada cuando no hay un input en la compuerta
        ///<summary>
        
        if (Inputs.Count != 1)
        {
            throw new IndexOutOfRangeException("ERROR. SE NECESITA UN INPUT");
        }

        return !this.Inputs[0].Calculate(); // Negamos el primer elemento (el input)
        
    }

}