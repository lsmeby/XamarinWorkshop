using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MagicEightBall
{
    public class App
    {
        private static readonly string[] _options =
        {
            "It is certain",
            "It is decidedly so",
            "Without a doubt",
            "Yes definitely",
            "You may rely on it",
            "As I see it, yes",
            "Most likely",
            "Outlook good", 
            "Yes",
            "Signs point to yes",
            "Reply hazy try again",
            "Ask again later",
            "Better not tell you now",
            "Cannot predict now",
            "Concentrate and ask again",
            "Don't count on it",
            "My reply is no",
            "My sources say no",
            "Outlook not so good",
            "Very doubtful"
        };

        public static Page GetMainPage()
        {
            var label = new Label
            {
                Text = "Ask me anything!",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };

            Xamarin.Forms.DependencyService.Get<IAccelerometer>().Shaked += (sender, e) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                    {
                        label.Text = _options[new Random().Next(0, _options.Count())];
                    });
            };

            return new ContentPage
            {
                Content = new StackLayout
                {
                    Padding = new Thickness(20),
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        label
                    }
                }
            };
        }
    }
}
