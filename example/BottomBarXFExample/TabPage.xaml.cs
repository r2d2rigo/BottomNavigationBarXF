using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace BottomBarXFExample
{
    public partial class TabPage : ContentPage
    {
        private ICommand _buttonCommand;

        public ICommand ButtonCommand
        {
            get { return _buttonCommand; }
            set
            {
                if (_buttonCommand != value)
                {
                    _buttonCommand = value;
                    OnPropertyChanged();
                }
            }
        }

        public TabPage()
        {
            InitializeComponent();

            BindingContext = this;
        }

        public void UpdateLabel()
        {
            Label.Text = string.Format(Label.Text, Title);
        }
    }
}

