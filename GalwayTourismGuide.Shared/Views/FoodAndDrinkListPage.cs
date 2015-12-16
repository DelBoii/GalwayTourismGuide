using Windows.UI.Xaml.Navigation;
using AppStudio.Common;
using AppStudio.DataProviders.DynamicStorage;
using GalwayTourismGuide;
using GalwayTourismGuide.Sections;
using GalwayTourismGuide.ViewModels;

namespace GalwayTourismGuide.Views
{
    public sealed partial class FoodAndDrinkListPage : PageBase
    {
        public ListViewModel<DynamicStorageDataConfig, FoodAndDrink1Schema> ViewModel { get; set; }

        public FoodAndDrinkListPage()
        {
            this.ViewModel = new ListViewModel<DynamicStorageDataConfig, FoodAndDrink1Schema>(new FoodAndDrinkConfig());
            this.InitializeComponent();
        }

        protected async override void LoadState(object navParameter)
        {
            await this.ViewModel.LoadDataAsync();
        }

    }
}
