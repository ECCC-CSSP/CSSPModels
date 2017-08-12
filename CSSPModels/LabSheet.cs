using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class LabSheet
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
        [CSSPAllowNull]
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
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SubsectorTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string SubsectorTVText { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMRunTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string MWQMRunTVText { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "AcceptedOrRejectedByContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string AcceptedOrRejectedByContactTVText { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "SamplingPlanTypeEnum", EnumType = "SamplingPlanType")]
        public string SamplingPlanTypeText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "SampleTypeEnum", EnumType = "SampleType")]
        public string SampleTypeText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "LabSheetTypeEnum", EnumType = "LabSheetType")]
        public string LabSheetTypeText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "LabSheetStatusEnum", EnumType = "LabSheetStatus")]
        public string LabSheetStatusText { get; set; }
        [NotMapped]
        public bool HasErrors { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public LabSheet()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors

    }
}
