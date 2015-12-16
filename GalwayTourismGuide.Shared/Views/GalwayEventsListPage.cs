using Windows.UI.Xaml.Navigation;
using AppStudio.Common;
using AppStudio.DataProviders.LocalStorage;
using GalwayTourismGuide;
using GalwayTourismGuide.Sections;
using GalwayTourismGuide.ViewModels;

namespace GalwayTourismGuide.Views
{
    public sealed partial class GalwayEventsListPage : PageBase
    {
        public ListViewModel<LocalStorageDataConfig, GalwayEvents1Schema> ViewModel { get; set; }

        public GalwayEventsListPage()
        {
            this.ViewModel = new ListViewModel<LocalStorageDataConfig, GalwayEvents1Schema>(new GalwayEventsConfig());
            this.InitializeComponent();
        }

        protected async override void LoadState(object navParameter)
        {
            await this.ViewModel.LoadDataAsync();
        }

    }
}
