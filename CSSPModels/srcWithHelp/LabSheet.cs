using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class LabSheet : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int LabSheetID { get; set; }
        [Range(1, -1)]
        public int OtherServerLabSheetID { get; set; }
        [CSSPExist(ExistTypeName = "SamplingPlan", ExistPlurial = "s", ExistFieldID = "SamplingPlanID")]
        public int SamplingPlanID { get; set; }
        [StringLength(250, MinimumLength = 1)]
        public string SamplingPlanName { get; set; }
        [Range(1980, -1)]
        public int Year { get; set; }
        [Range(1, 12)]
        public int Month { get; set; }
        [Range(1, 31)]
        public int Day { get; set; }
        [Range(1, 100)]
        public int RunNumber { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
        public int SubsectorTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "31")]
        public int? MWQMRunTVItemID { get; set; }
        [CSSPEnumType]
        public SamplingPlanTypeEnum SamplingPlanType { get; set; }
        [CSSPEnumType]
        public SampleTypeEnum SampleType { get; set; }
        [CSSPEnumType]
        public LabSheetTypeEnum LabSheetType { get; set; }
        [CSSPEnumType]
        public LabSheetStatusEnum LabSheetStatus { get; set; }
        [StringLength(250, MinimumLength = 1)]
        public string FileName { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime FileLastModifiedDate_Local { get; set; }
        public string FileContent { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int? AcceptedOrRejectedByContactTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? AcceptedOrRejectedDateTime { get; set; }
        [StringLength(250)]
        [CSSPAllowNull]
        public string RejectReason { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public LabSheetWeb LabSheetWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public LabSheetReport LabSheetReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public LabSheet() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class LabSheetWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SubsectorTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string SubsectorTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMRunTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string MWQMRunTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "AcceptedOrRejectedByContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string AcceptedOrRejectedByContactTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SamplingPlanTypeEnum", EnumType = "SamplingPlanType")]
        [CSSPAllowNull]
        public string SamplingPlanTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType")]
        [CSSPAllowNull]
        public string SampleTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LabSheetTypeEnum", EnumType = "LabSheetType")]
        [CSSPAllowNull]
        public string LabSheetTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "LabSheetStatusEnum", EnumType = "LabSheetStatus")]
        [CSSPAllowNull]
        public string LabSheetStatusText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public LabSheetWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class LabSheetReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string LabSheetReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public LabSheetReport()
        {
        }
        #endregion Constructors
    }
}
