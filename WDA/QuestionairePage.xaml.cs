using System;
using System.IO;
using Microsoft.Win32;
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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace WheelsDataAssistant
{
    /// <summary>
    /// Interaction logic for QuestionairePage.xaml
    /// </summary>
    public partial class QuestionairePage : System.Windows.Controls.Page
    {
        string s;
        static int ClicksCount = 0;
        static int count = 2;
        string f = "records.xls";
        public QuestionairePage()
        {
            InitializeComponent();
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            HelpPage helpPage = new HelpPage();
            this.NavigationService.Navigate(helpPage);
        }

        private void SaveNewButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
        }

        private void FinishButton_Click(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
            this.NavigationService.Navigate(homePage);
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to close this form? Changes will not be saved?", "Cancel", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                HomePage homePage = new HomePage();
                this.NavigationService.Navigate(homePage);
            }
        }

      
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string t = txtEditor.Text;
            saveFileDialog.FileName = "records.xls";
            ClicksCount++;
            if (ClicksCount == 1)
            {
                saveFileDialog.CreatePrompt = true;
                saveFileDialog.OverwritePrompt = true;
                saveFileDialog.DefaultExt = "xls";
                saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
                if (saveFileDialog.ShowDialog() == true)
                {
                    File.WriteAllText(saveFileDialog.FileName, txtEditor.Text);
                    s = saveFileDialog.FileName;

                }
            }
            else
            {
                Environment.CurrentDirectory = Path.GetDirectoryName(s);
                File.SetAttributes(s, FileAttributes.Normal);
                saveFileDialog.Filter = "Execl files (*.xls)|*.xls";
                var excelApp = new Excel.Application();
                File.WriteAllText(s, txtEditor.Text);
                excelApp.Workbooks.Open(s, 3, false, 5, Type.Missing, Type.Missing, true);
                Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
                workSheet.Cells[count, "A"] = t;
                count++;
                excelApp.DisplayAlerts = false;
                workSheet.SaveAs(f, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, true, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                excelApp.Workbooks.Close();
                excelApp.Quit();
                ToastNotification tNotification = new ToastNotification("Saved");
                tNotification.Visibility = Visibility.Visible;
                openSpaceGrid.Children.Add(tNotification);




            }
        }
    }
}
