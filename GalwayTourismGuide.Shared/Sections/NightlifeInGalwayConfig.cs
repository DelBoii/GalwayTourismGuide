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
    public class NightlifeInGalwayConfig : SectionConfigBase<LocalStorageDataConfig, NightlifeInGalway1Schema>
    {
        public override DataProviderBase<LocalStorageDataConfig, NightlifeInGalway1Schema> DataProvider
        {
            get
            {
                return new LocalStorageDataProvider<NightlifeInGalway1Schema>();
            }
        }

        public override LocalStorageDataConfig Config
        {
            get
            {
                return new LocalStorageDataConfig
                {
                    FilePath = "/Assets/Data/NightlifeInGalway.json"
                };
            }
        }

        public override NavigationInfo ListNavigationInfo
        {
            get 
            {
                return NavigationInfo.FromPage("NightlifeInGalwayListPage");
            }
        }

        public override ListPageConfig<NightlifeInGalway1Schema> ListPage
        {
            get 
            {
                return new ListPageConfig<NightlifeInGalway1Schema>
                {
                    Title = "Nightlife in Galway",

                    LayoutBindings = (viewModel, item) =>
                    {
                        viewModel.Title = item.Title.ToSafeString();
                        viewModel.SubTitle = item.Subtitle.ToSafeString();
                        viewModel.Description = "";
                        viewModel.Image = item.ImageUrl.ToSafeString();

                    },
                    NavigationInfo = (item) =>
                    {
                        return NavigationInfo.FromPage("NightlifeInGalwayDetailPage", true);
                    }
                };
            }
        }

        public override DetailPageConfig<NightlifeInGalway1Schema> DetailPage
        {
            get
            {
                var bindings = new List<Action<ItemViewModel, NightlifeInGalway1Schema>>();

                bindings.Add((viewModel, item) =>
                {
                    viewModel.PageTitle = item.Title.ToSafeString();
                    viewModel.Title = item.Subtitle.ToSafeString();
                    viewModel.Description = item.Description.ToSafeString();
                    viewModel.Image = item.ImageUrl.ToSafeString();
                    viewModel.Content = null;
                });

				var actions = new List<ActionConfig<NightlifeInGalway1Schema>>
				{
                    ActionConfig<NightlifeInGalway1Schema>.Phone("Contact us", (item) => item.Phone.ToSafeString()),
                    ActionConfig<NightlifeInGalway1Schema>.Link("Our Website", (item) => item.Website.ToSafeString()),
				};

                return new DetailPageConfig<NightlifeInGalway1Schema>
                {
                    Title = "Nightlife in Galway",
                    LayoutBindings = bindings,
                    Actions = actions
                };
            }
        }

        public override string PageTitle
        {
            get { return "Nightlife in Galway"; }
        }

    }
}
