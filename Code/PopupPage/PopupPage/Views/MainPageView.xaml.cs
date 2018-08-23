using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PopupPage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPageView : ContentPage, IDisposable
    {
		public MainPageView ()
		{
			InitializeComponent ();
            BindingContext = new ViewModels.MainPageViewModel();
		}
      
        private void ButtonPopup_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new Views.PopupPageView());
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}