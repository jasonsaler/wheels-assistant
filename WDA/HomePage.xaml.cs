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
            addLLFQ();
        }

        public HomePage(HomePageButton button)
        {
            InitializeComponent();
            addLLFQ();
            addNewButton(button);
        }

        private void addNewButton(HomePageButton button)
        {
            if (openSpaceGrid.Items.Count > openSpaceGrid2.Items.Count)
                openSpaceGrid2.Items.Add(button);
            else
                openSpaceGrid.Items.Add(button);
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
            ToastNotification generatedToast = new ToastNotification("Summary Report Generated Successfully", 7);
            generatedToast.Visibility = Visibility.Visible;
            pageSpaceGrid.Children.Add(generatedToast);
            
            GenerateSummaryReport();
            //generateSummaryNotificationToast.Visibility = Visibility.Visible;
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

        private void NewQuestionaireButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            NewQuestionnairePage newQuestionnairePage = new NewQuestionnairePage();
            this.NavigationService.Navigate(newQuestionnairePage);
        }

        private void addLLFQ()
        {
            String instruction = "We would like you to compare your lower limb function and movement to that of a person of your age and "
                + "gender who does not have a physical disability or need an assistive device.   Answer each question by clicking and dragging "
                + "the slider mark anywhere on the slider scale. The letters are a reference point for placing your mark.  You can move the "
                + "slider anywhere along the line including in between the letter grades.  There is no right or wrong answer, just give the "
                + "answer that best describes you and your experience.  Please explain your score in the comments section below each line. ";

            Questionaire newQuestionaire = new Questionaire("Lower Limb Functionality Questionnaire (LLFQ)", 31, "LLFQ", instruction);
            newQuestionaire.addQuestion(1, new QuestionStencil("BlankResponseQuestion", "Participant's Id:", 1, false));
            newQuestionaire.addQuestion(2, new QuestionStencil("BlankResponseQuestion", "Participant's Age:", 2, false));

            QuestionStencil gender = new QuestionStencil("multipleChoiceQuestion", "Gender:", 3, false, false);
            gender.setMCOption(0, "Male");
            gender.setMCOption(1, "Female");
            gender.setMCOption(2, "Enter the choice here...");
            gender.setMCOption(3, "Enter the choice here...");
            gender.setMCOption(4, "Enter the choice here...");
            gender.setMCOption(5, "Enter the choice here...");
            newQuestionaire.addQuestion(3, gender);

            newQuestionaire.addQuestion(4, new QuestionStencil("BlankResponseQuestion", "Diagnosis:", 4, false));
            newQuestionaire.addQuestion(5, new QuestionStencil("BlankResponseQuestion", "Type of assistive device:", 5, false));

            QuestionStencil condition = new QuestionStencil("multipleChoiceQuestion", "Condition of Device:", 6, false, true);
            condition.setMCOption(0, "Newly Fitted");
            condition.setMCOption(1, "Good Working Condition");
            condition.setMCOption(2, "Poor/needs replacing");
            condition.setMCOption(2, "Poor/needs replacing");
            condition.setMCOption(3, "Other/details");
            condition.setMCOption(4, "Enter the choice here...");
            condition.setMCOption(5, "Enter the choice here...");
            newQuestionaire.addQuestion(6, condition);


            newQuestionaire.addQuestion(7, new QuestionStencil("BlankResponseQuestion", "Participant’s profession or current school grade level:", 7, false));
            newQuestionaire.addQuestion(8, new QuestionStencil("BlankResponseQuestion", "Researcher's Name:", 8, false));
            newQuestionaire.addQuestion(9, new QuestionStencil("BlankResponseQuestion", "Date:", 9, false));

            newQuestionaire.addQuestion(10, new QuestionStencil("ratingScaleQuestion", "Rate how your gait looks while you are walking (from “poor”– very abnormal, to “excellent very normal).", 10, false));
            newQuestionaire.addQuestion(11, new QuestionStencil("ratingScaleQuestion", "Rate how you sound while walking (from “poor” – very abnormal, to “excellent”– very normal).", 11, false));
            newQuestionaire.addQuestion(12, new QuestionStencil("ratingScaleQuestion", "Rate your comfort while walking (from “poor” – very uncomfortable, to “excellent” – very comfortable).", 12, false));
            newQuestionaire.addQuestion(13, new QuestionStencil("ratingScaleQuestion", "Rate your pain while walking (from “poor” – a lot of pain, to “excellent” – no pain).", 13, false));
            newQuestionaire.addQuestion(14, new QuestionStencil("ratingScaleQuestion", "Rate how balanced you feel while standing (from “poor” – often unbalanced, to “excellent” –  never off balance).", 14, false));

            newQuestionaire.addQuestion(15, new QuestionStencil("ratingScaleQuestion", "Rate how balanced you feel while walking(from “poor”– often unbalanced, to “excellent” – never off balance).", 15, false));
            newQuestionaire.addQuestion(16, new QuestionStencil("ratingScaleQuestion", "Rate how often you fall (from “poor”  – very often, to “excellent” – almost never).", 16, false));
            newQuestionaire.addQuestion(17, new QuestionStencil("ratingScaleQuestion", "Rate how exhausting it is for you to walk as long as you need to (from “poor” – very exhausting, \nto “excellent” – not exhausting).", 17, false));
            newQuestionaire.addQuestion(18, new QuestionStencil("ratingScaleQuestion", "Rate the amount of energy it takes to walk as long as you need to (from “poor” –  a lot of energy, to “excellent” –  very little energy).", 18, false));
            newQuestionaire.addQuestion(19, new QuestionStencil("ratingScaleQuestion", "Rate how difficult it is for you to walk around and between obstacles and in narrow spaces (from “poor” – very difficult, to “excellent” – not difficult at all).", 19, false));

            newQuestionaire.addQuestion(20, new QuestionStencil("ratingScaleQuestion", "Rate how awkward it is to walk (from “poor” – very awkward, to “excellent” – not awkward at all).", 20, false));
            newQuestionaire.addQuestion(21, new QuestionStencil("ratingScaleQuestion", "Rate how difficult it is for you to go down stairs (from “poor” – very difficult, to “excellent” – not difficult at all).", 21, false));
            newQuestionaire.addQuestion(22, new QuestionStencil("ratingScaleQuestion", "Rate how difficult it is for you to go upstairs (from “poor” – very difficult, to “excellent” – not difficult at all).", 22, false));
            newQuestionaire.addQuestion(23, new QuestionStencil("ratingScaleQuestion", "Rate how difficult it is for you to go down a slope or hill (from “poor” – very difficult, to “excellent” – not difficult at all).", 23, false));
            newQuestionaire.addQuestion(24, new QuestionStencil("ratingScaleQuestion", "Rate how difficult it is for you to go up a slope or hill (from “poor” – very difficult, to excellent” – not difficult at all).", 24, false));

            newQuestionaire.addQuestion(25, new QuestionStencil("ratingScaleQuestion", "Rate how difficult it is for you to sit down and stand up (from “poor” – very difficult, to “excellent” – not difficult at all).", 25, false));
            newQuestionaire.addQuestion(26, new QuestionStencil("ratingScaleQuestion", "Rate how difficult it is to get in and out of motor vehicles (from “poor” – very difficult, to “excellent” – not difficult at all). \nIf you do not use motor vehicles such as cars, vans or buses, check the N/A box:", 26, true));
            newQuestionaire.addQuestion(27, new QuestionStencil("ratingScaleQuestion", "Rate how difficult it is to run (from “poor” – very difficult, cannot run, to “excellent” – not difficult at all).", 27, false));
            newQuestionaire.addQuestion(28, new QuestionStencil("ratingScaleQuestion", "Rate how difficult it is to walk on uneven terrain (from “poor” – very difficult, cannot run, to “excellent” – not difficult at all).", 28, false));
            newQuestionaire.addQuestion(29, new QuestionStencil("ratingScaleQuestion", "Rate how satisfied you are personally with your lower limb function (from “poor” – not satisfied at all, to “excellent” – very satisfied).", 29, false));
            newQuestionaire.addQuestion(30, new QuestionStencil("BlankResponseQuestion", "Please provide any other information about your lower limb function or assistive device that you would like to share:", 30, false));

            HomePageButton aButton = new HomePageButton("Lower Limbs Functionality Questionnaire (LLFQ)", "Use this questionnaire to compare your lower limb function and movement to that of a person of your age and "
                + "gender who does not have a physical disability or need an assistive device.", newQuestionaire);
            openSpaceGrid.Items.Add(aButton);


            //HomePageButton bButton = new HomePageButton("B Button", "-For Testing Purposes Only-", newQuestionaire);
            //addNewButton(bButton);
            

        }
    }
}