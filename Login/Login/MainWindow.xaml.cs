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

namespace Login
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ___Button2___Salir__Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ___Button1___Iniciar___Click(object sender, RoutedEventArgs e)
        {
            if (___TextBox1_.Text == "juancho")
            {
                if (___TextBox2_.Text == "123tamarindo")
                {
                    Window1 form = new Window1();
                    form.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Su nombre de usuario o su contraseña son incorrectos.");
                }
            }
            else
            {
                MessageBox.Show("Su nombre de usuario o su contraseña son incorrectos.");
            }
        }
    }
}

        
    

