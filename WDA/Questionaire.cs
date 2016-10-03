using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelsDataAssistant
{
    class Questionaire
    {
        private String questionaireName;
        private int questionaireId;


        public Questionaire(String questionaireName, int questionaireId )
        {
            this.questionaireName = questionaireName;
            this.questionaireId = questionaireId;
        }

        public String getQuestionaireName()
        {
            return questionaireName;
        }

        public int getQuestionaireId()
        {
            return questionaireId;
        }
    }
}
