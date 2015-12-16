using System;
using AppStudio.DataProviders;

namespace GalwayTourismGuide.Sections
{
    /// <summary>
    /// Implementation of the GalwayEvents1Schema class.
    /// </summary>
    public class GalwayEvents1Schema : SchemaBase
    {

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }
    }
}
