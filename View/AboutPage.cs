﻿using Xamarin.Forms;

namespace PCLMvvm.Core.View
{
    public class AboutPage : ContentPage
    {
        public AboutPage()
        {
            Content = new StackLayout
            {
                Children =
                {
                    new Label
                    {
                        FontSize = 24,
                        Text =  "C# Sample: MvvM Basics\n\n" +
                                "Basic Model View ViewModel functionality:\n\n" +
                                "* Binding a View (page) to a ViewModel, two-way binding, View -updates-> ViewModel, ViewModel -update-> View\n\n" +
                                "* MvvMCross Framework locates ViewModel for View via naming convention, loads and binds them\n\n" +
                                "* Navigation to View via MvvMCros IoC container, all you need is the view Type\n\n" +
                                "* Buttons etc. use the ICommand pattern; this interface has a 'CanExecute' property the can enable / disable the button\n" +
                                "     via standard property binding to visual element properties; and an Execute function called when the button is clicked\n\n" +
                                "* MvvMCross.Forms same App simulteanously targeting multiple supported platforms.\n"
                    }
                }
            };
            if (Device.OS == TargetPlatform.Windows)
                Padding = new Xamarin.Forms.Thickness(this.Padding.Left, this.Padding.Top, this.Padding.Right, 95);
        }
    }
}