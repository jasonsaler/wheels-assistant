using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WheelsDataAssistant
{
    /// <summary>
    /// Interaction logic for NewQuestionnairePage.xaml
    /// </summary>
    public partial class NewQuestionnairePage : Page
    {
        public NewQuestionnairePage()
        {
            InitializeComponent();
        }

        private void MenuHandler()
        {
            if (newMenu.Visibility == Visibility.Visible)
            {
                newMenu.Visibility = Visibility.Hidden;
                newButton.Background = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorDark");
                newButton.Foreground = (Brush)Application.Current.MainWindow.FindResource("TextLightColor");
            }
            else
            {
                newMenu.Visibility = Visibility.Visible;
                newButton.Background = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorLight");
                newButton.Foreground = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorDark");
            }
        }

        private void Menu_MouseLeave(object sender, MouseEventArgs e)
        {
            MenuHandler();
        }

        private void NewButton_MouseClick(object sender, RoutedEventArgs e)
        {
            MenuHandler();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to close this form? Changes will not be saved?", "Cancel", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                HomePage homePage = new HomePage();
                this.NavigationService.Navigate(homePage);
            }
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            HelpPage helpPage = new HelpPage();
            this.NavigationService.Navigate(helpPage);
        }

        private void finishButton_Click(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
            this.NavigationService.Navigate(homePage);
        }

        private void SaveProgressButton_Click(object sender, RoutedEventArgs e)
        {
            if (SaveNewQuestionnaireProgress() == false)
            {
                ToastNotification progressSavedToast = new ToastNotification("Error Saving Progress", 7, -1);
                progressSavedToast.Visibility = Visibility.Visible;
                openSpaceGrid.Children.Add(progressSavedToast);
            }
            else
            {
                ToastNotification progressSavedToast = new ToastNotification("Summary Report Generated Successfully", 7);
                progressSavedToast.Visibility = Visibility.Visible;
                openSpaceGrid.Children.Add(progressSavedToast);
            }
        }

        private Boolean SaveNewQuestionnaireProgress()
        {
            return false;
        }
    }
}
