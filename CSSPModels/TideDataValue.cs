using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class TideDataValue
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
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TideSiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string TideSiteTVText { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "TideDataTypeEnum", EnumType = "TideDataType")]
        public string TideDataTypeText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "StorageDataTypeEnum", EnumType = "StorageDataType")]
        public string StorageDataTypeText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "TideTextEnum", EnumType = "TideStart")]
        public string TideStartText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "TideTextEnum", EnumType = "TideEnd")]
        public string TideEndText { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TideDataValue()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
