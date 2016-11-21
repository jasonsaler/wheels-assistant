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
        public bool hasCommentOption = false;
        private String questionText = "Are Fieros awesome?";
        private String userComment = "Yes! Of course :D";
        private String chosenAnswer = "Duh";
        private int questionLocationNumber = 1;
        private String questionType = "multipleChoiceQuestion";
        RadioButton selectedButton;
        
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

        public MultipleChoiceQuestion(Boolean forQuestionaire, int questionNumber, String questionText, Boolean allowComments)
        {
            this.isForQuestionaire = forQuestionaire;
            this.questionLocationNumber = questionNumber;
            this.questionText = questionText;
            this.hasCommentOption = allowComments;
            InitializeComponent();
            newQuestion.Width = 800;
            initializeData();
            initializeQuestionaireType();
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
                questionNumber.Text = questionLocationNumber.ToString() + ".";
                questionNumber.BorderThickness = new Thickness(0);
                Question.Text = questionText;
                Question.Visibility = Visibility.Visible;
                userCommentBox.Background = new SolidColorBrush(Colors.White);
                userCommentBox.Foreground = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorLight");
                userCommentBox.Text = "Enter any necessary comments here...";
                userCommentBox.IsReadOnly = false;
                plusIcon.Visibility = Visibility.Collapsed;
                minusIcon.Visibility = Visibility.Collapsed;
                commentCheckBox.Visibility = Visibility.Collapsed;

                if (hasCommentOption)
                    userCommentBox.Visibility = Visibility.Visible;
                else
                    buttonsGrid.Margin = new Thickness(0, 35, 0, 25);


                if (!hasNaOption)
                    naCheckbox.Visibility = Visibility.Collapsed;

                changeOptionsLook();
            }
        }

        private void changeOptionsLook()
        {
            firstChoiceInput.IsReadOnly = true;
            firstChoiceInput.Background = new SolidColorBrush(Colors.Transparent);
            firstChoiceInput.Foreground = new SolidColorBrush(Colors.Black);
            firstChoiceInput.BorderThickness = new Thickness(0);
            secondChoiceInput.IsReadOnly = true;
            secondChoiceInput.Background = new SolidColorBrush(Colors.Transparent);
            secondChoiceInput.Foreground = new SolidColorBrush(Colors.Black);
            secondChoiceInput.BorderThickness = new Thickness(0);
            thirdChoiceInput.IsReadOnly = true;
            thirdChoiceInput.Background = new SolidColorBrush(Colors.Transparent);
            thirdChoiceInput.Foreground = new SolidColorBrush(Colors.Black);
            thirdChoiceInput.BorderThickness = new Thickness(0);
            fourthChoiceInput.IsReadOnly = true;
            fourthChoiceInput.Background = new SolidColorBrush(Colors.Transparent);
            fourthChoiceInput.Foreground = new SolidColorBrush(Colors.Black);
            fourthChoiceInput.BorderThickness = new Thickness(0);
            fifthChoiceInput.IsReadOnly = true;
            fifthChoiceInput.Background = new SolidColorBrush(Colors.Transparent);
            fifthChoiceInput.Foreground = new SolidColorBrush(Colors.Black);
            fifthChoiceInput.BorderThickness = new Thickness(0);
            sixthChoiceInput.IsReadOnly = true;
            sixthChoiceInput.Background = new SolidColorBrush(Colors.Transparent);
            sixthChoiceInput.Foreground = (Brush)Application.Current.MainWindow.FindResource("TextDarkColor");
            sixthChoiceInput.BorderThickness = new Thickness(0);  
        }

        public void choiceVisibilityShowHide()
        {
            if (firstChoiceInput.Text == "Enter the choice here...")
                firstButton.Visibility = Visibility.Collapsed;
            else
                firstButton.Visibility = Visibility.Visible;

            if (secondChoiceInput.Text == "Enter the choice here...")
                secondButton.Visibility = Visibility.Collapsed;
            else
                secondButton.Visibility = Visibility.Visible;

            if (thirdChoiceInput.Text == "Enter the choice here...")
                thirdButton.Visibility = Visibility.Collapsed;
            else
                thirdButton.Visibility = Visibility.Visible;

            if (fourthChoiceInput.Text == "Enter the choice here...")
                fourthButton.Visibility = Visibility.Collapsed;
            else
                fourthButton.Visibility = Visibility.Visible;

            if (fifthChoiceInput.Text == "Enter the choice here...")
                fifthButton.Visibility = Visibility.Collapsed;
            else
                fifthButton.Visibility = Visibility.Visible;

            if (sixthChoiceInput.Text == "Enter the choice here...")
                sixthButton.Visibility = Visibility.Collapsed;
            else
                sixthButton.Visibility = Visibility.Visible;
        }

        public String getQuestionType()
        {
            return questionType;
        }

        public String getChosenAnswer()
        {
            return chosenAnswer;
        }

        public String getQuestionText()
        {
            //questionText = newQuestion.Text;
            return questionText;
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

        private void CommentsOption_Unchecked(object sender, RoutedEventArgs e)
        {
            userCommentBox.Visibility = Visibility.Collapsed;
            commentTitle.Visibility = Visibility.Collapsed;
            commentCheckBox.Content = "Add comment box";
            hasCommentOption = false;
        }

        private void CommentsOption_Checked(object sender, RoutedEventArgs e)
        {
            userCommentBox.Visibility = Visibility.Visible;
            commentTitle.Visibility = Visibility.Visible;
            commentCheckBox.Content = "";
            hasCommentOption = true;
        }

        private void CommentBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (userCommentBox.Text == "Enter any necessary comments here...")
            {
                userCommentBox.Text = "";
                userCommentBox.Foreground = (Brush)Application.Current.MainWindow.FindResource("TextDarkColor");
            }
        }

        private void CommentBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (userCommentBox.Text == "")
            {
                userCommentBox.Text = "Enter any necessary comments here...";
                userCommentBox.Foreground = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorLight");
            }
        }

        private void naOption_Checked(object sender, RoutedEventArgs e)
        {
            if (!isForQuestionaire)
            {
                hasNaOption = true;
            }
            else
            {
                userCommentBox.Background = new SolidColorBrush(Colors.LightGray);
                userCommentBox.Foreground = new SolidColorBrush(Colors.Black);
                userCommentBox.IsReadOnly = true;
                userCommentBox.Text = "Not Applicable";
                chosenAnswer = "Not Applicable";
                uncheckButton();
                firstButton.IsEnabled = false;
                secondButton.IsEnabled = false;
                thirdButton.IsEnabled = false;
                fourthButton.IsEnabled = false;
                fifthButton.IsEnabled = false;
                sixthButton.IsEnabled = false;
            }
        }

        public void setNAOption(Boolean option)
        {
            hasNaOption = option;
            if (hasNaOption == false)
            {
                naCheckbox.Visibility = Visibility.Collapsed;
            }
            else
            {
                naCheckbox.Visibility = Visibility.Visible;
            }
        }

        private void NAOption_Unchecked(object sender, RoutedEventArgs e)
        {
            if (!isForQuestionaire)
            {
                hasNaOption = false;
            }
            else
            {
                userCommentBox.Background = new SolidColorBrush(Colors.White);
                userCommentBox.Foreground = (Brush)Application.Current.MainWindow.FindResource("AppPrimaryBackgroundColorLight");
                userCommentBox.IsReadOnly = false;
                userCommentBox.Text = "Enter any necessary comments here...";

                firstButton.IsEnabled = true;
                secondButton.IsEnabled = true;
                thirdButton.IsEnabled = true;
                fourthButton.IsEnabled = true;
                fifthButton.IsEnabled = true;
                sixthButton.IsEnabled = true;
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (selectedButton == null)
                selectedButton = (RadioButton)sender;
            else
                uncheckButton();

            if ((RadioButton)sender == firstChoice)
            {
                firstChoice.IsChecked = true;
                selectedButton = firstChoice;
                chosenAnswer = firstChoiceInput.Text;
            }
            else if ((RadioButton)sender == secondChoice)
            {
                secondChoice.IsChecked = true;
                selectedButton = secondChoice;
                chosenAnswer = secondChoiceInput.Text;
            }
            else if ((RadioButton)sender == thirdChoice)
            {
                thirdChoice.IsChecked = true;
                selectedButton = thirdChoice;
                chosenAnswer = thirdChoiceInput.Text;
            }
            else if ((RadioButton)sender == fourthChoice)
            {
                fourthChoice.IsChecked = true;
                selectedButton = fourthChoice;
                chosenAnswer = fourthChoiceInput.Text;
            }
            else if ((RadioButton)sender == fifthdChoice)
            {
                fifthdChoice.IsChecked = true;
                selectedButton = fifthdChoice;
                chosenAnswer = fifthChoiceInput.Text;
            }
            else if ((RadioButton)sender == sixthChoice)
            {
                sixthChoice.IsChecked = true;
                selectedButton = sixthChoice;
                chosenAnswer = sixthChoiceInput.Text;
            }
        }

        private void uncheckButton()
        {
            
            if(selectedButton != null)
            {
                if (selectedButton == firstChoice)
                    firstChoice.IsChecked = false;
                else if (selectedButton == secondChoice)
                    secondChoice.IsChecked = false;
                else if (selectedButton == thirdChoice)
                    thirdChoice.IsChecked = false;
                else if (selectedButton == fourthChoice)
                    fourthChoice.IsChecked = false;
                else if (selectedButton == fifthdChoice)
                    fifthdChoice.IsChecked = false;
                else if (selectedButton == sixthChoice)
                    sixthChoice.IsChecked = false;
            }
        }

        QuestionResponse getResponse()
        {
            return new QuestionResponse(chosenAnswer + "; " + userCommentBox.Text);
        }
    }
}
