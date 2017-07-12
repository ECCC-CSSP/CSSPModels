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
        [Range(1, -1)]
        [CSSPExist(TypeName = "VPScenario", Plurial = "s", FieldID = "VPScenarioID")]
        public int VPScenarioID { get; set; }
        [Range(0, 1000)]
        public int Ordinal { get; set; }
        [Range(0, 10000000)]
        public int Concentration_MPN_100ml { get; set; }
        [Range(0.0f, 1000000.0f)]
        public float Dilution { get; set; }
        [Range(0.0f, 10000.0f)]
        public float FarFieldWidth_m { get; set; }
        [Range(0.0f, 100000.0f)]
        public float DispersionDistance_m { get; set; }
        [Range(-10.0f, 0.0f)]
        public float TravelTime_hour { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual VPScenario VPScenario { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPResult()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
