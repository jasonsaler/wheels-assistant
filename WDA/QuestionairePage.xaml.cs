using System.IO;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using System;

namespace WheelsDataAssistant
{
    /// <summary>
    /// Interaction logic for QuestionairePage.xaml
    /// </summary>
    public partial class QuestionairePage : System.Windows.Controls.Page
    {
        static int ClicksCount = 0;
        static int count = 2;
        static int s_nonQuestionListItmes = 2;
        string f = "records.xls";
        Questionaire theQuestionnaire;
        String m_currentQuestionType;
        String m_filename = "";

        public QuestionairePage(Questionaire currentQuestionnaire)
        {
            this.theQuestionnaire = currentQuestionnaire;
            InitializeComponent();
            titlelabel.Content = currentQuestionnaire.getQuestionaireName();
            instructionslabel.Text = "Instructions: " + currentQuestionnaire.getInstructions();
            loadQuestions();
        }

        public QuestionairePage()
        {
            InitializeComponent();
        }

        private void loadQuestions()
        {
            for(int i=1; i<theQuestionnaire.getNumberOfQuestions(); i++)
            {
                if (theQuestionnaire.questionList[i] != null)
                {
                    switch (theQuestionnaire.questionList[i].getQuestionType())
                    {
                        case "ratingScaleQuestion":
                            RatingScaleQuestion newRSQ = new RatingScaleQuestion(true, theQuestionnaire.questionList[i].getQuestionNumber(), theQuestionnaire.questionList[i].getQuestionText());
                            newRSQ.setNAOption(theQuestionnaire.questionList[i].m_hasNaOption);
                            pageGrid.Items.Add(newRSQ);
                            break;
                        case "BlankResponseQuestion":
                            BlankResponseQuestion newBRQ = new BlankResponseQuestion(true, theQuestionnaire.questionList[i].getQuestionNumber(), theQuestionnaire.questionList[i].getQuestionText());
                            newBRQ.setNAOption(theQuestionnaire.questionList[i].m_hasNaOption);
                            pageGrid.Items.Add(newBRQ);
                            break;
                        case "multipleChoiceQuestion":
                            QuestionControls.MultipleChoiceQuestion newMCQ = new QuestionControls.MultipleChoiceQuestion(true, theQuestionnaire.questionList[i].getQuestionNumber(), theQuestionnaire.questionList[i].getQuestionText(), theQuestionnaire.questionList[i].hasCommentOption);
                            newMCQ.firstChoiceInput.Text = theQuestionnaire.questionList[i].getMCOption(0);
                            newMCQ.secondChoiceInput.Text = theQuestionnaire.questionList[i].getMCOption(1);
                            newMCQ.thirdChoiceInput.Text = theQuestionnaire.questionList[i].getMCOption(2);
                            newMCQ.fourthChoiceInput.Text = theQuestionnaire.questionList[i].getMCOption(3);
                            newMCQ.fifthChoiceInput.Text = theQuestionnaire.questionList[i].getMCOption(4);
                            newMCQ.sixthChoiceInput.Text = theQuestionnaire.questionList[i].getMCOption(5);
                            newMCQ.choiceVisibilityShowHide();
                            newMCQ.setNAOption(theQuestionnaire.questionList[i].m_hasNaOption);
                            pageGrid.Items.Add(newMCQ);
                            break;
                    }
                }
                    
            }
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            HelpPage helpPage = new HelpPage();
            this.NavigationService.Navigate(helpPage);
        }

        private Boolean saveHandler(Boolean isSaveNew)
        {
            if (m_filename == "")
                isSaveNew = true;

            ToastNotification progressSavedToast;
            if (isSaveNew)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
                if (saveFileDialog.ShowDialog() != true)
                {
                    progressSavedToast = new ToastNotification("Canceled", 3, 0);
                    progressSavedToast.Visibility = Visibility.Visible;
                    openSpaceGrid.Children.Add(progressSavedToast);

                    return false;
                }

                m_filename = saveFileDialog.FileName;
            }

