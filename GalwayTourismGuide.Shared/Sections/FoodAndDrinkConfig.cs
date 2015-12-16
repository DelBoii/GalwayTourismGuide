using System;
using System.Collections.Generic;
using AppStudio.Common;
using AppStudio.Common.Actions;
using AppStudio.Common.Commands;
using AppStudio.Common.Navigation;
using AppStudio.DataProviders;
using AppStudio.DataProviders.Core;
using AppStudio.DataProviders.DynamicStorage;
using Windows.Storage;
using GalwayTourismGuide.Config;
using GalwayTourismGuide.ViewModels;

namespace GalwayTourismGuide.Sections
{
    public class FoodAndDrinkConfig : SectionConfigBase<DynamicStorageDataConfig, FoodAndDrink1Schema>
    {
        public override DataProviderBase<DynamicStorageDataConfig, FoodAndDrink1Schema> DataProvider
        {
            get
            {
                return new DynamicStorageDataProvider<FoodAndDrink1Schema>();
            }
        }

        public override DynamicStorageDataConfig Config
        {
            get
            {
                return new DynamicStorageDataConfig
                {
                    Url = new Uri("http://ds.winappstudio.com/api/data/collection?dataRowListId=d2fbd166-7301-417a-9ea7-8754ec348ef6&appId=eee7977b-73d9-4a65-9675-4ae4c4dcb60b"),
                    AppId = "eee7977b-73d9-4a65-9675-4ae4c4dcb60b",
                    StoreId = ApplicationData.Current.LocalSettings.Values[LocalSettingNames.StoreId] as string,
                    DeviceType = ApplicationData.Current.LocalSettings.Values[LocalSettingNames.DeviceType] as string
                };
            }
        }

        public override NavigationInfo ListNavigationInfo
        {
            get 
            {
                return NavigationInfo.FromPage("FoodAndDrinkListPage");
            }
        }

        public override ListPageConfig<FoodAndDrink1Schema> ListPage
        {
            get 
            {
                return new ListPageConfig<FoodAndDrink1Schema>
                {
                    Title = "Food and Drink",

                    LayoutBindings = (viewModel, item) =>
                    {
                        viewModel.Title = item.Title.ToSafeString();
                        viewModel.SubTitle = item.Speciality.ToSafeString();
                        viewModel.Description = "";
                        viewModel.Image = item.ImageUrl.ToSafeString();

                    },
                    NavigationInfo = (item) =>
                    {
                        return NavigationInfo.FromPage("FoodAndDrinkDetailPage", true);
                    }
                };
            }
        }

        public override DetailPageConfig<FoodAndDrink1Schema> DetailPage
        {
            get
            {
                var bindings = new List<Action<ItemViewModel, FoodAndDrink1Schema>>();

                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = item.Title.ToSafeString();
                    viewModel.Title = item.Speciality.ToSafeString();
                    viewModel.Description = item.Description.ToSafeString();
                    viewModel.Image = item.ImageUrl.ToSafeString();
                    viewModel.Content = null;
                });

				var actions = new List<ActionConfig<FoodAndDrink1Schema>>
				{
                    ActionConfig<FoodAndDrink1Schema>.Address("Get Direction", (item) => item.Location.ToSafeString()),
				};

                return new DetailPageConfig<FoodAndDrink1Schema>
                {
                    Title = "Food and Drink",
                    LayoutBindings = bindings,
                    Actions = actions
                };
            }
        }

        public override string PageTitle
        {
            get { return "Food and Drink"; }
        }

    }
}
