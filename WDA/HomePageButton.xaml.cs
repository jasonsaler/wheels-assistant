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
using System.Windows.Navigation;
using System.Windows.Threading;


namespace WheelsDataAssistant
{
    /// <summary>
    /// Interaction logic for HomePageButton.xaml
    /// </summary>
    public partial class HomePageButton : UserControl
    {
        String title0;
        String Description0;
        public event EventHandler ButtonClick;

        public HomePageButton()
        {
            InitializeComponent();
            activate();
        }

        public HomePageButton(String title, String description)
        {
            this.title0 = title;
            this.Description0 = description;
            InitializeComponent();
            activate();
        }
        private void activate()
        {
            if (title0 != null && Description0 != null)
            {
                button.Content = title0 + System.Environment.NewLine + System.Environment.NewLine + Description0;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (this.ButtonClick != null)
            {
                this.ButtonClick(this, e);
            }
            QuestionairePage goQuestionnaire = new QuestionairePage();
            NavigationService navService = NavigationService.GetNavigationService(this);
            navService.Navigate(goQuestionnaire);
        }
    }
}

