using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WheelsDataAssistant
{
    /// <summary>
    /// Interaction logic for NewQuestionnairePage.xaml
    /// </summary>
    /// 
    public partial class NewQuestionnairePage : Page
    {
        static int s_numberOfConstantListItems = 5;

        int m_QuestionGridLocation = 0;
        int m_QuestionNumber = 1;
        int m_listViewSize = s_numberOfConstantListItems;
        int m_count = 0;
        String m_currentQuestionType;
        private static Questionaire m_Questionnaire;
        Questionaire m_currentQuestionaire;
        private static string dataFileName; 

        private BinaryFormatter formatter = new BinaryFormatter();

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

        }

        private void helpButton_Click(object sender, RoutedEventArgs e)
        {
            HelpPage helpPage = new HelpPage();
            this.NavigationService.Navigate(helpPage);
        }

        private void finishButton_Click(object sender, RoutedEventArgs e)
        {
            if (SaveNewQuestionnaireProgress() == true)
            {
                if (Save() == true)
                {
                    if (descriptionText.Text == "")
                    {
                        ToastNotification progressSavedToast = new ToastNotification("Questionnaire saved successfully, however it is recommended to include a description", 7, 0);
                        progressSavedToast.Visibility = Visibility.Visible;
                        openSpaceGrid.Children.Add(progressSavedToast);
                    }
                    else
                    {
                        ToastNotification progressSavedToast = new ToastNotification("Progress saved sucessfully", 7);
                        progressSavedToast.Visibility = Visibility.Visible;
                        openSpaceGrid.Children.Add(progressSavedToast);
                    }

                    HomePageButton sendButton = new HomePageButton(m_Questionnaire);
                    HomePage goHome = new HomePage(sendButton);
                    NavigationService navService = NavigationService.GetNavigationService(this);
                    navService.Navigate(goHome);
                }
                else
                {
                    ToastNotification progressSavedToast = new ToastNotification("Failed to save progress; Serialization error", 7, -1);
                    progressSavedToast.Visibility = Visibility.Visible;
                    openSpaceGrid.Children.Add(progressSavedToast);
                }
            }
        }

        private void SaveProgressButton_Click(object sender, RoutedEventArgs e)
        {
            if (SaveNewQuestionnaireProgress() == true)
            {
                if (Save() == true)
                {
                    if (descriptionText.Text == "")
                    {
                        ToastNotification progressSavedToast = new ToastNotification("Questionnaire saved successfully, however it is recommended to include a description", 7, 0);
                        progressSavedToast.Visibility = Visibility.Visible;
                        openSpaceGrid.Children.Add(progressSavedToast);
                    }
                    else
                    {
                        ToastNotification progressSavedToast = new ToastNotification("Progress saved sucessfully", 7);
                        progressSavedToast.Visibility = Visibility.Visible;
                        openSpaceGrid.Children.Add(progressSavedToast);
                    }
                }
                else
                {
                    ToastNotification progressSavedToast = new ToastNotification("Failed to save progress; Serialization error", 7, -1);
                    progressSavedToast.Visibility = Visibility.Visible;
                    openSpaceGrid.Children.Add(progressSavedToast);
                }
            }
        }

        private Boolean SaveNewQuestionnaireProgress()
        {
            if(questionaireTitle.Text == "")
            {
                ToastNotification progressSavedToast = new ToastNotification("Questionnaire must contain a title", 7, -1);
                progressSavedToast.Visibility = Visibility.Visible;
                openSpaceGrid.Children.Add(progressSavedToast);
                return false;
            }
            else if(questionaireType.Text == "")
            {
                ToastNotification progressSavedToast = new ToastNotification("Questionnaire must contain a type", 7, -1);
                progressSavedToast.Visibility = Visibility.Visible;
                openSpaceGrid.Children.Add(progressSavedToast);
                return false;
            }
            else if(questionaireInstruction.Text == "")
            {
                ToastNotification progressSavedToast = new ToastNotification("Questionnaire must contain instructions", 7, -1);
                progressSavedToast.Visibility = Visibility.Visible;
                openSpaceGrid.Children.Add(progressSavedToast);
                return false;
            }

            m_currentQuestionaire = new Questionaire(questionaireTitle.Text, m_QuestionNumber, questionaireType.Text, questionaireInstruction.Text);
            m_currentQuestionaire.setDescription(descriptionText.Text);

            m_count = s_numberOfConstantListItems;
            while (m_count < m_listViewSize)
            {

                RatingScaleQuestion temporaryRSQ = new RatingScaleQuestion();
                BlankResponseQuestion temporaryBRQ = new BlankResponseQuestion();
                QuestionControls.MultipleChoiceQuestion temporaryMCQ = new QuestionControls.MultipleChoiceQuestion();

                try
                {
                    RatingScaleQuestion temporaryRSQuestion = (RatingScaleQuestion)pageGrid.Items.GetItemAt(m_count);
                    m_currentQuestionType = temporaryRSQuestion.getQuestionType();
                }
                catch
                {
                    try
                    {
                        BlankResponseQuestion temporaryBRQuestion = (BlankResponseQuestion)pageGrid.Items.GetItemAt(m_count);
                        m_currentQuestionType = temporaryBRQuestion.getQuestionType();
                    }
                    catch
                    {
                        try
                        {
                            QuestionControls.MultipleChoiceQuestion temporaryMCQuestion = (QuestionControls.MultipleChoiceQuestion)pageGrid.Items.GetItemAt(m_count);
                            m_currentQuestionType = temporaryMCQuestion.getQuestionType();
                        }
                        catch
                        {
                            return false;
                        }
                    }
                }

                if (m_currentQuestionType == temporaryRSQ.getQuestionType())
                {
                    RatingScaleQuestion currentQuestion = (RatingScaleQuestion)pageGrid.Items.GetItemAt(m_count);
                    if (errorCatcher(currentQuestion) == false)
                    {
                        return false;
                    }
                    QuestionStencil questionInfo = new QuestionStencil(currentQuestion.getQuestionType(), currentQuestion.getQuestionText(), Convert.ToInt32(currentQuestion.questionNumber.Text), currentQuestion.hasNaOption);
                    m_currentQuestionaire.addQuestion(Convert.ToInt32(currentQuestion.questionNumber.Text), questionInfo);
                }
                else if (m_currentQuestionType == temporaryBRQ.getQuestionType())
                {
                    BlankResponseQuestion currentQuestion = (BlankResponseQuestion)pageGrid.Items.GetItemAt(m_count);
                    if (errorCatcher(currentQuestion) == false)
                    {
                        return false;
                    }

                    QuestionStencil questionInfo = new QuestionStencil(currentQuestion.getQuestionType(), currentQuestion.getQuestionText(), Convert.ToInt32(currentQuestion.questionNumber.Text), currentQuestion.hasNaOption);
                    m_currentQuestionaire.addQuestion(Convert.ToInt32(currentQuestion.questionNumber.Text), questionInfo);
                }
                else
                {
                    QuestionControls.MultipleChoiceQuestion currentQuestion = (QuestionControls.MultipleChoiceQuestion)pageGrid.Items.GetItemAt(m_count);
                    if (errorCatcher(currentQuestion) == false)
                    {
                        return false;
                    }

                    QuestionStencil questionInfo = new QuestionStencil(currentQuestion.getQuestionType(), currentQuestion.getQuestionText(), Convert.ToInt32(currentQuestion.questionNumber.Text), currentQuestion.hasNaOption);
                    m_currentQuestionaire.addQuestion(Convert.ToInt32(currentQuestion.questionNumber.Text), questionInfo);
                }
                
            }
            m_Questionnaire = m_currentQuestionaire;
            return true;
        }

        private void RatinQuestionButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            RatingScaleQuestion scaleQuestion = new RatingScaleQuestion(false, m_QuestionNumber, null);
            pageGrid.Items.Add(scaleQuestion);
            m_QuestionNumber++;
            m_listViewSize++;
            m_QuestionGridLocation++;
            scaleQuestion.resize();
        }

        private void BlankResponseQuestionButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            BlankResponseQuestion blankQuestion = new BlankResponseQuestion(false, m_QuestionNumber, null);
            m_QuestionNumber++;
            m_listViewSize++;
            pageGrid.Items.Add(blankQuestion);
        }

        public Boolean Save()
        {
            dataFileName = m_Questionnaire.getQuestionaireName() + ".dat";
            //FileStream writerFileStream = new FileStream(dataFileName, FileMode.Create, FileAccess.Write);

            // Gain code access to the file that we are going
            // to write to
            try
            {
                //Create a FileStream that will write data to file.
                FileStream writerFileStream = new FileStream(dataFileName, FileMode.Create, FileAccess.Write);
                // Save our dictionary of friends to file
                formatter.Serialize(writerFileStream, m_Questionnaire);

                // Close the writerFileStream when we are done.
                writerFileStream.Close();
            }
            catch (Exception)
            {
               return false;
            } // end try-catch

            //XamlWriter.Save(m_Questionnaire, writerFileStream);

            return true;
        }

        private Boolean errorCatcher(RatingScaleQuestion currentQuestion)
        {
             
            if (currentQuestion.isDeleted)
            {
                pageGrid.Items.RemoveAt(m_count);
                m_listViewSize--;
            }
            else
            {
                int currentQuestionNumber = 0;
                try
                {
                    currentQuestionNumber = Convert.ToInt32(currentQuestion.questionNumber.Text);
                }
                catch (FormatException e)
                {
                    ToastNotification progressSavedToast = new ToastNotification("Question numbers may contain numeric characters only and may not be left blank", 7, -1);
                    progressSavedToast.Visibility = Visibility.Visible;
                    openSpaceGrid.Children.Add(progressSavedToast);
                    return false;
                }

                if (currentQuestionNumber > m_listViewSize - s_numberOfConstantListItems)
                {
                    ToastNotification progressSavedToast = new ToastNotification("A question number may not be greater than the number of questions", 7, -1);
                    progressSavedToast.Visibility = Visibility.Visible;
                    openSpaceGrid.Children.Add(progressSavedToast);
                    return false;
                }

                // Should use the same code for all three question types in here. Just verify which type it is before adding into an array.

                if (m_currentQuestionaire.addNewRatingScaleQuestion(currentQuestionNumber, currentQuestion) != true)
                {
                    ToastNotification progressSavedToast = new ToastNotification("Two Questions may not have the same number", 7, -1);
                    progressSavedToast.Visibility = Visibility.Visible;
                    openSpaceGrid.Children.Add(progressSavedToast);
                    return false;
                }
                m_count++;
            }

            return true;
        }

        private Boolean errorCatcher(BlankResponseQuestion currentQuestion)
        {

            if (currentQuestion.isDeleted)
            {
                pageGrid.Items.RemoveAt(m_count);
                m_listViewSize--;
            }
            else
            {
                int currentQuestionNumber = 0;
                try
                {
                    currentQuestionNumber = Convert.ToInt32(currentQuestion.questionNumber.Text);
                }
                catch (FormatException e)
                {
                    ToastNotification progressSavedToast = new ToastNotification("Question numbers may contain numeric characters only and may not be left blank", 7, -1);
                    progressSavedToast.Visibility = Visibility.Visible;
                    openSpaceGrid.Children.Add(progressSavedToast);
                    return false;
                }

                if (currentQuestionNumber > m_listViewSize - s_numberOfConstantListItems)
                {
                    ToastNotification progressSavedToast = new ToastNotification("A question number may not be greater than the number of questions", 7, -1);
                    progressSavedToast.Visibility = Visibility.Visible;
                    openSpaceGrid.Children.Add(progressSavedToast);
                    return false;
                }

                // Should use the same code for all three question types in here. Just verify which type it is before adding into an array.

                if (m_currentQuestionaire.addNewBlankResponseQuestion(currentQuestionNumber, currentQuestion) != true)
                {
                    ToastNotification progressSavedToast = new ToastNotification("Two Questions may not have the same number", 7, -1);
                    progressSavedToast.Visibility = Visibility.Visible;
                    openSpaceGrid.Children.Add(progressSavedToast);
                    return false;
                }
                m_count++;
            }

            return true;
        }

        private Boolean errorCatcher(QuestionControls.MultipleChoiceQuestion currentQuestion)
        {

            if (currentQuestion.isDeleted)
            {
                pageGrid.Items.RemoveAt(m_count);
                m_listViewSize--;
            }
            else
            {
                int currentQuestionNumber = 0;
                try
                {
                    currentQuestionNumber = Convert.ToInt32(currentQuestion.questionNumber.Text);
                }
                catch (FormatException e)
                {
                    ToastNotification progressSavedToast = new ToastNotification("Question numbers may contain numeric characters only and may not be left blank", 7, -1);
                    progressSavedToast.Visibility = Visibility.Visible;
                    openSpaceGrid.Children.Add(progressSavedToast);
                    return false;
                }

                if (currentQuestionNumber > m_listViewSize - s_numberOfConstantListItems)
                {
                    ToastNotification progressSavedToast = new ToastNotification("A question number may not be greater than the number of questions", 7, -1);
                    progressSavedToast.Visibility = Visibility.Visible;
                    openSpaceGrid.Children.Add(progressSavedToast);
                    return false;
                }

                // Should use the same code for all three question types in here. Just verify which type it is before adding into an array.

                if (m_currentQuestionaire.addNewMultipleChoiceQuestion(currentQuestionNumber, currentQuestion) != true)
                {
                    ToastNotification progressSavedToast = new ToastNotification("Two Questions may not have the same number", 7, -1);
                    progressSavedToast.Visibility = Visibility.Visible;
                    openSpaceGrid.Children.Add(progressSavedToast);
                    return false;
                }
                m_count++;
            }

            return true;
        }

        private void MultipleChoiceButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            QuestionControls.MultipleChoiceQuestion multiChoiceQuestion = new QuestionControls.MultipleChoiceQuestion(false, m_QuestionNumber, null, false);
            m_QuestionNumber++;
            m_listViewSize++;
            pageGrid.Items.Add(multiChoiceQuestion);
        }
    }
}
