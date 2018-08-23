using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PopupPage.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopupPageView  : IDisposable
	{
		public PopupPageView ()
		{
			InitializeComponent ();
            BindingContext = new ViewModels.PopupPageViewModel(); // bindind view-model
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ImageClose.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(_ =>
                {
                    PopupNavigation.Instance.PopAsync(); // this is used to close popup page.
                })
            });
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}