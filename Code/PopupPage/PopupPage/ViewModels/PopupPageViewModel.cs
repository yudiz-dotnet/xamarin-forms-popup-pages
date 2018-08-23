using System;
using System.Collections.Generic;
using System.Text;

namespace PopupPage.ViewModels
{
    public class PopupPageViewModel : BaseViewModel
    {
        private string _IconLogo, _IconClose;
        private string _LabelTitle, _LabelDescription;

        public string IconLogo
        {
            get { return _IconLogo; }
            set { _IconLogo = value; NotifyPropertyChanged("IconLogo"); }
        }
        public string IconClose
        {
            get { return _IconClose; }
            set { _IconClose = value; NotifyPropertyChanged("IconClose"); }
        }
        public string LabelTitle
        {
            get { return _LabelTitle; }
            set { _LabelTitle = value; NotifyPropertyChanged("LabelTitle"); }
        }
        public string LabelDescription
        {
            get { return _LabelDescription; }
            set { _LabelDescription = value; NotifyPropertyChanged("LabelDescription"); }
        }

        public PopupPageViewModel()
        {
            IconLogo = "ic_logo.png";
            IconClose = "ic_close.png";
            LabelTitle = "Popup page";
            LabelDescription = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.";
        }
    }
}
