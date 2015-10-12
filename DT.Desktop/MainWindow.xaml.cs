using System.Diagnostics;
using System.Windows;
using DT.Data;

namespace DT.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnReadButtonClicked(object sender, RoutedEventArgs e)
        {
            using (var dbContext = new DTDbContext())
            {
                foreach (var topic in dbContext.Topics)
                {
                    Debug.WriteLine(topic.Name);

                    if (topic.Questions == null)
                        continue;

                    foreach (var question in topic.Questions)
                    {
                        Debug.WriteLine(question.Text);
                    }
                }

                foreach (var question in dbContext.Questions)
                {
                    Debug.WriteLine(question.Text);
                    Debug.WriteLine(question.Topic.Name);
                }
            }
        }
    }
}
