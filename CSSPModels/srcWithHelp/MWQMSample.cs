using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    ///     Entity object for CSSPModels.MWQMSamples DB Table
    /// </summary>
    public partial class MWQMSample
    {
        #region Properties in DB
        [Key]
        public int MWQMSampleID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]
        public int MWQMSiteTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "31")]
        public int MWQMRunTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime SampleDateTime_Local { get; set; }
        [Range(0.0D, 1000.0D)]
        public double? Depth_m { get; set; }
        [Range(0, 10000000)]
        public int FecCol_MPN_100ml { get; set; }
        [Range(0.0D, 40.0D)]
        public double? Salinity_PPT { get; set; }
        [Range(-10.0D, 40.0D)]
        public double? WaterTemp_C { get; set; }
        [Range(0.0D, 14.0D)]
        public double? PH { get; set; }
        [StringLength(50)]
        public string SampleTypesText { get; set; }
        [CSSPEnumType]
        public SampleTypeEnum SampleType_old { get; set; }
        [Range(0, 5)]
        public int? Tube_10 { get; set; }
        [Range(0, 5)]
        public int? Tube_1_0 { get; set; }
        [Range(0, 5)]
        public int? Tube_0_1 { get; set; }
        [StringLength(10)]
        [CSSPAllowNull]
        public string ProcessedBy { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string MWQMSiteTVText { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMRunTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string MWQMRunTVText { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType_old")]
        public string SampleType_oldText { get; set; }
        [NotMapped]
        public bool HasErrors { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMSample()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
