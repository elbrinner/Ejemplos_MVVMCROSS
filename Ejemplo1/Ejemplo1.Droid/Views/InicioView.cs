using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace Ejemplo1.Droid.Views
{
    [Activity(Label = "Vista de inicio - titulo")]
    public class InicioView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.InicioView);
        }
    }
}