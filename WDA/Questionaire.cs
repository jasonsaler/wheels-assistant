using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelsDataAssistant
{
    [Serializable]
    public class Questionaire
    {
        private String questionaireName;
        private String description;
        private String instructions;
        private int questionaireId;
        private int numberOfQuestions = 0;
        QuestionStencil[] questionList;

        public Questionaire(String questionaireName, int totalQuestions )
        {
            this.questionaireName = questionaireName;
            this.numberOfQuestions = totalQuestions;
            questionList = new QuestionStencil[numberOfQuestions+1];
        }

        public Questionaire(String questionaireName)
        {
            this.questionaireName = questionaireName;
        }

        public String getQuestionaireName()
        {
            return questionaireName;
        }

        public int getQuestionaireId()
        {
            return questionaireId;
        }

        public Boolean addNewRatingScaleQuestion(int questionNumber, RatingScaleQuestion question)
        {
            if (questionList[questionNumber] == null)
                questionList[questionNumber] = new QuestionStencil(question.getQuestionType(), question.getQuestionText(), questionNumber, question.hasNaOption);
            else
                return false;

            return true;
        }

        public Boolean addNewBlankResponseQuestion(int questionNumber, BlankResponseQuestion question)
        {
            if (questionList[questionNumber] == null)
                questionList[questionNumber] = new QuestionStencil(question.getQuestionType(), question.getQuestionText(), questionNumber, question.hasNaOption);
            else
                return false;

            return true;
        }

        public Boolean addNewMultipleChoiceQuestion(int questionNumber, QuestionControls.MultipleChoiceQuestion question)
        {
            if (questionList[questionNumber] == null)
                questionList[questionNumber] = new QuestionStencil(question.getQuestionType(), question.getQuestionText(), questionNumber, question.hasNaOption);
            else
                return false;

            return true;
        }

        public void setDescription(String description)
        {
            this.description = description;
        }

        public void setInstructions(String instruction)
        {
            this.instructions = instruction;
        }
    }
}
