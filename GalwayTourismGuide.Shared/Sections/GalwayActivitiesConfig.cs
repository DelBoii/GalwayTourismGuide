using System;
using System.Collections.Generic;
using AppStudio.Common.Actions;
using AppStudio.Common.Commands;
using AppStudio.Common.Navigation;
using AppStudio.DataProviders;
using AppStudio.DataProviders.Core;
using AppStudio.DataProviders.Bing;
using GalwayTourismGuide.Config;
using GalwayTourismGuide.ViewModels;

namespace GalwayTourismGuide.Sections
{
    public class GalwayActivitiesConfig : SectionConfigBase<BingDataConfig, BingSchema>
    {
        public override DataProviderBase<BingDataConfig, BingSchema> DataProvider
        {
            get
            {
                return new BingDataProvider();
            }
        }

        public override BingDataConfig Config
        {
            get
            {
                return new BingDataConfig
                {
                    Country = BingCountry.Ireland,
                    Query = @"galway things to do"
                };
            }
        }

        public override NavigationInfo ListNavigationInfo
        {
            get 
            {
                return NavigationInfo.FromPage("GalwayActivitiesListPage");
            }
        }


        public override ListPageConfig<BingSchema> ListPage
        {
            get 
            {
                return new ListPageConfig<BingSchema>
                {
                    Title = "Galway Activities",

                    LayoutBindings = (viewModel, item) =>
                    {
                        viewModel.Title = item.Title.ToSafeString();
                        viewModel.SubTitle = item.Summary.ToSafeString();
                        viewModel.Description = null;
                        viewModel.Image = null;

                    },
                    NavigationInfo = (item) =>
                    {
                        return new NavigationInfo
                        {
                            NavigationType = NavigationType.DeepLink,
                            TargetUri = new Uri(item.Link)
                        };
                    }
                };
            }
        }

        public override DetailPageConfig<BingSchema> DetailPage
        {
            get { return null; }
        }

        public override string PageTitle
        {
            get { return "Galway Activities"; }
        }

    }
}
