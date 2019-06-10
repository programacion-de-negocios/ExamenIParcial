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

namespace ExamenIParcial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Empleado Elempleado { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Elempleado = new Empleado { HorasTrabajadas = "2", PagoporHora = "2", HorasExtra="3", PagoporExtra="3"};
            this.DataContext = Elempleado;
        }
    }
}
