using System;
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
using System.Windows.Shapes;

namespace WheelsDataAssistant
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            Questionaire newQuestionaire = new Questionaire("Thissss Questionaire", 45);

            favoritesItemsListView.Items.Add(new Questionaire("LLD Questionaire", 75));
            favoritesItemsListView.Items.Add(newQuestionaire.getQuestionaireName());
        }

        private void button1_Click(object sender, RoutedEventArgs e)

        {

            //ListView1.Items.Add(textBox1.Text);

        }



    }
}
