using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;

namespace CalculatorWPF
{
  class CalculatorArgs:EventArgs
  {
    public float answer = 0;
  }

  class CalculatorAriphmetic
  {
    public event EventHandler<CalculatorArgs> Result;
    public float result { get; private set; } = 0;
    public Stack<float> results = new Stack<float>();

    private void Calculation()
    {
      Result?.Invoke(this, new CalculatorArgs() { answer = result });
    }

    public virtual void Add(float value)
    {
      results.Push(result);
      result += value;
      Calculation();
    }

    public virtual void Sub(float value)
    {
      results.Push(result);
      result -= value;
      Calculation();
    }

    public virtual void Mult(float value)
    {
      results.Push(result);
      result *= value;
      Calculation();
    }

    public virtual void Div(float value)
    {
      results.Push(result);
      result /= value;
      Calculation();
    }

    public virtual void Cancel()
    {
      if (results.Count > 0)
      {
        result = results.Pop();
        Calculation();
      }
    }

    public virtual void Clear()
    {
      results.Clear();
      result = 0;
      Calculation();
    }
    
  }
}
