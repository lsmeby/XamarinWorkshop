using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    public class TodoItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _name;
        private string _note;
        private bool _done;

        public TodoItem(string name, string note, bool done)
        {
            this._name = name;
            this._note = note;
            this._done = done;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if(value.Equals(_name, StringComparison.Ordinal))
                {
                    return;
                }
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Note
        {
            get { return _note; }
            set
            {
                if (value.Equals(_note, StringComparison.Ordinal))
                {
                    return;
                }
                _note = value;
                OnPropertyChanged();
            }
        }

        public bool Done
        {
            get { return _done; }
            set
            {
                if (value.Equals(_done))
                {
                    return;
                }
                _done = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
