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
        String description0;
        Questionaire questionair0;
        //   public event EventHandler ButtonClick;

        public HomePageButton()
        {
            InitializeComponent();
            activate();
        }

        public HomePageButton(String title, String description, Questionaire questionair)
        {
            this.title0 = title;
            this.description0 = description;
            this.questionair0 = questionair;
            InitializeComponent();
            activate();

        }
        private void activate()
        {
            if (title0 != null && description0 != null && questionair0 != null)
            {
                text1.Text = title0;
                text2.Text = description0;

            }
        }

        private void customClick()
        {
            QuestionairePage goQuestionnaire = new QuestionairePage(questionair0);
            NavigationService navService = NavigationService.GetNavigationService(this);
            navService.Navigate(goQuestionnaire);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            customClick();
        }
    }
}