            if (dataToFile(isSaveNew))
            {
                string path = m_filename.Substring(0, m_filename.LastIndexOf('\\'));
                string name = m_filename.Substring(m_filename.LastIndexOf('\\') + 1, m_filename.LastIndexOf('.') - m_filename.LastIndexOf('\\') - 1);

                ReportManager.GenerateIndividualReport(theQuestionnaire, path, name);
                progressSavedToast = new ToastNotification("Progress saved successfully", 7, 1);
                progressSavedToast.Visibility = Visibility.Visible;
                openSpaceGrid.Children.Add(progressSavedToast);

                return true;
            }

            progressSavedToast = new ToastNotification("Could not save the responses", 7, -1);
            progressSavedToast.Visibility = Visibility.Visible;
            openSpaceGrid.Children.Add(progressSavedToast);
            return false;
        }


        private Boolean dataToFile(Boolean isSaveNew)
        {
            theQuestionnaire.clearDictionaryForNewData();

            RatingScaleQuestion temporaryRSQ = new RatingScaleQuestion();
            BlankResponseQuestion temporaryBRQ = new BlankResponseQuestion();
            QuestionControls.MultipleChoiceQuestion temporaryMCQ = new QuestionControls.MultipleChoiceQuestion();

            for (int i = s_nonQuestionListItmes; i < theQuestionnaire.getNumberOfQuestions() + s_nonQuestionListItmes - 1; i++)
            {
                try
                {
                    RatingScaleQuestion temporaryRSQuestion = (RatingScaleQuestion)pageGrid.Items.GetItemAt(i);
                    m_currentQuestionType = temporaryRSQuestion.getQuestionType();
                }
                catch
                {
                    try
                    {
                        BlankResponseQuestion temporaryBRQuestion = (BlankResponseQuestion)pageGrid.Items.GetItemAt(i);
                        m_currentQuestionType = temporaryBRQuestion.getQuestionType();
                    }
                    catch
                    {
                        try
                        {
                            QuestionControls.MultipleChoiceQuestion temporaryMCQuestion = (QuestionControls.MultipleChoiceQuestion)pageGrid.Items.GetItemAt(i);
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
                    RatingScaleQuestion currentQuestion = (RatingScaleQuestion)pageGrid.Items.GetItemAt(i);
                    theQuestionnaire.QuestionResponses.Add(currentQuestion.getResponse());
                }
                else if (m_currentQuestionType == temporaryBRQ.getQuestionType())
                {
                    BlankResponseQuestion currentQuestion = (BlankResponseQuestion)pageGrid.Items.GetItemAt(i);
                    theQuestionnaire.UserData.Add(currentQuestion.questionTextOutput.Text, currentQuestion.getResponse());
                }
                else
                {
                    QuestionControls.MultipleChoiceQuestion currentQuestion = (QuestionControls.MultipleChoiceQuestion)pageGrid.Items.GetItemAt(i);
                    theQuestionnaire.UserData.Add(currentQuestion.getQuestionText(), currentQuestion.getResponse());
                }
            }
            return true;
        }

        private void SaveNewButton_Click(object sender, RoutedEventArgs e)
        {
            Boolean isSaveNew = true;
            saveHandler(isSaveNew);
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            Boolean isSaveNew = false;
            saveHandler(isSaveNew);
        }

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            Boolean isSaveNew = false;
            if (saveHandler(isSaveNew))
            {
                ReportManager.GenerateIndividualReport(theQuestionnaire, @"C:\Users\jsaler\OneDrive\School Work\Software Engineering II", "Noodles");
                HomePage homePage = new HomePage();
                this.NavigationService.Navigate(homePage);
            }
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to close this form? Changes will not be saved?", "Cancel", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                HomePage homePage = new HomePage();
                this.NavigationService.Navigate(homePage);
            }
        }
    }
}

