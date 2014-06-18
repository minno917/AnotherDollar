//Written by Ivan Minno
//Copyright 2014

using System;
using System.ComponentModel;
using System.Timers;
using System.Windows;

namespace MPP.AnotherDollar
{
    public partial class View : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private DateTime endTime = DateTime.Today;
        private Timer t;

        private double percent;

        public String PercentString
        {
            get
            {
                return string.Format("Day Complete: {0:P}", percent);
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
            }
        }


        public View()
        {            
            endTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 17, 0, 0);
            Percent = 1 - (endTime - DateTime.Now).TotalSeconds / (TimeSpan.FromHours(8).TotalSeconds);
            t = new Timer(3000);
            t.Elapsed += new ElapsedEventHandler(t_Elapsed);
            t.Start();
            DataContext = this;

            InitializeComponent();
        }

        void t_Elapsed(object sender, ElapsedEventArgs e)
        {
            Percent = 1 - (endTime - DateTime.Now).TotalSeconds / (TimeSpan.FromHours(8).TotalSeconds);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            t.Stop();
            t.Dispose();
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
