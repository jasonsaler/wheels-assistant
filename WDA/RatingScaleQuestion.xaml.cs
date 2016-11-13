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
    /// Interaction logic for RatingScaleQuestion.xaml
    /// </summary>

    [Serializable]
    public partial class RatingScaleQuestion : UserControl, Question<RatingScaleQuestion>
    {
        public Boolean isForQuestionaire = false;
        public Boolean isDeleted = false;
        public Boolean hasNaOption = false;
        private String questionText = "Is HyeMi your best friend?";
        private String userComment = "Yes! Of course :D";
        private double questionRating = 10;
        private int questionLocationNumber = 1;
        private String questionType = "ratingScaleQuestion";

        public bool Equals(RatingScaleQuestion ratingScaleQuestion)
        {
            if (this.questionType == ratingScaleQuestion.questionType)
            {
                return true;
            }
            else
                return false;
        }


        public RatingScaleQuestion()
        {
            InitializeComponent();
            newQuestion.Width = 800;
            bBox.Width = (RatingSlider.Width / 4);
            dBox.Width = (RatingSlider.Width / 4);
        }

        public RatingScaleQuestion(Boolean forQuestionaire, int questionNumber, String questionText)
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
            if(questionText != null)
                Question.Text = questionText;
            questionNumber.Text = questionLocationNumber.ToString();
        }

        private void initializeQuestionaireType()
        {
            if(isForQuestionaire)
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

        public void resize()
        {
            bBox.Width = (RatingSlider.Width / 4);
            dBox.Width = (RatingSlider.Width / 4);
            //newQuestion.Width = userCommentBox.Width;
        }

        private void newQuestionBox_gotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (newQuestion.Text == "Enter the question here...")
            {
                newQuestion.Text = "";
                newQuestion.Foreground = (Brush)Application.Current.MainWindow.FindResource("TextDarkColor"); 
            }
        }

        private void newQuestionBox_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (newQuestion.Text == "")
            {
                newQuestion.Text = "Enter the question here...";
                newQuestion.Foreground = (Brush)Application.Current.MainWindow.FindResource("CloseButtonRed"); ;
            }
        }
    }
}
