using Windows.UI.Xaml.Navigation;
using AppStudio.Common;
using AppStudio.DataProviders.Flickr;
using GalwayTourismGuide;
using GalwayTourismGuide.Sections;
using GalwayTourismGuide.ViewModels;

namespace GalwayTourismGuide.Views
{
    public sealed partial class PicturesListPage : PageBase
    {
        public ListViewModel<FlickrDataConfig, FlickrSchema> ViewModel { get; set; }

        public PicturesListPage()
        {
            this.ViewModel = new ListViewModel<FlickrDataConfig, FlickrSchema>(new PicturesConfig());
            this.InitializeComponent();
        }

        protected async override void LoadState(object navParameter)
        {
            await this.ViewModel.LoadDataAsync();
        }

    }
}
