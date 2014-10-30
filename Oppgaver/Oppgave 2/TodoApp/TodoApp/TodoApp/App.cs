using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoApp.Views;
using Xamarin.Forms;

namespace TodoApp
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new NavigationPage(new TodoListView());
        }
    }
}
