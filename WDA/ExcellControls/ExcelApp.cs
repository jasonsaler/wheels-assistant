using Excel = Microsoft.Office.Interop.Excel;

namespace WheelsDataAssistant
{
    /// <summary>
    /// The ExcelApp class is a singleton class. 
    /// Only one instance of the excel application needs to be open during the life of our application.
    /// </summary>
    public sealed class ExcelApp
    {
        private static readonly ExcelApp instance = new ExcelApp();
        
        public static Excel.Application App = new Excel.Application();

        static ExcelApp()
        {
        }

        private ExcelApp()
        {
        }

        public static ExcelApp Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
