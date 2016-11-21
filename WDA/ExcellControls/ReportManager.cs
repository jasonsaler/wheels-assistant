using System;
using System.IO;

namespace WheelsDataAssistant
{
    /// <summary>
    /// The ReportManager class is the main entry-point for the application back-end. 
    /// It contains the two main methods for creating Excel spreadsheets.
    /// </summary>
    class ReportManager
    {
        public static void GenerateIndividualReport(Questionaire questionnaire, string destFolder, string fileName)
        {
            // Create an individual report from the questionnaire.
            if (questionnaire.SaveAndCloseWorkbook(destFolder, fileName))
            {
                // Open an existing summary report, or create a new one if none exists
                var summary = new SummaryReport(destFolder, questionnaire.Type, false);

                // Append the questionnaire to the summary report.
                summary.Append(questionnaire);

                // Save and close the summary report.
                summary.SaveAndCloseWorkbook();
            }
        }

        public static bool GenerateSummaryReport(string type, string destFolder)
        {
            try
            {
                // Create a new summary report
                var summary = new SummaryReport(destFolder, type, true);

                // Look for files in the specified directory that are the correct type.
                var files = Directory.GetFiles(destFolder, string.Format("*_{0}.xls*", type));

                // For each file that's the correct type...
                foreach (var file in files)
                {
                    // Create a new Questionnaire object from the Excel file.
                    var questionnaire = new Questionaire(file);

                    // Append the questionnaire to the summary.
                    summary.Append(questionnaire);
                }

                // Save and close the summary report.
                summary.SaveAndCloseWorkbook();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
