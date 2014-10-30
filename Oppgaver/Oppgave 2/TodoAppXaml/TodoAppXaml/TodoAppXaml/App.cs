using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoAppXaml.Views;
using Xamarin.Forms;

namespace TodoAppXaml
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new NavigationPage(new TodoListView());
        }
    }
}
