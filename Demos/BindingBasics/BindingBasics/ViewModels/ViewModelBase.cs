using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BindingBasics.ViewModels
{
	public abstract class ViewModelBase : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propName = null) {
			if (PropertyChanged != null) {
				PropertyChanged(this, new PropertyChangedEventArgs(propName));
			}
		}
	}


}

