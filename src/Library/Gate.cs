using System;
using System.Collections.Generic;

namespace Library;
public abstract class Gate : IInput //Esto es una implementación, ya que es de interfaz a clase
{
    public string Name { get; set; }
    public List<IInput> Inputs { get; set; }
    
    public Gate(string name)
    {
        this.Name = name;
        this.Inputs = new List<IInput>();
    }
    
    public void AddInput(IInput IInput)
    {
        this.Inputs.Add(IInput);

    }

    public abstract bool Calculate();

}