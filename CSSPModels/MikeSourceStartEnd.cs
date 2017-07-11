using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MikeSourceStartEnd
    {
        #region Properties in DB
        [Key]
        public int MikeSourceStartEndID { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "MikeSource", Plurial = "s", FieldID = "MikeSourceID")]
        public int MikeSourceID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime StartDateAndTime_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime EndDateAndTime_Local { get; set; }
        [Range(0.0f, 1000000.0f)]
        public float SourceFlowStart_m3_day { get; set; }
        [Range(0.0f, 1000000.0f)]
        public float SourceFlowEnd_m3_day { get; set; }
        [Range(0, 10000000)]
        public int SourcePollutionStart_MPN_100ml { get; set; }
        [Range(0, 10000000)]
        public int SourcePollutionEnd_MPN_100ml { get; set; }
        [Range(-10.0f, 40.0f)]
        public float SourceTemperatureStart_C { get; set; }
        [Range(-10.0f, 40.0f)]
        public float SourceTemperatureEnd_C { get; set; }
        [Range(0.0f, 40.0f)]
        public float SourceSalinityStart_PSU { get; set; }
        [Range(0.0f, 40.0f)]
        public float SourceSalinityEnd_PSU { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [Range(1, -1)]
        [CSSPExist(TypeName = "TVItem", Plurial = "s", FieldID = "TVItemID")]
        public int LastUpdateContactTVItemID { get; set; }

        public virtual MikeSource MikeSource { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MikeSourceStartEnd()
        {
            // empty for now
        }
        #endregion Constructors
    }
}
