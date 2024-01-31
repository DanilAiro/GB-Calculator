using System;
using System.Windows;

namespace CalculatorWPF
{
  /// <summary>
  /// Логика взаимодействия для MainWindow.xaml
  /// </summary>
  public partial class MainWindow:Window
  {

    Calculator calculator;
    public MainWindow()
    {
      InitializeComponent();
      calculator = new Calculator();
      calculator.Result += Calculator_Result;
    }

    private void Calculator_Result(object sender, CalculatorArgs e)
    {
      Answer.Content = e.answer;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      bool parse = int.TryParse(InputText.Text, out int value);
      var name = (e.Source as FrameworkElement).Name;

      if (InputText.Text == "" || name == "Clear")
      {
        calculator.Clear();
        InputText.Text = String.Empty;
      }
      else
      {
        if (!parse)
        {
          MessageBox.Show("Неверно ввели данные!");
          InputText.Text = string.Empty;
        }

        switch (name)
        {
          case "Add":
            calculator.Add(value);
            break;

          case "Sub":
            calculator.Sub(value);
            break;

          case "Mult":
            calculator.Mult(value);
            break;

          case "Div":
            calculator.Div(value);
            break;

          case "Cancel":
            calculator.Cancel();
            break;

          default:
            MessageBox.Show("Ошибка нажатия кнопки!");
            InputText.Text = string.Empty;
            break;
        }
      }
    }

    private void Window_Closed(object sender, EventArgs e)
    {
      calculator.Result -= Calculator_Result;
    }
  }
}
