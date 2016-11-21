namespace WheelsDataAssistant
{
    /// <summary>
    /// The question object holds a response and a comment. 
    /// </summary>
    public class QuestionResponse
    {
        public QuestionResponse(double response, string comment)
        {
            Response = response;
            Comment = comment;
        }

        public QuestionResponse(string comment)
        {
            Comment = comment;
        }

        /// <summary>
        /// A question's response.
        /// </summary>
        public double Response { get; set; }

        /// <summary>
        /// A question's comment.
        /// </summary>
        public string Comment { get; set; }
    }
}
