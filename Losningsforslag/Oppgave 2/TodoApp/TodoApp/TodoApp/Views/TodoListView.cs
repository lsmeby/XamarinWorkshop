using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Models;
using Xamarin.Forms;

namespace TodoApp.Views
{
    public class TodoListView : ContentPage
    {
        public List<TodoItem> items;

        public TodoListView()
        {
            items = new List<TodoItem>();

            var listView = new ListView
            {
                ItemsSource = items,
                ItemTemplate = new DataTemplate(typeof(TextCell)),
            };
            listView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");
            listView.ItemTemplate.SetBinding(TextCell.DetailProperty, "Note");
            listView.ItemTemplate.SetBinding(TextCell.TextColorProperty, new Binding("Done", converter: new ConvertBoolToColor()));
            listView.ItemTemplate.SetBinding(TextCell.DetailColorProperty, new Binding("Done", converter: new ConvertBoolToColor()));
            listView.ItemTapped += async (sender, e) =>
                {
                    var todoItem = (TodoItem)e.Item;
                    var todoPage = new TodoItemView(todoItem);
                    await Navigation.PushAsync(todoPage);
                };

            var button =  new Button
            {
                Text = "Add new",
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.EndAndExpand
            };
            button.Clicked += async (sender, e) =>
                {
                    var item = new TodoItem("", "", false);
                    items.Add(item);
                    await Navigation.PushAsync(new TodoItemView(item));
                };

            Content = new StackLayout
            {
                Padding = new Thickness(20),
                Children =
                {
                    new Label
                    {
                        Text = "ToDo-items",
                        Font = Font.SystemFontOfSize(NamedSize.Large)
                    },
                    listView,
                    button
                }
            };
        }

        public class ConvertBoolToColor : IValueConverter
        {

            public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                return (bool)value ? Color.Green : Color.Red;
            }

            public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        }
    }
}
