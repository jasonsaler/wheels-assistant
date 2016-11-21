using System.IO;
using Microsoft.Win32;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Office.Interop.Excel;

namespace WheelsDataAssistant
{
    /// <summary>
    /// Interaction logic for QuestionairePage.xaml
    /// </summary>
    public partial class QuestionairePage : System.Windows.Controls.Page
    {
        static int ClicksCount = 0;
        static int count = 2;
        string f = "records.xls";
        Questionaire theQuestionnaire;

        public QuestionairePage(Questionaire currentQuestionnaire)
        {
            this.theQuestionnaire = currentQuestionnaire;
            InitializeComponent();
            titlelabel.Content = currentQuestionnaire.getQuestionaireName();
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

        private void SaveNewButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
            //if (saveFileDialog.ShowDialog() == true)
                //File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
        }

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
            this.NavigationService.Navigate(homePage);
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


        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //string t = txtEditor.Text;
            saveFileDialog.FileName = "records.xls";
            string s = saveFileDialog.SafeFileName;
            ClicksCount++;
            if (ClicksCount == 1)
            {
                saveFileDialog.CreatePrompt = true;
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.DefaultExt = "xls";
                saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
                if (saveFileDialog.ShowDialog() == true)
                {
                    //File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
                }
            }
            else
            {
                try
                {/*
                    File.SetAttributes(s, FileAttributes.Normal);
                    saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
                    var excelApp = new Excel.Application();
                    excelApp.Workbooks.Open(f, 3, false, 5, Type.Missing, Type.Missing, true);
                    Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
                    workSheet.Cells[count, "A"] = t;
                    count++;
                    File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
                    excelApp.DisplayAlerts = false;
                    workSheet.SaveAs(f, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, true, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    excelApp.Workbooks.Close();
                    excelApp.Quit();
                    MessageBox.Show("Saved");*/
                }
                catch (FileNotFoundException) { }
            }
        }
    }
}

