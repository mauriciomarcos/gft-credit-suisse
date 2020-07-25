using System.ComponentModel;

namespace TradesCategories.Models.Enuns
{
    public enum CategoryEnum
    {
        [Description("LOWRISK")]
        LOWRISK,

        [Description("MEDIUMRISK")]
        MEDIUMRISK,

        [Description("HIGHRISK")]
        HIGHRISK,

        [Description("NO CATEGORY")]
        NOCATEGORY
    }
}