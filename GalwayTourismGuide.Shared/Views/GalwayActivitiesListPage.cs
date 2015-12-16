using Windows.UI.Xaml.Navigation;
using AppStudio.Common;
using AppStudio.DataProviders.Bing;
using GalwayTourismGuide;
using GalwayTourismGuide.Sections;
using GalwayTourismGuide.ViewModels;

namespace GalwayTourismGuide.Views
{
    public sealed partial class GalwayActivitiesListPage : PageBase
    {
        public ListViewModel<BingDataConfig, BingSchema> ViewModel { get; set; }

        public GalwayActivitiesListPage()
        {
            this.ViewModel = new ListViewModel<BingDataConfig, BingSchema>(new GalwayActivitiesConfig());
            this.InitializeComponent();
        }

        protected async override void LoadState(object navParameter)
        {
            await this.ViewModel.LoadDataAsync();
        }

    }
}
