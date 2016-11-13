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
    /// Interaction logic for BlankResponseQuestion.xaml
    /// </summary>

    [Serializable]
    public partial class BlankResponseQuestion : UserControl, Question<BlankResponseQuestion>
    {
        public Boolean isForQuestionaire = false;
        public Boolean isDeleted = false;
        public Boolean hasNaOption = false;
        private String questionText = "Is HyeMi your favorite friend?";
        private String userComment = "Yes! Of course :D";
        private int questionLocationNumber = 1;
        private String questionType = "BlankResponseQuestion";

        public BlankResponseQuestion()
        {
            InitializeComponent();
        }

        public BlankResponseQuestion(Boolean forQuestionaire, int questionNumber, String questionText)
        {
            this.isForQuestionaire = forQuestionaire;
            this.questionLocationNumber = questionNumber;
            this.questionText = questionText;
            InitializeComponent();
            initializeQuestionaireType();
            initializeData();

        }


        public bool Equals(BlankResponseQuestion blankResponseQuestion)
        {
            if (this.questionType == blankResponseQuestion.questionType)
            {
                return true;
            }
            else
                return false;
        }

        private void initializeData()
        {
            if (questionText != null)
                questionTextOutput.Text = questionText;
            questionNumber.Text = questionLocationNumber.ToString();
        }

        private void initializeQuestionaireType()
        {
            if (isForQuestionaire)
            {
                questionTextInput.Visibility = Visibility.Collapsed;
                deletIconBackground.Visibility = Visibility.Collapsed;
                questionNumber.IsReadOnly = true;
                questionTextOutput.Visibility = Visibility.Visible;
            }
            else
            {
                responseText.IsReadOnly = true;
                responseText.Background = new SolidColorBrush(Colors.LightGray);
            }
        }

        public String getQuestionType()
        {
            return questionType;
        }

        public String getQuestionText()
        {
            return questionText;
        }

        private void CloseButton_MouseOver(object sender, MouseEventArgs e)
        {
            deletIconBackground.Background = (Brush)Application.Current.MainWindow.FindResource("CloseButtonRed");
        }

        private void CloseButton_MouseLeave(object sender, MouseEventArgs e)
        {
            deletIconBackground.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void CloseButton_MouseUP(object sender, MouseButtonEventArgs e)
        {
            deletIconBackground.Background = new SolidColorBrush(Colors.Transparent);
            this.Visibility = Visibility.Collapsed;
            isDeleted = true;
        }

        private void newQuestionBox_gotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (questionTextInput.Text == "Enter the question here...")
            {
                questionTextInput.Text = "";
                questionTextInput.Foreground = (Brush)Application.Current.MainWindow.FindResource("TextDarkColor");
            }
        }

        private void newQuestionBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (questionTextInput.Text == "")
            {
                questionTextInput.Text = "Enter the question here...";
                questionTextInput.Foreground = (Brush)Application.Current.MainWindow.FindResource("CloseButtonRed"); ;
            }
        }
    }
}
