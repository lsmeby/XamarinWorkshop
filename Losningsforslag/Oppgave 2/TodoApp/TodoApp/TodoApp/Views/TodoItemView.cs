using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Models;
using Xamarin.Forms;

namespace TodoApp.Views
{
    public class TodoItemView : ContentPage
    {
        public TodoItemView(TodoItem todoItem)
        {
            this.BindingContext = todoItem;

            var name = new Entry
            {
                Placeholder = "Name"
            };
            name.SetBinding(Entry.TextProperty, "Name");

            var note = new Entry
            {
                Placeholder = "Note"
            };
            note.SetBinding(Entry.TextProperty, "Note");

            var done = new Switch();
            done.SetBinding(Switch.IsToggledProperty, "Done");

            this.Content = new StackLayout
            {
                Padding = new Thickness(20),
                Children =
                {
                    name,
                    note,
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Padding = new Thickness(20),
                        Children =
                        {
                            new Label
                            {
                                Text = "Done",
                                Font = Font.SystemFontOfSize(NamedSize.Large),
                                HorizontalOptions = LayoutOptions.StartAndExpand,
                                VerticalOptions = LayoutOptions.CenterAndExpand
                            },
                            done
                        }
                    }
                }
            };
        }
    }
}
