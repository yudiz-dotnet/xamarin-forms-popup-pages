namespace PopupPage.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private string _ButtonText;

        public string ButtonText
        {
            get { return _ButtonText; }
            set { _ButtonText = value; NotifyPropertyChanged("ButtonText"); }
        }

        public MainPageViewModel()
        {
            ButtonText = "Open Popup";
        }
    }
}