using Windows.UI.Xaml.Controls;
using GalwayTourismGuide.ViewModels;

namespace GalwayTourismGuide
{
    public sealed partial class AboutThisAppPage : Page
    {
        public AboutThisAppViewModel AboutModel { get; private set; }
        public AboutThisAppPage()
        {
            AboutModel = new AboutThisAppViewModel();
            this.InitializeComponent();
        }
    }
}

