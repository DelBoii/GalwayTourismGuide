using System;
using AppStudio.DataProviders;

namespace GalwayTourismGuide.Sections
{
    /// <summary>
    /// Implementation of the FoodAndDrink1Schema class.
    /// </summary>
    public class FoodAndDrink1Schema : SchemaBase
    {

        public string Title { get; set; }

        public string Speciality { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public string Website { get; set; }

        public string Phone { get; set; }
    }
}
