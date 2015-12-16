using System;
using AppStudio.DataProviders;

namespace GalwayTourismGuide.Sections
{
    /// <summary>
    /// Implementation of the History1Schema class.
    /// </summary>
    public class History1Schema : SchemaBase
    {

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public string Link { get; set; }
    }
}
