using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Models;

namespace TodoAppXaml.Views
{
    public partial class TodoItemView
    {
        public TodoItemView(TodoItem todoItem)
        {
            InitializeComponent();
            this.BindingContext = todoItem;
        }
    }
}
