﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWPF
{
  class CalculatorArgs : EventArgs
  {
    public int answer = 0;
  }
  internal class Calculator
  {
    public event EventHandler<CalculatorArgs> Result;

    public int result { get; private set; } = 0;
    Stack<int> results = new Stack<int>();


    private void Calculation()
    {
      Result?.Invoke(this, new CalculatorArgs() { answer = result });
    }

    public void Add(int value)
    {
      results.Push(value);
      result += value;
      Calculation();
    }

    public void Sub(int value)
    {
      results.Push(value);
      result -= value;
      Calculation();
    }

    public void Mult(int value)
    {
      results.Push(value);
      result *= value;
      Calculation();
    }

    public void Div(int value)
    {
      results.Push(value);
      result /= value;
      Calculation();
    }

    public void Cancel()
    {
      if (results.Count > 0)
      {
        result = results.Pop();
        Calculation();
      }
    }

    public void C()
    {
      results.Clear();
      result = 0;
      Calculation();
    }
  }
}
