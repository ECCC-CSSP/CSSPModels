using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MapInfo : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int MapInfoID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22,28,25,42,38,73,72,74,36,33,29,35,39")]
        public int TVItemID { get; set; }
        [CSSPEnumType]
        public TVTypeEnum TVType { get; set; }
        [Range(-90.0D, 90.0D)]
        public double LatMin { get; set; }
        [Range(-90.0D, 90.0D)]
        public double LatMax { get; set; }
        [Range(-180.0D, 180.0D)]
        public double LngMin { get; set; }
        [Range(-180.0D, 180.0D)]
        public double LngMax { get; set; }
        [CSSPEnumType]
        public MapInfoDrawTypeEnum MapInfoDrawType { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public MapInfoWeb MapInfoWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public MapInfoReport MapInfoReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MapInfo() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MapInfoWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string TVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
        public string TVTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "MapInfoDrawTypeEnum", EnumType = "MapInfoDrawType")]
        [CSSPAllowNull]
        public string MapInfoDrawTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MapInfoWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MapInfoReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string MapInfoReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MapInfoReport()
        {
        }
        #endregion Constructors
    }
}
