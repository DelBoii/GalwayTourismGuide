using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppStudio.Common;
using AppStudio.Common.Actions;
using AppStudio.Common.Commands;
using AppStudio.Common.Navigation;
using AppStudio.DataProviders;
using AppStudio.DataProviders.Html;
using AppStudio.DataProviders.Flickr;
using AppStudio.DataProviders.Bing;
using AppStudio.DataProviders.Menu;
using AppStudio.DataProviders.LocalStorage;
using AppStudio.DataProviders.DynamicStorage;
using GalwayTourismGuide.Sections;


namespace GalwayTourismGuide.ViewModels
{
    public class MainViewModel : ObservableBase
    {
        public MainViewModel(int visibleItems)
        {
            PageTitle = "Galway Tourism Guide";
            Welcome = new ListViewModel<LocalStorageDataConfig, HtmlSchema>(new WelcomeConfig(), visibleItems);
            History = new ListViewModel<LocalStorageDataConfig, History1Schema>(new HistoryConfig(), visibleItems);
            GalwayEvents = new ListViewModel<LocalStorageDataConfig, GalwayEvents1Schema>(new GalwayEventsConfig(), visibleItems);
            Pictures = new ListViewModel<FlickrDataConfig, FlickrSchema>(new PicturesConfig(), visibleItems);
            FoodAndDrink = new ListViewModel<DynamicStorageDataConfig, FoodAndDrink1Schema>(new FoodAndDrinkConfig(), visibleItems);
            NightlifeInGalway = new ListViewModel<LocalStorageDataConfig, NightlifeInGalway1Schema>(new NightlifeInGalwayConfig(), visibleItems);
            GalwayActivities = new ListViewModel<BingDataConfig, BingSchema>(new GalwayActivitiesConfig(), visibleItems);
            Accommodation = new ListViewModel<LocalStorageDataConfig, Accommodation1Schema>(new AccommodationConfig(), visibleItems);
            MyUsefulLinks = new ListViewModel<LocalStorageDataConfig, MenuSchema>(new MyUsefulLinksConfig());
            AboutTheApp = new ListViewModel<LocalStorageDataConfig, HtmlSchema>(new AboutTheAppConfig(), visibleItems);
            Actions = new List<ActionInfo>();

            if (GetViewModels().Any(vm => !vm.HasLocalData))
            {
                Actions.Add(new ActionInfo
                {
                    Command = new RelayCommand(Refresh),
                    Style = ActionKnownStyles.Refresh,
                    Name = "RefreshButton",
                    ActionType = ActionType.Primary
                });
            }
        }

        public string PageTitle { get; set; }
        public ListViewModel<LocalStorageDataConfig, HtmlSchema> Welcome { get; private set; }
        public ListViewModel<LocalStorageDataConfig, History1Schema> History { get; private set; }
        public ListViewModel<LocalStorageDataConfig, GalwayEvents1Schema> GalwayEvents { get; private set; }
        public ListViewModel<FlickrDataConfig, FlickrSchema> Pictures { get; private set; }
        public ListViewModel<DynamicStorageDataConfig, FoodAndDrink1Schema> FoodAndDrink { get; private set; }
        public ListViewModel<LocalStorageDataConfig, NightlifeInGalway1Schema> NightlifeInGalway { get; private set; }
        public ListViewModel<BingDataConfig, BingSchema> GalwayActivities { get; private set; }
        public ListViewModel<LocalStorageDataConfig, Accommodation1Schema> Accommodation { get; private set; }
        public ListViewModel<LocalStorageDataConfig, MenuSchema> MyUsefulLinks { get; private set; }
        public ListViewModel<LocalStorageDataConfig, HtmlSchema> AboutTheApp { get; private set; }

        public RelayCommand<INavigable> SectionHeaderClickCommand
        {
            get
            {
                return new RelayCommand<INavigable>(item =>
                    {
                        NavigationService.NavigateTo(item);
                    });
            }
        }

        public DateTime? LastUpdated
        {
            get
            {
                return GetViewModels().Select(vm => vm.LastUpdated)
                            .OrderByDescending(d => d).FirstOrDefault();
            }
        }

        public List<ActionInfo> Actions { get; private set; }

        public bool HasActions
        {
            get
            {
                return Actions != null && Actions.Count > 0;
            }
        }

        public async Task LoadDataAsync()
        {
            var loadDataTasks = GetViewModels().Select(vm => vm.LoadDataAsync());

            await Task.WhenAll(loadDataTasks);

            OnPropertyChanged("LastUpdated");
        }

        private async void Refresh()
        {
            var refreshDataTasks = GetViewModels()
                                        .Where(vm => !vm.HasLocalData)
                                        .Select(vm => vm.LoadDataAsync(true));

            await Task.WhenAll(refreshDataTasks);

            OnPropertyChanged("LastUpdated");
        }

        private IEnumerable<DataViewModelBase> GetViewModels()
        {
            yield return Welcome;
            yield return History;
            yield return GalwayEvents;
            yield return Pictures;
            yield return FoodAndDrink;
            yield return NightlifeInGalway;
            yield return GalwayActivities;
            yield return Accommodation;
            yield return MyUsefulLinks;
            yield return AboutTheApp;
        }
    }
}
