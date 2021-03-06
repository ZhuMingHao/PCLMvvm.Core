﻿using MvvmCross.Core.Views;
using MvvmCross.Forms.Presenter.WindowsUWP;
using MvvmCross.Platform;
using Xamarin.Forms.Platform.UWP;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PCL.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : WindowsPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            var start = Mvx.Resolve<MvvmCross.Core.ViewModels.IMvxAppStart>();
            start.Start();

            var presenter = Mvx.Resolve<IMvxViewPresenter>() as MvxFormsWindowsUWPPagePresenter;
            LoadApplication(presenter.MvxFormsApp);
        }
    }
}