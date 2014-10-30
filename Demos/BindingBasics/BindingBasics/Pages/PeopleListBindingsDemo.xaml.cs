using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using BindingBasics.ViewModels;

namespace BindingBasics.Pages
{	
	public partial class PeopleListBindingsDemo : ContentPage
	{	

		public PeopleListViewModel ViewModel {
			get;set;
		}

		public PeopleListBindingsDemo ()
		{
			InitializeComponent ();
			ViewModel = new PeopleListViewModel ();
			var people = new ObservableCollection<PersonViewModel> ();
			people.Add (new PersonViewModel () {
				Name = "Nils-Helge",
				Age = 37
			});
			people.Add (new PersonViewModel () {
				Name = "Ellinor",
				Age = 3
			});
			people.Add (new PersonViewModel () {
				Name = "Iver",
				Age = 7
			});
			ViewModel.People = people;
			BindingContext = ViewModel;

		}
	}
}

