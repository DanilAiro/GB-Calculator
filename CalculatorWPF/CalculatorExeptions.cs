using System;
using System.Windows;

namespace CalculatorWPF
{
  class CalculatorExeptions : CalculatorAriphmetic
  {
    public override void Add(float value)
    {
      try
      {
        base.Add(value);
      } 
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
      }
    }

    public override void Sub(float value)
    {
      try
      {
        base.Sub(value); 
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
      }
    }

    public override void Mult(float value)
    {
      try
      {
        base.Mult(value);
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
      }
    }

    public override void Div(float value)
    {
      try
      {
        base.Div(value);
      }
      catch (Exception e)
      {
        MessageBox.Show(e.Message);
      }
    }

    public override void Cancel()
    {
      base.Cancel();
    }

    public override void Clear()
    {
      base.Clear();
    }
  }
}
