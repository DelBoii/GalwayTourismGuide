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
    public class HistoryConfig : SectionConfigBase<LocalStorageDataConfig, History1Schema>
    {
        public override DataProviderBase<LocalStorageDataConfig, History1Schema> DataProvider
        {
            get
            {
                return new LocalStorageDataProvider<History1Schema>();
            }
        }

        public override LocalStorageDataConfig Config
        {
            get
            {
                return new LocalStorageDataConfig
                {
                    FilePath = "/Assets/Data/History.json"
                };
            }
        }

        public override NavigationInfo ListNavigationInfo
        {
            get 
            {
                return NavigationInfo.FromPage("HistoryListPage");
            }
        }

        public override ListPageConfig<History1Schema> ListPage
        {
            get 
            {
                return new ListPageConfig<History1Schema>
                {
                    Title = "History",

                    LayoutBindings = (viewModel, item) =>
                    {
                        viewModel.Title = item.Title.ToSafeString();
                        viewModel.SubTitle = item.Subtitle.ToSafeString();
                        viewModel.Description = "";
                        viewModel.Image = item.ImageUrl.ToSafeString();

                    },
                    NavigationInfo = (item) =>
                    {
                        return NavigationInfo.FromPage("HistoryDetailPage", true);
                    }
                };
            }
        }

        public override DetailPageConfig<History1Schema> DetailPage
        {
            get
            {
                var bindings = new List<Action<ItemViewModel, History1Schema>>();

                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = item.Title.ToSafeString();
                    viewModel.Title = item.Subtitle.ToSafeString();
                    viewModel.Description = item.Description.ToSafeString();
                    viewModel.Image = item.ImageUrl.ToSafeString();
                    viewModel.Content = null;
                });

				var actions = new List<ActionConfig<History1Schema>>
				{
				};

                return new DetailPageConfig<History1Schema>
                {
                    Title = "History",
                    LayoutBindings = bindings,
                    Actions = actions
                };
            }
        }

        public override string PageTitle
        {
            get { return "History"; }
        }

    }
}
