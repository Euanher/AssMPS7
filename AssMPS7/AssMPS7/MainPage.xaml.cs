using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AssMPS7
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Frame WhatsAppFrame = new Frame
            {
                BorderColor = Color.LightGreen,
                CornerRadius = 5,
                BackgroundColor = Color.LightGreen,
                Padding = 8,
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "WhatsApp",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                          FontAttributes = FontAttributes.Bold
                      }
                    }
                }
            };

            Frame circleImageFrame = new Frame
            {
                Margin = 10,
                BorderColor = Color.LightGreen,
                CornerRadius = 50,
                HeightRequest = 60,
                WidthRequest = 60,
                IsClippedToBounds = true,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Content = new Image
                {
                    Source = ImageSource.FromFile("whatsapp-logo-app-png-4"),
                    Aspect = Aspect.AspectFill,
                    Margin = 20,
                    HeightRequest = 100,
                    WidthRequest = 100,
                }
            };
        }
    }
}