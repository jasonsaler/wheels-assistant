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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WheelsDataAssistant
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            Questionaire newQuestionaire = new Questionaire("WCQ-C", 45);          

        }

        private void button1_Click(object sender, RoutedEventArgs e)

        {

            //ListView1.Items.Add(textBox1.Text);

        }

        private void favoritesItemsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RecentItemsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void QuestionaireButton_Click(object sender, RoutedEventArgs e)
        {
            // go to questionaire
            QuestionairePage WcqcQuestionaire = new QuestionairePage();
            this.NavigationService.Navigate(WcqcQuestionaire);
        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            HelpPage helpPage = new HelpPage();
            this.NavigationService.Navigate(helpPage);
        }

        private void FileButton_Click(object sender, RoutedEventArgs e)
        {
            MenuHandler();
        }

        private void Menu_MouseLeave(object sender, MouseEventArgs e)
        {
            MenuHandler();
        }

        private void MenuHandler()
        {
            if (fileMenu.Visibility == Visibility.Visible)
            {
                fileMenu.Visibility = Visibility.Hidden;
                fileButton.Background = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorDark");
                fileButton.Foreground = (Brush)Application.Current.MainWindow.FindResource("TextLightColor");
            }
            else
            {
                if (aboutPanel.Visibility == Visibility.Visible)
                    HideAbout();

                fileMenu.Visibility = Visibility.Visible;
                fileButton.Background = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorLight");
                fileButton.Foreground = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorDark");
            }
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            if (aboutPanel.Visibility == Visibility.Visible)
            {
                HideAbout();
            }
            else
            {
                if (fileMenu.Visibility == Visibility.Visible)
                    MenuHandler();

                aboutPanel.Visibility = Visibility.Visible;
                aboutButton.Background = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorLight");
                aboutButton.Foreground = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorDark");
            }
        }

        private void HideAbout()
        {
            aboutPanel.Visibility = Visibility.Hidden;
            aboutButton.Background = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorDark");
            aboutButton.Foreground = (Brush)Application.Current.MainWindow.FindResource("TextLightColor");
        }

        private void AboutPanel_MouseLeave(object sender, MouseEventArgs e)
        {
            HideAbout();
        }

        private void GenerateSummaryButton_Click(object sender, MouseButtonEventArgs e)
        {
            GenerateSummaryReport();
            generateSummaryNotificationToast.Visibility = Visibility.Visible;
        }

        private void GenerateSummaryReport()
        {
            // Do the stuff that is done in the backend Yeah!
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
            generateSummaryNotificationToast.Visibility = Visibility.Hidden;
        }
    }
}
