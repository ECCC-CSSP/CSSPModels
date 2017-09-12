using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class TVItemStat
    {
        #region Properties in DB
        [Key]
        public int TVItemStatID { get; set; }
        // AllowableTVTypeList 
        // TVTypeEnum.Root, TVTypeEnum.Country, TVTypeEnum.Province, TVTypeEnum.Area, TVTypeEnum.Sector, TVTypeEnum.Subsector
        // TVTypeEnum.ClimateSite, TVTypeEnum.File, TVTypeEnum.Hydrometric, TVTypeEnum.Infrastructure, TVTypeEnum.MikeBoundaryConditionMesh 
        // TVTypeEnum.MikeBoundaryConditionWebTide, TVTypeEnum.MikeScenario, TVTypeEnum.MikeSource, TVTypeEnum.Municipality
        // TVTypeEnum.MWQMRun, TVTypeEnum.MWQMSite, TVTypeEnum.MWQMSiteSample, TVTypeEnum.PolSourceSite, TVTypeEnum.SamplingPlan
        // TVTypeEnum.Spill, TVTypeEnum.TideSite
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22")]
        public int TVItemID { get; set; }
        [CSSPEnumType]
        public TVTypeEnum TVType { get; set; }
        [Range(0, 10000000)]
        public int ChildCount { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        // AllowableTVTypeList TVTypeEnum.Contact
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string TVText { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        public string TVTypeText { get; set; }
        [NotMapped]
        public bool HasErrors { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVItemStat()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
