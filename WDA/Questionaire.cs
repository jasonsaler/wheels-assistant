using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Office.Interop;

namespace WheelsDataAssistant
{
    [Serializable]
    public class Questionaire
    {
        private String questionaireName;
        private String description;
        private String instructions { get; set; }
        private int questionaireId;
        private int numberOfQuestions = 0;
        public QuestionStencil[] questionList;

        private Microsoft.Office.Interop.Excel.Workbook _workbook;
        private Dictionary<string, string> _userData;
        private List<QuestionResponse> _questionResponses;
        private const int VERT_OFFSET = 5;
        public string Type { get; set; }


        // A collection of the user's data.
        public Dictionary<string, string> UserData
        {
            // If the user data hasn't been initialized, initialize it.
            get
            {
                if (_userData == null)
                {
                    _userData = new Dictionary<string, string>();
                }

                return _userData;
            }
            set
            {
                _userData = value;
            }
        }

        // When the user saves progress, the same questions will be re-added to the same dictionary and list
        // Just with the new responses. This will cause problems, so reset the dictionary and list first.
        public void clearDictionaryForNewData()
        {
            _userData = new Dictionary<string, string>();
            _questionResponses = new List<QuestionResponse>();
        }

        internal String getInstructions()
        {
            return instructions;
        }

        public String getTitle()
        {
            return questionaireName;
        }

        public String getDescription()
        {
            return description;
        }

        // A list of the questions associated with the questionnaire. 
        public List<QuestionResponse> QuestionResponses
        {
            // If the questions variable isn't initialized, initialize it.
            get
            {
                if (_questionResponses == null)
                {
                    _questionResponses = new List<QuestionResponse>();
                }

                return _questionResponses;
            }
            set
            {
                _questionResponses = value;
            }
        }

        /// <summary>
        /// This constructor creates a new questionnaire with a name
        /// and a number of questions which willbe added later. 
        /// </summary>
        public Questionaire(String questionaireName, int totalQuestions, String questionaireType, String questionaireInstruction )
        {
            this.questionaireName = questionaireName;
            this.numberOfQuestions = totalQuestions;
            this.instructions = questionaireInstruction;
            this.Type = questionaireType;
            questionList = new QuestionStencil[numberOfQuestions+1];
            initializeArray();
        }

        /// <summary>
        /// This constructor creates a questionnaire from a type, data, and questions. 
        /// </summary>
        /// <param name="type">The questionnaire type.</param>
        /// <param name="userData">A dictionary containing the user's data.</param>
        /// <param name="questions">A list of questions.</param>
        public Questionaire(string type, Dictionary<string, string> userData, List<QuestionResponse> questions)
        {
            Type = type;
            UserData = userData;
            QuestionResponses = questions;
        }

        public Questionaire():this(null, null, null)
        {
        }

        /// <summary>
        /// This constructor is used to create a questionnaire from an existing Excel file. 
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public Questionaire(string path)
        {
            ParseExcelFile(path);
        }

        private void initializeArray()
        {
            for(int i=0; i==numberOfQuestions; i++)
            {
                questionList[i] = new QuestionStencil();
            }
        }

        public String getQuestionaireName()
        {
            return questionaireName;
        }

        public int getNumberOfQuestions()
        {
            return numberOfQuestions;
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
            {
                QuestionStencil mCQuestion= new QuestionStencil(question.getQuestionType(), question.getQuestionText(), questionNumber, question.hasNaOption, question.hasCommentOption);

                mCQuestion.setMCOption(0, question.firstChoiceInput.Text);
                mCQuestion.setMCOption(1, question.secondChoiceInput.Text);
                mCQuestion.setMCOption(2, question.thirdChoiceInput.Text);
                mCQuestion.setMCOption(3, question.fourthChoiceInput.Text);
                mCQuestion.setMCOption(4, question.fifthChoiceInput.Text);
                mCQuestion.setMCOption(5, question.sixthChoiceInput.Text);

                questionList[questionNumber] = mCQuestion;
            }    
            else
            {
                return false;
            }
            return true;
        }

