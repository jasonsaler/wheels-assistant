using System;
using System.Collections.Generic;
using System.Linq;
using Marshal = System.Runtime.InteropServices.Marshal;
using Excel = Microsoft.Office.Interop.Excel;

namespace WheelsDataAssistant
{
    /// <summary>
    /// A summary report is a collection of the data from individual reports.
    /// </summary>
    class SummaryReport
    {
        /// <summary>
        /// The Excel workbook being used.
        /// </summary>
        private Excel.Workbook _workbook;

        /// <summary>
        /// The "Summary" worksheet.
        /// </summary>
        private Excel.Worksheet _summaryWorksheet;

        /// <summary>
        /// The "Comment" worksheet.
        /// </summary>
        private Excel.Worksheet _commentWorksheet;

        /// <summary>
        /// The path to the source/destination folder.
        /// </summary>
        private string _folderPath;

        /// <summary>
        /// The questionnaire type.
        /// </summary>
        private string _type;
        
        /// <summary>
        /// Is this the first time writing to the Excel file?
        /// </summary>
        private bool _firstWrite;

        /// <summary>
        /// Does a summary file already exist?
        /// </summary>
        private bool _summaryExists;

        /// <summary>
        /// Should we overwrite an existing summary report?
        /// </summary>
        private bool _overwrite;

        /// <summary>
        /// Create a new summary report or open an existing one.
        /// </summary>
        /// <param name="destFolder">The desired folder.</param>
        /// <param name="type">The questionnaire type.</param>
        /// <param name="overwriteExistingSummary">Whether or not to overwrite an existing summary report.</param>
        public SummaryReport (string destFolder, string type, bool overwriteExistingSummary)
        {
            // Set local variables. 
            _folderPath = destFolder;
            _type = type;
            _overwrite = overwriteExistingSummary;
            var workbooks = ExcelApp.App.Workbooks;

            // Format the path to the summary file.
            var filePath = string.Format("{0}\\Summary for {1}", _folderPath, _type);

            // If we're not overwriting an existing summary...
            if (!_overwrite)
            {
                // Try to open an existing summary
                try
                {
                    _workbook = workbooks.Open(filePath);
                    _summaryExists = true;
                    _firstWrite = false;
                    _summaryWorksheet = (Excel.Worksheet)_workbook.Sheets["Summary"];
                    _commentWorksheet = (Excel.Worksheet)_workbook.Sheets["Comments"];
                }

                // If we couldn't open the summary file, create a new one.
                catch (Exception)
                {
                    _summaryExists = false;
                    _firstWrite = true;

                    // Add a new workbook.
                    _workbook = workbooks.Add();

                    // Add the "Comments" worksheet.
                    _commentWorksheet = ExcelApp.App.ActiveSheet;
                    _commentWorksheet.Name = "Comments";

                    // Add the "Summary worksheet.
                    _summaryWorksheet = (Excel.Worksheet)_workbook.Worksheets.Add();
                    _summaryWorksheet.Name = "Summary";
                }
            }

            // Otherwise create a new workbook.
            else
            {
                _summaryExists = false;
                _firstWrite = true;

                // Add a new workbook.
                _workbook = workbooks.Add();

                // Add the "Comments" worksheet.
                _commentWorksheet = ExcelApp.App.ActiveSheet;
                _commentWorksheet.Name = "Comments";

                // Add the "Summary worksheet.
                _summaryWorksheet = (Excel.Worksheet)_workbook.Worksheets.Add();
                _summaryWorksheet.Name = "Summary";
            }
        }

        public void Append(Questionaire questionnaire)
        {
            int row = 1;
            int col = 1;
            int horizOffset = 0;
            int vertOffset = 0;

            // If it's the first time to write a questionnaire to the summary, 
            // we first add a header, then the data values
            if (_firstWrite)
            {
                // Add the user data
                KeyValuePair<string, string> pair;
                for (col = 1; col <= questionnaire.UserData.Count; col++)
                {
                    row = 1;
                    pair = questionnaire.UserData.ElementAt(col - 1);
                    _summaryWorksheet.Cells[row++, col] = pair.Key;
                    _summaryWorksheet.Cells[row, col] = pair.Value;
                    horizOffset++;
                }

                // Add the reponses and comments
                QuestionResponse question;
                for (col = 1; col <= questionnaire.QuestionResponses.Count; col++)
                {
                    row = 1;
                    question = questionnaire.QuestionResponses.ElementAt(col - 1);
                    _summaryWorksheet.Cells[row, col + horizOffset] = string.Format("Question {0}", col);
                    _commentWorksheet.Cells[row++, col] = string.Format("Question {0}", col);
                    _commentWorksheet.Cells[row, col] = question.Comment;
                    _summaryWorksheet.Cells[row, col + horizOffset] = question.Response;
                }

                // This is no longer the first write.
                _firstWrite = false;

                //TODO: Fix autofit
                //_summaryWorksheet.Columns["A:F"].AutoFit();
                //_commentWorksheet.Columns["A:F"].AutoFit();
            }

            // If it's not the first time to write, we just 
            // append the data to the workbook without headers.
            else
            {
                row = 1;
                col = 1;
                vertOffset = 1;

                // Find the vertical offset.
                while ((_summaryWorksheet.Cells[row++, col] as Excel.Range).Value != null)
                {
                    vertOffset++;
                }

                // Add the user data
                KeyValuePair<string, string> pair;
                for (col = 1; col <= questionnaire.UserData.Count; col++)
                {
                    row = vertOffset;
                    pair = questionnaire.UserData.ElementAt(col - 1);
                    _summaryWorksheet.Cells[row, col] = pair.Value;
                    horizOffset++;
                }

                // Add the responses and comments
                QuestionResponse question;
                for (col = 1; col <= questionnaire.QuestionResponses.Count; col++)
                {
                    row = vertOffset;
                    question = questionnaire.QuestionResponses.ElementAt(col - 1);
                    _commentWorksheet.Cells[row, col] = question.Comment;
                    _summaryWorksheet.Cells[row, col + horizOffset] = question.Response;
                }
            }
        }

        /// <summary>
        /// Save and close the Excel workbook. 
        /// </summary>
        /// <returns>True if save successful.</returns>
        public bool SaveAndCloseWorkbook()
        {
            // Try to save the summary
            try
            {
                // If we're just appending to the file, save it. 
                if (_summaryExists && !_overwrite)
                {
                    _workbook.Save();
                }
                // Otherwise, save a new summary or overwrite the old one.
                else
                {
                    _workbook.SaveAs(string.Format("{0}\\Summary for {1}", _folderPath, _type));
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            // Make sure the workbook gets closed.
            finally
            {
                _workbook.Close(SaveChanges: false);
            }
        }

        /// <summary>
        /// This destructor ensures that all com objects are properly disposed of.
        /// </summary>
        ~SummaryReport()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Marshal.FinalReleaseComObject(_summaryWorksheet);
            Marshal.FinalReleaseComObject(_commentWorksheet);

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