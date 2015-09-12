using System.Windows;
using DT.Data;
using DT.Data.Repositories;
using DT.Desktop.ViewModels;

namespace DT.Desktop.Views
{
    /// <summary>
    /// Interaction logic for DTView.xaml
    /// </summary>
    public partial class DTView : Window
    {
        public DTView()
        {
            InitializeComponent();

            var rf = new RepositoryFactories();
            var rp = new RepositoryProvider(rf);
            var uow = new DTUoW(rp);
            DataContext = new DTViewModel(uow);
        }
    }
}
