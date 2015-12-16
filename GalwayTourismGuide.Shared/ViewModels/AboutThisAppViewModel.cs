using System;
using AppStudio.Common;
using Windows.ApplicationModel;

namespace GalwayTourismGuide.ViewModels
{
    public class AboutThisAppViewModel : ObservableBase
    {
        public string Publisher
        {
            get
            {
                return "Ryan Gordon";
            }
        }

        public string AppVersion
        {
            get
            {
                return string.Format("{0}.{1}.{2}.{3}", Package.Current.Id.Version.Major, Package.Current.Id.Version.Minor, Package.Current.Id.Version.Build, Package.Current.Id.Version.Revision);
            }
        }

        public string AboutText
        {
            get
            {
                return "This app provides information on all of Galway\'s biggest events swell as outlinin" +
    "g some of its best late night venues and some recommendations on dining in Galwa" +
    "y to boot! A must have for anyone on their first trip Galway";
            }
        }
    }
}

