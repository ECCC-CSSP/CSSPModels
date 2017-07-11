using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class VPResult
    {
        #region Properties in DB
        public int VPResultID { get; set; }
        public int VPScenarioID { get; set; }
        public int Ordinal { get; set; }
        public int Concentration_MPN_100ml { get; set; }
        public float Dilution { get; set; }
        public float FarFieldWidth_m { get; set; }
        public float DispersionDistance_m { get; set; }
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
