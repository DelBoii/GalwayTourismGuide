using System;
using System.Collections.Generic;
using AppStudio.Common.Navigation;
using AppStudio.DataProviders;
using AppStudio.DataProviders.Core;
using AppStudio.DataProviders.LocalStorage;
using GalwayTourismGuide.Config;
using GalwayTourismGuide.ViewModels;

namespace GalwayTourismGuide.Sections
{
    public class AccommodationConfig : SectionConfigBase<LocalStorageDataConfig, Accommodation1Schema>
    {
        public override DataProviderBase<LocalStorageDataConfig, Accommodation1Schema> DataProvider
        {
            get
            {
                return new LocalStorageDataProvider<Accommodation1Schema>();
            }
        }

        public override LocalStorageDataConfig Config
        {
            get
            {
                return new LocalStorageDataConfig
                {
                    FilePath = "/Assets/Data/Accommodation.json"
                };
            }
        }

        public override NavigationInfo ListNavigationInfo
        {
            get 
            {
                return NavigationInfo.FromPage("AccommodationListPage");
            }
        }

        public override ListPageConfig<Accommodation1Schema> ListPage
        {
            get 
            {
                return new ListPageConfig<Accommodation1Schema>
                {
                    Title = "Accommodation",

                    LayoutBindings = (viewModel, item) =>
                    {
                        viewModel.Title = item.Title.ToSafeString();
                        viewModel.SubTitle = item.Subtitle.ToSafeString();
                        viewModel.Description = "";
                        viewModel.Image = item.ImageUrl.ToSafeString();

                    },
                    NavigationInfo = (item) =>
                    {
                        return NavigationInfo.FromPage("AccommodationDetailPage", true);
                    }
                };
            }
        }

        public override DetailPageConfig<Accommodation1Schema> DetailPage
        {
            get
            {
                var bindings = new List<Action<ItemViewModel, Accommodation1Schema>>();

                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = item.Title.ToSafeString();
                    viewModel.Title = item.Phone.ToSafeString();
                    viewModel.Description = item.Description.ToSafeString();
                    viewModel.Image = item.ImageUrl.ToSafeString();
                    viewModel.Content = null;
                });

				var actions = new List<ActionConfig<Accommodation1Schema>>
				{
                    ActionConfig<Accommodation1Schema>.Link("Go to website", (item) => item.Website.ToSafeString()),
                    ActionConfig<Accommodation1Schema>.Phone("Ring Us", (item) => item.Phone.ToSafeString()),
                    ActionConfig<Accommodation1Schema>.Address("Get Direction", (item) => item.Directions.ToSafeString()),
				};

                return new DetailPageConfig<Accommodation1Schema>
                {
                    Title = "Accommodation",
                    LayoutBindings = bindings,
                    Actions = actions
                };
            }
        }

        public override string PageTitle
        {
            get { return "Accommodation"; }
        }

    }
}
