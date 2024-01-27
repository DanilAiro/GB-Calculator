using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

      if (InputText.Text == "" || name == "C")
      {
        calculator.C();
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

          default:
            MessageBox.Show("Ошибка нажатия кнопки!");
            InputText.Text = string.Empty;
            break;
        }
      }
    }
  }
}
