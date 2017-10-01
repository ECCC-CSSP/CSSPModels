using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class TideDataValue : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int TideDataValueID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "22")]
        public int TideSiteTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime DateTime_Local { get; set; }
        public bool Keep { get; set; }
        [CSSPEnumType]
        public TideDataTypeEnum TideDataType { get; set; }
        [CSSPEnumType]
        public StorageDataTypeEnum StorageDataType { get; set; }
        [Range(0.0D, 10000.0D)]
        public double Depth_m { get; set; }
        [Range(0.0D, 10.0D)]
        public double UVelocity_m_s { get; set; }
        [Range(0.0D, 10.0D)]
        public double VVelocity_m_s { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public TideTextEnum? TideStart { get; set; }
        [CSSPEnumType]
        [CSSPAllowNull]
        public TideTextEnum? TideEnd { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public TideDataValueWeb TideDataValueWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public TideDataValueReport TideDataValueReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TideDataValue() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideDataValueWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TideSiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string TideSiteTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TideDataTypeEnum", EnumType = "TideDataType")]
        public string TideDataTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "StorageDataTypeEnum", EnumType = "StorageDataType")]
        public string StorageDataTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TideTextEnum", EnumType = "TideStart")]
        public string TideStartText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TideTextEnum", EnumType = "TideEnd")]
        public string TideEndText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public TideDataValueWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideDataValueReport
    {
        #region Properties for report information
        public string TideDataValueReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public TideDataValueReport()
        {
        }
        #endregion Constructors
    }
}
