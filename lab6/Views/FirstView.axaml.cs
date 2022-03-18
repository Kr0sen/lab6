using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using lab6.ViewModels;

namespace lab6.Views
{
    public partial class FirstView : UserControl
    {
        public FirstView()
        {
            InitializeComponent();
            this.FindControl<DatePicker>("DatePickerFv").SelectedDate = DateTime.Today;
            this.FindControl<DatePicker>("DatePickerFv").SelectedDateChanged +=
                new EventHandler<DatePickerSelectedValueChangedEventArgs>(DatePicker_SelectedDateChanged);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void DatePicker_SelectedDateChanged(object sender, DatePickerSelectedValueChangedEventArgs e)
        {
            (this.DataContext as FirstViewModel).changeItems
                (DateTime.Parse(this.FindControl<DatePicker>("DatePickerFv").SelectedDate.ToString()));
        }
    }
}
