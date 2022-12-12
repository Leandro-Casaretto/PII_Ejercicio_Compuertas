using System;
using System.Collections.Generic;

namespace Library;

//Esta clase es para cuando el input es un valores logicos

public class LogicInput : IInput
{
    public bool Valor {get; set;} 
    
    public LogicInput(bool valor)
    {
        this.Valor = valor;

    }

    public bool Calculate()
    {
        return this.Valor;
    }    

}