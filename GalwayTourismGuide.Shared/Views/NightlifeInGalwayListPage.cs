using Windows.UI.Xaml.Navigation;
using AppStudio.Common;
using AppStudio.DataProviders.LocalStorage;
using GalwayTourismGuide;
using GalwayTourismGuide.Sections;
using GalwayTourismGuide.ViewModels;

namespace GalwayTourismGuide.Views
{
    public sealed partial class NightlifeInGalwayListPage : PageBase
    {
        public ListViewModel<LocalStorageDataConfig, NightlifeInGalway1Schema> ViewModel { get; set; }

        public NightlifeInGalwayListPage()
        {
            this.ViewModel = new ListViewModel<LocalStorageDataConfig, NightlifeInGalway1Schema>(new NightlifeInGalwayConfig());
            this.InitializeComponent();
        }

        protected async override void LoadState(object navParameter)
        {
            await this.ViewModel.LoadDataAsync();
        }

    }
}
