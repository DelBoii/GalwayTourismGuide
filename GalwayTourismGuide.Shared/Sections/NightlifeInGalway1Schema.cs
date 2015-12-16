using System;
using AppStudio.DataProviders;

namespace GalwayTourismGuide.Sections
{
    /// <summary>
    /// Implementation of the NightlifeInGalway1Schema class.
    /// </summary>
    public class NightlifeInGalway1Schema : SchemaBase
    {

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }
    }
}
