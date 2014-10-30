using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Diagnostics;

namespace BindingBasics.ViewModels
{

	public class PeopleListViewModel {

		private Random _rand = new Random();

		public ObservableCollection<PersonViewModel> People {
			get;
			set;
		}

		public ICommand AddRandomPerson {
			get;set;
		}

		public ICommand RemoveRandomPerson {
			get;set;
		}

		public PeopleListViewModel() {
			AddRandomPerson = new Command (() => {
				Debug.WriteLine("Adding random person");
				People.Add(new PersonViewModel() {
					Name = "RandomPerson" + _rand.Next(100),
					Age = _rand.Next(100)
				});
			});
			RemoveRandomPerson = new Command (() => {
				Debug.WriteLine ("Removing random person");
				People.RemoveAt (_rand.Next(People.Count - 1));
			});
		
		}

	}

	public class PersonViewModel : ViewModelBase
	{

		private string _name;
		private int _age;

		public string Name {
			get { 
				return _name;
			}
			set {
				if (value != _name) {
					_name = value;
					OnPropertyChanged ();
				}
			}
		}

		public int Age {
			get { 
				return _age;
			}
			set { 
				if (value != _age) {
					_age = value;
					OnPropertyChanged ();
				}
			}
		}

		public PersonViewModel ()
		{
		}
	}
}

