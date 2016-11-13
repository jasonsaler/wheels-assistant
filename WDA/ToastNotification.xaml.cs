using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace WheelsDataAssistant
{
    /// <summary>
    /// Interaction logic for ToastNotification.xaml
    /// </summary>
    public partial class ToastNotification : UserControl
    {
        String toastMessage;
        int toastDuration = 10;
        int toastType = 1;

        DispatcherTimer dispatcherTimer = new DispatcherTimer();



        public ToastNotification()
        {
            InitializeComponent();
            activateToast();
        }

        public ToastNotification(String message)
        {
            this.toastMessage = message;
            InitializeComponent();
            activateToast();
        }

        public ToastNotification(String message, int durationSeconds)
        {
            this.toastDuration = durationSeconds;
            this.toastMessage = message;
            
            InitializeComponent();
            activateToast();
        }

        public ToastNotification(String message, int durationSeconds, int type)
        {
            this.toastDuration = durationSeconds;
            this.toastMessage = message;
            this.toastType = type;

            InitializeComponent();
            handleType();
            activateToast();
        }

        private void handleType()
        {
            if(toastType == -1)
                toastLabel.Background = (Brush)Application.Current.MainWindow.FindResource("CloseButtonRed");
            else if(toastType == 0)
                toastLabel.Background = (Brush)Application.Current.MainWindow.FindResource("WarningYellow");
            else
                toastLabel.Background = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorDark");
        }

        private void CloseButton_MouseEnter(object sender, MouseEventArgs e)
        {
            CloseButtoBackground.Background = (Brush)Application.Current.MainWindow.FindResource("CloseButtonRed");
        }

        private void CloseButton_MouseLeave(object sender, MouseEventArgs e)
        {
            CloseButtoBackground.Background = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorDark");

        }

        private void CloseButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            toastBox.Visibility = Visibility.Hidden;
            dispatcherTimer.Stop();
        }

        private void activateToast()
        {
            if(toastMessage != null)
                toastLabel.Content = toastMessage;

            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, toastDuration);
            dispatcherTimer.Start();
        }


        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            toastBox.Visibility = Visibility.Hidden;
            dispatcherTimer.Stop();
        }

    }
}
