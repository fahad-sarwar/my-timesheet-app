using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.ViewModels;
using Xamarin.Forms;

namespace App.Views
{
    public class AddEntry : ContentPage
    {
        public AddEntryViewModel ViewModel { get; set; }

        public AddEntry()
        {
            Title = "Add Entry";

            ViewModel = new AddEntryViewModel();

            var header = new Label
            {
                Text = "Add New Entry"
            };

            var dateLabel = new Label
            {
                Text = "Date:"
            };

            var datePicker = new DatePicker
            {
                Format = "ddd, MMM d, yyyy"
            };
            datePicker.SetBinding(DatePicker.DateProperty, nameof(AddEntryViewModel.SelectedDate));

            var clockInLabel = new Label
            {
                Text = "Clock In:"
            };

            var clockInTimePicker = new TimePicker
            {
                Format = "HH:mm"
            };
            clockInTimePicker.SetBinding(TimePicker.TimeProperty, nameof(AddEntryViewModel.ClockInTime));

            var clockOutLabel = new Label
            {
                Text = "Clock Out:"
            };

            var clockOutTimePicker = new TimePicker
            {
                Format = "HH:mm"
            };
            clockOutTimePicker.SetBinding(TimePicker.TimeProperty, nameof(AddEntryViewModel.ClockOutTime));

            var submitButton = new Button
            {
                Text = "Add",
                Command = ViewModel.SubmitRequestCommand
            };

            Padding = new Thickness(15);

            Content = new ScrollView
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        header,
                        dateLabel,
                        datePicker,
                        clockInLabel,
                        clockInTimePicker,
                        clockOutLabel,
                        clockOutTimePicker,
                        submitButton
                    }
                }
            };
        }
    }
}
