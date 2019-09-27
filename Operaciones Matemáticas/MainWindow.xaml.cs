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

namespace Operaciones_Matemáticas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Operando1_TextBox.Text = "0";
            Operando2_TextBox.Text = "0";
            Resultado_TextBox.Text = "0";
            Resultado_TextBox.IsReadOnly = false;
        }

        private void Limpiar_Button_Click(object sender, RoutedEventArgs e)
        {
            Operando1_TextBox.Text = "0";
            Operando2_TextBox.Text = "0";
            Resultado_TextBox.Text = "0";
        }
        
        private void Operaciones_GroupBox_Check(object sender, RoutedEventArgs e)
        {
            if (Suma_Button.IsChecked == true)
                Resultado_TextBox.Text = (double.Parse(Operando1_TextBox.Text) + double.Parse(Operando2_TextBox.Text)).ToString();
            else if (Resta_Button.IsChecked == true)
                Resultado_TextBox.Text = (double.Parse(Operando1_TextBox.Text) - double.Parse(Operando2_TextBox.Text)).ToString();
            else if (Multiplicacion_Button.IsChecked == true)
                Resultado_TextBox.Text = (double.Parse(Operando1_TextBox.Text) * double.Parse(Operando2_TextBox.Text)).ToString();
            else if (Division_Button.IsChecked == true || double.Parse(Operando2_TextBox.Text) == 0)
            {
                    Resultado_TextBox.Text = "Error";
            }
            else if (Division_Button.IsChecked == true || double.Parse(Operando2_TextBox.Text) != 0)
            {
                Resultado_TextBox.Text = (double.Parse(Operando1_TextBox.Text) * double.Parse(Operando2_TextBox.Text)).ToString();
            }
        }
    }
}
