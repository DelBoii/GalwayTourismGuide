using System;
using AppStudio.DataProviders;

namespace GalwayTourismGuide.Sections
{
    /// <summary>
    /// Implementation of the Accommodation1Schema class.
    /// </summary>
    public class Accommodation1Schema : SchemaBase
    {

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public string Directions { get; set; }

        public string Phone { get; set; }

        public string Website { get; set; }
    }
}
