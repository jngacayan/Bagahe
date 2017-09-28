using System;
using System.Collections.Generic;
using MvvmCross.Forms.Core;
using Bagahe.Core.ViewModels;
using Xamarin.Forms;

namespace Bagahe.Core.Views
{
    public partial class MainView : MvxContentPage<MainViewModel>
    {
        public MainView()
        {
            InitializeComponent();
        }
    }
}
