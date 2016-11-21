using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelsDataAssistant
{
    [Serializable]
    public class QuestionStencil
    {

        String m_questionType = "EmptyType";
        String m_questionText;
        int m_questionNumber = 0;
        public Boolean m_hasNaOption = false;
        public Boolean hasCommentOption = false;
        static int s_totalPossibleMCOptions = 6;
        String[] multipleChoices = new String[s_totalPossibleMCOptions];

        public QuestionStencil(String questionType, String questionText, int questionNumber, Boolean hasNaOption)
        {
            this.m_questionType = questionType;
            this.m_questionText = questionText;
            this.m_questionNumber = questionNumber;
            this.m_hasNaOption = hasNaOption;
        }

        public QuestionStencil(String questionType, String questionText, int questionNumber, Boolean hasNaOption, Boolean hasCommentOption)
        {
            this.m_questionType = questionType;
            this.m_questionText = questionText;
            this.m_questionNumber = questionNumber;
            this.m_hasNaOption = hasNaOption;
            this.hasCommentOption = hasCommentOption;
        }

        public QuestionStencil()
        {

        }

        public int getMaxOptionCount()
        {
            return s_totalPossibleMCOptions;
        }

        public String getQuestionType()
        {
            return m_questionType;
        }

        public int getQuestionNumber()
        {
            return m_questionNumber;
        }

        public String getQuestionText()
        {
            return m_questionText;
        }

        public String getMCOption(int place)
        {
            if (place <= s_totalPossibleMCOptions)
            {
                if(multipleChoices[place] != null || multipleChoices[place] != "")
                {
                    return multipleChoices[place];
                }
            }
            return "Enter the choice here...";
        }

        public void setMCOption(int place, String option)
        {
            if (place <= s_totalPossibleMCOptions)
            {
                multipleChoices[place] = option;
            }
        }
    }
}
