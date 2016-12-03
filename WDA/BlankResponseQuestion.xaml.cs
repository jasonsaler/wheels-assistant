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
        private String questionText = "";
        private String userComment = "";
        private int questionLocationNumber = 1;
        private String questionType = "BlankResponseQuestion";

        public BlankResponseQuestion()
        {
            InitializeComponent();
        }

        public BlankResponseQuestion(Boolean forQuestionaire, int questionNumber, String questionTexts)
        {
            this.isForQuestionaire = forQuestionaire;
            this.questionLocationNumber = questionNumber;
            this.questionText = questionTexts;
            InitializeComponent();
            initializeData();
            initializeQuestionaireType();
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
                questionNumber.BorderThickness = new Thickness(0);
                questionNumber.Text = questionLocationNumber.ToString() + ".";
                questionTextOutput.Visibility = Visibility.Visible;
                responseText.Text = "Enter response here...";
                responseText.Foreground = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorLight");
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
            questionText = questionTextInput.Text;
            return questionText;
        }

        public void setNAOption(Boolean option)
        {
            hasNaOption = option;
            if(hasNaOption == false)
            {
                naCheckbox.Visibility = Visibility.Collapsed;
            }
            else
            {
                naCheckbox.Visibility = Visibility.Visible;
            }
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

        private void ResponseBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (responseText.Text == "Enter response here...")
            {
                responseText.Text = "";
                responseText.Foreground = (Brush)Application.Current.MainWindow.FindResource("TextDarkColor");
            }
        }

        private void ResponseBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (responseText.Text == "")
            {
                responseText.Text = "Enter response here...";
                responseText.Foreground = (Brush)Application.Current.MainWindow.FindResource("CloseButtonRed"); ;
            }
        }

        private void NACheckBox_GotChecked(object sender, RoutedEventArgs e)
        {
            if (!isForQuestionaire)
            {
                hasNaOption = true;
            }
            else
            {
                responseText.Background = new SolidColorBrush(Colors.LightGray);
                responseText.Foreground = new SolidColorBrush(Colors.Black);
                responseText.IsReadOnly = true;
                responseText.Text = "Not Applicable";
            }
        }

        private void NACheckBox_GotUnchecked(object sender, RoutedEventArgs e)
        {
            if (!isForQuestionaire)
            {
                hasNaOption = false;
            }
            else
            {
                responseText.Background = new SolidColorBrush(Colors.White);
                responseText.IsReadOnly = false;
                responseText.Text = "Enter response here...";
            }
        }

        public String getResponse()
        {
            if (responseText.Text != "Enter response here...")
                return responseText.Text;
            else
                return "No response";
        }
    }
}
