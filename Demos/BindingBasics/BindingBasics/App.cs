using System;
using Xamarin.Forms;
using BindingBasics.Pages;

namespace BindingBasics
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new BindingDemoPage ();
		}
	}
}

