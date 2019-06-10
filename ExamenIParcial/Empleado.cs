using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NAME SPACES NECESARIOS
using System.ComponentModel;

namespace ExamenIParcial
{

    public class Empleado : INotifyPropertyChanged
    {
        private string horasTrabajadas;
        private string pagoporHora;
        private string horaExtra;
        private string pagoporExtra;

        //METODOS
        public string HorasTrabajadas
        {
            get { return horasTrabajadas; }
            set
            {
                int numero;
                bool resultado = int.TryParse(value, out numero);
                if (resultado) horasTrabajadas = value;
                OnPropertyChanged("HorasTrabajadas");
                OnPropertyChanged("SueldosinDeduccion");
                OnPropertyChanged("DeduccionTotal");
                OnPropertyChanged("SueldoTotal");
            }
        }
        public string PagoporHora
        {
            get { return pagoporHora; }
            set
            {
                double numero;
                bool resultado = double.TryParse(value, out numero);
                if (resultado) pagoporHora = value;
                OnPropertyChanged("PagoporHora");
                OnPropertyChanged("SueldosinDeduccion");
                OnPropertyChanged("DeduccionTotal");
                OnPropertyChanged("SueldoTotal");
            }
        }
        public string HorasExtra
        {
            get { return horaExtra; }
            set
            {
                int numero;
                bool resultado = int.TryParse(value, out numero);
                if (resultado) horaExtra = value;
                OnPropertyChanged("HorasExtra");
                OnPropertyChanged("SueldosinDeduccion");
                OnPropertyChanged("SueldoporExtra");
                OnPropertyChanged("DeduccionTotal");
                OnPropertyChanged("SueldoTotal");
            }
        }
        public string PagoporExtra
        {
            get { return pagoporExtra; }
            set
            {
                double numero;
                bool resultado = double.TryParse(value, out numero);
                if (resultado) pagoporExtra = value;
                OnPropertyChanged("PagoporExtra");
                OnPropertyChanged("SueldosinDeduccion");
                OnPropertyChanged("SueldoporExtra");
                OnPropertyChanged("DeduccionTotal");
            }
        }
        public string SueldosinDeduccion
        {
            get {
                double sueldosindeducir;
                sueldosindeducir = double.Parse(HorasTrabajadas) * double.Parse(PagoporHora);
                return sueldosindeducir.ToString();
            }
            set
            {
                double sueldosindeducir;
                sueldosindeducir = double.Parse(HorasTrabajadas) * double.Parse(PagoporHora);
                sueldosindeducir.ToString();
                OnPropertyChanged("SueldosinDeduccion");
            }
        }
        public string SueldoporExtra
        {
            get
            {
                double sueldoextra;
                sueldoextra = double.Parse(HorasExtra) * double.Parse(PagoporExtra);
                return sueldoextra.ToString();
            }
            set
            {
                double sueldoextra;
                sueldoextra = double.Parse(HorasExtra) * double.Parse(PagoporExtra);
                sueldoextra.ToString();
                OnPropertyChanged("SueldoporExtra");
            }
        }

        public string DeduccionTotal
        {
            get
            {
                double deducciontotal = double.Parse(SueldosinDeduccion) - ((double.Parse(SueldosinDeduccion) * 0.04) + (double.Parse(SueldosinDeduccion) * 0.035));
                return deducciontotal.ToString();
            }
            set
            {
                double deducciontotal = double.Parse(SueldosinDeduccion) - ((double.Parse(SueldosinDeduccion) * 0.04) + (double.Parse(SueldosinDeduccion) * 0.035));
                deducciontotal.ToString();
                OnPropertyChanged("DeduccionTotal");
            }
        }
        public string SueldoTotal
        {
            get
            {
                double sueldototal = (double.Parse(SueldosinDeduccion) + double.Parse(SueldoporExtra)) - double.Parse(DeduccionTotal);
                return sueldototal.ToString();
            }
            set
            {
                double sueldototal = (double.Parse(SueldosinDeduccion) + double.Parse(SueldoporExtra)) - double.Parse(DeduccionTotal);
                sueldototal.ToString();
                OnPropertyChanged("SueldoTotal");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
