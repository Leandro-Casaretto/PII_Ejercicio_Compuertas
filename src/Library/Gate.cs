using System;
using System.Collections.Generic;

namespace Library;

/// <summary>
/// En esta clase realizamos la implementación de la interaz IInput
/// </summary>
public abstract class Gate : IInput 
{
    /// <summary>
    /// Establecemos las properties
    /// </summary>
    public string Name { get; set; }
    public List<IInput> Inputs { get; set; }
    
    /// <summary>
    /// Generamos el constructor
    /// </summary>
    public Gate(string name)
    {
        this.Name = name;
        this.Inputs = new List<IInput>();
    }
    
    /// <summary>
    /// Este método agrega el input
    /// </summary>
    /// <param name="IInput"></param>
    public void AddInput(IInput IInput)
    {
        this.Inputs.Add(IInput);

    }

    /// <summary>
    /// Método abstracto para hacer el calculo (sin implementación)
    /// </summary>
    public abstract bool Calculate();

}