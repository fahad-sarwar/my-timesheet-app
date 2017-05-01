using System;
using System.Windows.Input;
using Acr.UserDialogs;
using Xamarin.Forms;

namespace App.ViewModels
{
    public class AddEntryViewModel : BaseViewModel
    {
        private DateTime _selectedDate;
        public DateTime SelectedDate
        {
            get { return _selectedDate; }
            set { SetProperty(ref _selectedDate, value); }
        }

        private TimeSpan _clockInTime;
        public TimeSpan ClockInTime
        {
            get { return _clockInTime; }
            set { SetProperty(ref _clockInTime, value); }
        }

        private TimeSpan _clockOutTime;
        public TimeSpan ClockOutTime
        {
            get { return _clockOutTime; }
            set { SetProperty(ref _clockOutTime, value); }
        }

        public ICommand SubmitRequestCommand { get; set; }

        public AddEntryViewModel()
        {
            SelectedDate = DateTime.Now;
            ClockInTime = DateTime.Now.TimeOfDay;
            ClockOutTime = DateTime.Now.TimeOfDay;

            SubmitRequestCommand = new Command(() =>
            {
                UserDialogs.Instance.Toast("Entry added successfully!", new TimeSpan(0, 0, 0, 3));
            });
        }
    }
}
