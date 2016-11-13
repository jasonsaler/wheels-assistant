using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelsDataAssistant
{
    [Serializable]
    class QuestionStencil
    {

        String m_questionType;
        String m_questionText;
        int m_questionNumber = 0;
        Boolean m_hasNaOption = false;

        public QuestionStencil(String questionType, String questionText, int questionNumber, Boolean hasNaOption)
        {
            this.m_questionType = questionType;
            this.m_questionText = questionText;
            this.m_questionNumber = questionNumber;
            this.m_hasNaOption = hasNaOption;
        }
    }
}
