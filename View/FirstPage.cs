using Xamarin.Forms;

namespace PCLMvvm.Core.View
{
    public class FirstPage : ContentPage
    {
        public FirstPage()
        {
            Padding = new Thickness(10);

            if (Device.OS == TargetPlatform.Windows)
                Padding = new Xamarin.Forms.Thickness(Padding.Left, this.Padding.Top, this.Padding.Right, 95);

            ForceLayout();

            Title = " First Page";

            var entryBox = new Entry
            {
                Placeholder = "Who are you?",
                TextColor = Color.Aqua,
                WidthRequest = 30
            };

            var helloResponse = new Label
            {
                Text = string.Empty,
                FontSize = 24
            };
            var loginBtn = new Button
            {
                Text = "Login",
                BackgroundColor = Color.Orange
            };

            Content = new StackLayout
            {
                Spacing = 10,
                Orientation = StackOrientation.Vertical,
                Children =
                {
                    new Label
                    {
                        Text = "Enter your nickname in the box below",
                        FontSize = 24
                    },
                    entryBox,
                    helloResponse,
                    loginBtn
                }
            };

            entryBox.SetBinding(Entry.TextProperty, new Binding("YourNickname"));
            helloResponse.SetBinding(Label.TextProperty, new Binding("Hello"));
            loginBtn.SetBinding(Button.IsVisibleProperty, new Binding("IsVisible"));
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            // Fixed in next version of Xamarin.Forms. BindingContext is not properly set on ToolbarItem.
            var aboutItem = new ToolbarItem { Text = "About", ClassId = "about", Order = ToolbarItemOrder.Primary, BindingContext = BindingContext };
            aboutItem.SetBinding(MenuItem.CommandProperty, new Binding("ShowboutPageCommand"));

            ToolbarItems.Add(aboutItem);
        }
    }
}