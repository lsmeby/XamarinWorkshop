using System;
using Xamarin.Forms;
using BindingBasics.Pages;

namespace BindingBasics
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			// Uncomment for list bindings demo
			//return new NavigationPage (new PeopleListBindingsDemo());
			return new NavigationPage (new BindingDemoPage ());
		}
	}
}

