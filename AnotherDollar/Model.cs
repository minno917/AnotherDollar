using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Timers;

namespace MPP.AnotherDollar
{
    class Model : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public static readonly int timerPeriod = 3000;

        private DateTime endTime = DateTime.Today;
        private Timer updateTimer;

        private double percent;
        private double wage = 10;
        private double hoursWorking = 8;

        public double HoursWorking
        {
            get
            {
                return hoursWorking;
            }
            set
            {
                hoursWorking = value;
                OnPropertyChanged("PercentString");
                OnPropertyChanged("TodaysEarnings");
            }
        }

        public double Wage
        {
            get
            {
                return wage;
            }
            set
            {
                wage = value;
                OnPropertyChanged("Wage");
                OnPropertyChanged("TodaysEarnings");
            }
        }
        
        public string TodaysEarnings
        {
            get
            {
                return string.Format("{0:C}", (percent > 0) ? percent * wage * hoursWorking : 0);
            }
        }

        public DateTime EndTime
        {
            get
            {
                return endTime;
            }
            set
            {
                endTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, value.Hour, value.Minute, 0);
                UpdatePercent();
                OnPropertyChanged("EndTime");                
            }
        }

        public String PercentString
        {
            get
            {
                return string.Format("{0:P}", percent);
            }
        }

        public double Percent
        {
            get
            {
                return percent;
            }
            set
            {
                percent = value;
                OnPropertyChanged("PercentString");
                OnPropertyChanged("TodaysEarnings");
            }
        }

        public Model()
        {
            UpdatePercent();   
            updateTimer = new Timer(timerPeriod);
            updateTimer.Elapsed += new ElapsedEventHandler(Refresh);
            updateTimer.Start();
        }

        private void Refresh(object sender, ElapsedEventArgs e)
        {
            UpdatePercent();
        }

        public void Dispose()
        {
            updateTimer.Stop();
            updateTimer.Dispose();
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void UpdatePercent()
        {
            Percent = 1 - (endTime - DateTime.Now).TotalSeconds / (TimeSpan.FromHours(hoursWorking).TotalSeconds);
        }
    }
}
