using Windows.UI.Xaml.Navigation;
using AppStudio.Common;
using AppStudio.DataProviders.LocalStorage;
using GalwayTourismGuide;
using GalwayTourismGuide.Sections;
using GalwayTourismGuide.ViewModels;

namespace GalwayTourismGuide.Views
{
    public sealed partial class AccommodationListPage : PageBase
    {
        public ListViewModel<LocalStorageDataConfig, Accommodation1Schema> ViewModel { get; set; }

        public AccommodationListPage()
        {
            this.ViewModel = new ListViewModel<LocalStorageDataConfig, Accommodation1Schema>(new AccommodationConfig());
            this.InitializeComponent();
        }

        protected async override void LoadState(object navParameter)
        {
            await this.ViewModel.LoadDataAsync();
        }

    }
}
