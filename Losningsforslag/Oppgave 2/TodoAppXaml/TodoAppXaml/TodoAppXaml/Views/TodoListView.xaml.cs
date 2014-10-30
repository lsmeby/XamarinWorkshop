using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Models;
using Xamarin.Forms;

namespace TodoAppXaml.Views
{
    public partial class TodoListView
    {
        public List<TodoItem> items;

        public TodoListView()
        {
            InitializeComponent();
            items = new List<TodoItem>();
            this.BindingContext = items;
        }

        protected async void AddNewClicked(object sender, EventArgs e)
        {
            var item = new TodoItem("", "", false);
            items.Add(item);
            await Navigation.PushAsync(new TodoItemView(item));
        }

        protected async void TodoSelected(object sender, ItemTappedEventArgs e)
        {
            var todoItem = (TodoItem)e.Item;
            var todoPage = new TodoItemView(todoItem);
            await Navigation.PushAsync(todoPage);
        }
    }
}
