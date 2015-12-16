using Windows.UI.Xaml.Navigation;
using AppStudio.Common;
using AppStudio.DataProviders.LocalStorage;
using GalwayTourismGuide;
using GalwayTourismGuide.Sections;
using GalwayTourismGuide.ViewModels;

namespace GalwayTourismGuide.Views
{
    public sealed partial class HistoryListPage : PageBase
    {
        public ListViewModel<LocalStorageDataConfig, History1Schema> ViewModel { get; set; }

        public HistoryListPage()
        {
            this.ViewModel = new ListViewModel<LocalStorageDataConfig, History1Schema>(new HistoryConfig());
            this.InitializeComponent();
        }

        protected async override void LoadState(object navParameter)
        {
            await this.ViewModel.LoadDataAsync();
        }

    }
}
