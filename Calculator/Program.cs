
namespace Calculator;

internal class Program
{
  static void Main(string[] args)
  {
    Calculator calculator = new();
    calculator.Result += Calculator_Resalt;

    calculator.Cancel();

    calculator.Result -= Calculator_Resalt;

  }

  private static void Calculator_Resalt(object? sender, CalculatorArgs e)
  {
    Console.WriteLine($"Результат = {e.answer}");
  }
}
