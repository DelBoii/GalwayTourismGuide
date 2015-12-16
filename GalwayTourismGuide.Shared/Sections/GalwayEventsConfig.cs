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
    public class GalwayEventsConfig : SectionConfigBase<LocalStorageDataConfig, GalwayEvents1Schema>
    {
        public override DataProviderBase<LocalStorageDataConfig, GalwayEvents1Schema> DataProvider
        {
            get
            {
                return new LocalStorageDataProvider<GalwayEvents1Schema>();
            }
        }

        public override LocalStorageDataConfig Config
        {
            get
            {
                return new LocalStorageDataConfig
                {
                    FilePath = "/Assets/Data/GalwayEvents.json"
                };
            }
        }

        public override NavigationInfo ListNavigationInfo
        {
            get 
            {
                return NavigationInfo.FromPage("GalwayEventsListPage");
            }
        }

        public override ListPageConfig<GalwayEvents1Schema> ListPage
        {
            get 
            {
                return new ListPageConfig<GalwayEvents1Schema>
                {
                    Title = "Galway Events",

                    LayoutBindings = (viewModel, item) =>
                    {
                        viewModel.Title = item.Title.ToSafeString();
                        viewModel.SubTitle = item.Subtitle.ToSafeString();
                        viewModel.Description = "";
                        viewModel.Image = item.ImageUrl.ToSafeString();

                    },
                    NavigationInfo = (item) =>
                    {
                        return NavigationInfo.FromPage("GalwayEventsDetailPage", true);
                    }
                };
            }
        }

        public override DetailPageConfig<GalwayEvents1Schema> DetailPage
        {
            get
            {
                var bindings = new List<Action<ItemViewModel, GalwayEvents1Schema>>();

                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = item.Title.ToSafeString();
                    viewModel.Title = "";
                    viewModel.Description = "";
                    viewModel.Image = item.ImageUrl.ToSafeString();
                    viewModel.Content = null;
                });

                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = "practical info";
                    viewModel.Title = item.Phone.ToSafeString();
                    viewModel.Description = item.Address.ToSafeString();
                    viewModel.Image = "";
                    viewModel.Content = null;
                });

				var actions = new List<ActionConfig<GalwayEvents1Schema>>
				{
                    ActionConfig<GalwayEvents1Schema>.Address("Address", (item) => item.Address.ToSafeString()),
                    ActionConfig<GalwayEvents1Schema>.Phone("Phone", (item) => item.Phone.ToSafeString()),
				};

                return new DetailPageConfig<GalwayEvents1Schema>
                {
                    Title = "Galway Events",
                    LayoutBindings = bindings,
                    Actions = actions
                };
            }
        }

        public override string PageTitle
        {
            get { return "Galway Events"; }
        }

    }
}
