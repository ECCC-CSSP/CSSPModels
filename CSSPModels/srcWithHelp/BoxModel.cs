using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class BoxModel
    {
        #region Properties in DB
        [Key]
        public int BoxModelID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "10")]
        public int InfrastructureTVItemID { get; set; }
        [Range(0.0D, 10000.0D)]
        public double Flow_m3_day { get; set; }
        [Range(0.0D, 1000.0D)]
        public double Depth_m { get; set; }
        [Range(-15.0D, 40.0D)]
        public double Temperature_C { get; set; }
        [Range(0, 10000000)]
        public int Dilution { get; set; }
        [Range(0.0D, 100.0D)]
        public double DecayRate_per_day { get; set; }
        [Range(0, 10000000)]
        public int FCUntreated_MPN_100ml { get; set; }
        [Range(0, 10000000)]
        public int FCPreDisinfection_MPN_100ml { get; set; }
        [Range(0, 10000000)]
        public int Concentration_MPN_100ml { get; set; }
        [Range(0.0D, -1.0D)]
        public double T90_hour { get; set; }
        [Range(0.0D, 24.0D)]
        public double FlowDuration_hour { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "InfrastructureTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string InfrastructureTVText { get; set; }
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        [NotMapped]
        public bool HasErrors { get; set; }
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public BoxModel()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
