using Cirrious.MvvmCross.ViewModels;

namespace Ejemplo1.Core.ViewModels
{
    public class InicioViewModel 
		: MvxViewModel
    {
		private string _hola = "Mensaje de bienvenida a MVVMCROSS";
        public string Hola
		{ 
			get { return _hola; }
			set { SetProperty (ref _hola, value); }
		}
    }
}
