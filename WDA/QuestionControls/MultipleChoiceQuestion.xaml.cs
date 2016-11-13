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

namespace WheelsDataAssistant.QuestionControls
{
    /// <summary>
    /// Interaction logic for MultipleChoiceQuestion.xaml
    /// </summary>
    
    [Serializable]
    public partial class MultipleChoiceQuestion : UserControl, Question<MultipleChoiceQuestion>
    {
        public Boolean isForQuestionaire = false;
        public Boolean isDeleted = false;
        public Boolean hasNaOption = false;
        private String questionText = "Is HyeMi your best friend?";
        private String userComment = "Yes! Of course :D";
        private String chosenAnswer = "Duh";
        private int questionLocationNumber = 1;
        private String questionType = "multipleChoiceQuestion";

        public bool Equals(MultipleChoiceQuestion multipleChoiceQuestion)
        {
            if (this.questionType == multipleChoiceQuestion.questionType)
            {
                return true;
            }
            else
                return false;
        }


        public MultipleChoiceQuestion()
        {
            InitializeComponent();
        }

        public MultipleChoiceQuestion(Boolean forQuestionaire, int questionNumber, String questionText)
        {
            this.isForQuestionaire = forQuestionaire;
            this.questionLocationNumber = questionNumber;
            this.questionText = questionText;
            InitializeComponent();
            newQuestion.Width = 800;
            initializeQuestionaireType();
            initializeData();

        }

        private void initializeData()
        {
            if (questionText != null)
                Question.Text = questionText;
            questionNumber.Text = questionLocationNumber.ToString();
        }

        private void initializeQuestionaireType()
        {
            if (isForQuestionaire)
            {
                newQuestion.Visibility = Visibility.Collapsed;
                deletIconBackground.Visibility = Visibility.Collapsed;
                questionNumber.IsReadOnly = true;
                Question.Visibility = Visibility.Visible;
            }
        }

        private void SliderBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //sliderMark.Visibility = Visibility.Visible;
            //sliderMark.TranslatePoint( Mouse.GetPosition(this), sliderBar);
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

        public String getQuestionType()
        {
            return questionType;
        }

        public String getQuestionText()
        {
            return questionText;
        }

        private void plusIcon_MouseUp(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void PlusButton_MouseOver(object sender, MouseEventArgs e)
        {
            plusIconBackground.Background = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorDark");
        }

        private void PlusButton_MouseLeave(object sender, MouseEventArgs e)
        {
            plusIconBackground.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void PlusButton_MouseUP(object sender, MouseButtonEventArgs e)
        {
            plusIconBackground.Background = new SolidColorBrush(Colors.Transparent);
            if(thirdButton.Visibility != Visibility.Visible)
            {
                thirdChoiceInput.Foreground = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorLight");
                thirdButton.Visibility = Visibility.Visible;
                minusIconBackground.Visibility = Visibility.Visible;
            }
            else if (fourthButton.Visibility != Visibility.Visible)
            {
                fourthChoiceInput.Foreground = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorLight");
                fourthButton.Visibility = Visibility.Visible;
            }
            else if (fifthButton.Visibility != Visibility.Visible)
            {
                fifthChoiceInput.Foreground = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorLight");
                fifthButton.Visibility = Visibility.Visible;
            }
            else if (sixthButton.Visibility != Visibility.Visible)
            {
                sixthChoiceInput.Foreground = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorLight");
                sixthButton.Visibility = Visibility.Visible;
                plusIconBackground.Visibility = Visibility.Collapsed;
            }
        }

        private void MinusButton_MouseOver(object sender, MouseEventArgs e)
        {
            minusIconBackground.Background = (Brush)Application.Current.MainWindow.FindResource("WarningYellow");
        }

        private void MinusButton_MouseLeave(object sender, MouseEventArgs e)
        {
            minusIconBackground.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void MinusButton_MouseUP(object sender, MouseButtonEventArgs e)
        {
            minusIconBackground.Background = new SolidColorBrush(Colors.Transparent);
            if (sixthButton.Visibility == Visibility.Visible)
            {
                sixthButton.Visibility = Visibility.Collapsed;
                sixthChoiceInput.Text = "Enter the choice here...";
                plusIconBackground.Visibility = Visibility.Visible;
            }
            else if (fifthButton.Visibility == Visibility.Visible)
            {
                fifthButton.Visibility = Visibility.Collapsed;
                fifthChoiceInput.Text = "Enter the choice here...";
            }
            else if (fourthButton.Visibility == Visibility.Visible)
            {
                fourthButton.Visibility = Visibility.Collapsed;
                fourthChoiceInput.Text = "Enter the choice here...";
            }
            else if (thirdButton.Visibility == Visibility.Visible)
            {
                thirdButton.Visibility = Visibility.Collapsed;
                thirdChoiceInput.Text = "Enter the choice here...";
                minusIconBackground.Visibility = Visibility.Collapsed;
            }
        }

        private void newQuestionBox_gotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox holdTextBox = (TextBox)sender;
            if (holdTextBox.Text == "Enter the question here...")
            {
                holdTextBox.Text = "";
                holdTextBox.Foreground = (Brush)Application.Current.MainWindow.FindResource("TextDarkColor");
            }
            else if (holdTextBox.Text == "Enter the choice here...")
            {
                holdTextBox.Text = " ";
                holdTextBox.Foreground = (Brush)Application.Current.MainWindow.FindResource("TextDarkColor");
            }
        }

        private void newQuestionBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox holdTextBox = (TextBox)sender;
            if (holdTextBox.Text == "")
            {

                holdTextBox.Text = "Enter the question here...";
                holdTextBox.Foreground = (Brush)Application.Current.MainWindow.FindResource("CloseButtonRed"); 
            }
            else if(holdTextBox.Text == " ")
            {
                holdTextBox.Text = "Enter the choice here...";
                holdTextBox.Foreground = (Brush)Application.Current.MainWindow.FindResource("CloseButtonRed"); ;
            }
        }
    }
}
