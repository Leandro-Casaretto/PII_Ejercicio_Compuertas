using System;
using System.Collections.Generic;

namespace Library;

/// <summary>
/// Clase creada para los inputs de valores lógicos
/// </summary>

public class LogicInput : IInput
{
    public bool Valor {get; set;} 
    
    /// <summary>
    /// Este método únicamente devuelve el valor
    /// </summary>
    /// <param name="valor"></param>
    public LogicInput(bool valor)
    {
        this.Valor = valor;

    }

    public bool Calculate()
    {
        return this.Valor;
    }    

}