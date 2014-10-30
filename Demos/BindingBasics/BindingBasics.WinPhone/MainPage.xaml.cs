
using Microsoft.Phone.Controls;
using Xamarin.Forms;

namespace BindingBasics.WinPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();
            Content = BindingBasics.App.GetMainPage().ConvertPageToUIElement(this);
        }
    }
}