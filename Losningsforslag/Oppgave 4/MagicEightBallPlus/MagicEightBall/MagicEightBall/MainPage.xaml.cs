using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MagicEightBall
{
    public partial class MainPage
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

        public MainPage()
        {
            InitializeComponent();

            EightBallImage.Source = ImageSource.FromResource("MagicEightBall.Images.8-ball.png");

            Xamarin.Forms.DependencyService.Get<IAccelerometer>().Shaked += (sender, e) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    Fortune.Text = _options[new Random().Next(0, _options.Count())];
                });
            };
        }
    }
}
