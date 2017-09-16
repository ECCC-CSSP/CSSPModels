using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class VPResult
    {
        #region Properties in DB
        [Key]
        public int VPResultID { get; set; }
        [CSSPExist(ExistTypeName = "VPScenario", ExistPlurial = "s", ExistFieldID = "VPScenarioID")]
        public int VPScenarioID { get; set; }
        [Range(0, 1000)]
        public int Ordinal { get; set; }
        [Range(0, 10000000)]
        public int Concentration_MPN_100ml { get; set; }
        [Range(0.0D, 1000000.0D)]
        public double Dilution { get; set; }
        [Range(0.0D, 10000.0D)]
        public double FarFieldWidth_m { get; set; }
        [Range(0.0D, 100000.0D)]
        public double DispersionDistance_m { get; set; }
        [Range(0.0D, 100.0D)]
        public double TravelTime_hour { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
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
        public VPResult()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