        public Boolean addQuestion(int questionNumber, QuestionStencil question)
        {
            if (questionList[questionNumber] == null)
                questionList[questionNumber] = question;
            else if (questionList[questionNumber].GetType().Equals("EmptyType"))
                questionList[questionNumber] = question;
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



        /// <summary>
        /// Create, save, and close an excel workbook from the questionnaire.
        /// </summary>
        /// <param name="destPath">The path to the desired destination folder.</param>
        /// <param name="fileName">The name to save the file as.</param>
        public bool SaveAndCloseWorkbook(string destPath, string fileName)
        {
            bool success;

            // Create a new, empty workbook
            _workbook = ExcelApp.App.Workbooks.Add();

            // Set and name our workSheet. 
            Microsoft.Office.Interop.Excel.Worksheet workSheet = ExcelApp.App.ActiveSheet;
            workSheet.Name = "Individual Report";

            try
            {
                // Add the user's data at the top of the excel file
                int row;
                int col;
                KeyValuePair<string, string> pair;
                for (col = 1; col <= UserData.Count; col++)
                {
                    row = 1;
                    pair = UserData.ElementAt(col - 1);
                    workSheet.Cells[row++, col] = pair.Key;
                    workSheet.Cells[row, col] = pair.Value;
                }

                // This creates a section header
                workSheet.Cells[VERT_OFFSET - 1, 1] = "Question #";
                workSheet.Cells[VERT_OFFSET - 1, 2] = "Response";
                workSheet.Cells[VERT_OFFSET - 1, 3] = "Comment";

                // Add the user's responses and comments for each question
                int count = 0;
                for (row = VERT_OFFSET; row < VERT_OFFSET + QuestionResponses.Count; row++)
                {
                    col = 1;
                    var question = QuestionResponses.ElementAt(count++);
                    workSheet.Cells[row, col++] = string.Format("{0}", count);
                    workSheet.Cells[row, col++] = question.Response;

                    if (question.Comment != string.Empty)
                    {
                        workSheet.Cells[row, col] = question.Comment;
                    }
                    else
                    {
                        workSheet.Cells[row, col] = "No comment.";
                    }
                }

                // Create a chart oject
                var charts = workSheet.ChartObjects() as Microsoft.Office.Interop.Excel.ChartObjects;
                var chartObject = charts.Add(300, 50, 200 + 50 * QuestionResponses.Count, 300) as Microsoft.Office.Interop.Excel.ChartObject;
                var chart = chartObject.Chart;

                // Set the range of the data to plot.
                var range = workSheet.get_Range(string.Format("B{0}", VERT_OFFSET), string.Format("B{0}", VERT_OFFSET + QuestionResponses.Count - 1));
                chart.SetSourceData(range);

                // Set the chart properties
                chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered;
                chart.ChartWizard(
                    Source: range,
                    CategoryTitle: "Question Number"
                    );
                chart.Axes(Microsoft.Office.Interop.Excel.XlAxisType.xlValue).MaximumScale = 10;
                chart.Axes(Microsoft.Office.Interop.Excel.XlAxisType.xlValue).MinimumScale = 0;

                // TODO: Fix autoformat
                // workSheet.Columns["A:F"].AutoFit();
                // workSheet.Range["A1", "B3"].AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2);

                // Save file with the proper type included in the name
                _workbook.SaveAs(string.Format("{0}\\{1}_{2}", destPath, fileName, Type));

                success = true;
            }
            catch (Exception ex)
            {
                success = false;
            }
            finally
            {
                // Close the workbook
                _workbook.Close(SaveChanges: false);
            }

            return success;
        }

        /// <summary>
        /// Parse the data out of an Excel file into a questionnaire object.
        /// </summary>
        /// <param name="path">The path to the desired Excel file.</param>
        /// <returns>A Questionnaire object with the data contained in the Excel file.</returns>
        private Questionaire ParseExcelFile(string path)
        {
            // Open the specified file
            _workbook = ExcelApp.App.Workbooks.Open(path);
            Microsoft.Office.Interop.Excel.Worksheet workSheet = ExcelApp.App.ActiveSheet;

            // Parse out the user data
            int row = 1;
            int col = 1;
            string key;
            while ((workSheet.Cells[row, col] as Microsoft.Office.Interop.Excel.Range).Value != null)
            {
                key = (workSheet.Cells[row++, col] as Microsoft.Office.Interop.Excel.Range).Value;
                var val = (workSheet.Cells[row, col++] as Microsoft.Office.Interop.Excel.Range).Value;
                row = 1;
                UserData.Add(key.ToString(), val.ToString());
            }

            // Parse out the questions
            row = VERT_OFFSET;
            col = 2;
            while ((workSheet.Cells[row, col] as Microsoft.Office.Interop.Excel.Range).Value != null)
            {
                double response = (double)(workSheet.Cells[row, col++] as Microsoft.Office.Interop.Excel.Range).Value;
                string comment = (string)(workSheet.Cells[row++, col] as Microsoft.Office.Interop.Excel.Range).Value;
                col = 2;
                QuestionResponses.Add(new QuestionResponse(response, comment));
            }

            // Get file type from file name using regex
            Regex regex = new Regex(@"(?<=_)(.*?)(?=\.)");
            Type = regex.Match(path).Value;

            // Close the workbook
            _workbook.Close(SaveChanges: false);

            // Return the questionnaire object
            return this;
        }

        /// <summary>
        /// This destructor ensures workbooks are closed and COM objects are properly disposed of.
        /// </summary>
        ~Questionaire()
        {
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

            if (_workbook != null)
            {
                try
                {
                    _workbook.Close(SaveChanges: false);
                }
                catch (Exception)
                {
                }
                finally
                {
                    Marshal.ReleaseComObject(_workbook);
                }
            }
        }
    }
}
