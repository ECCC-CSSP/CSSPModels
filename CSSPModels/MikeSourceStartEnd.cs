using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MikeSourceStartEnd
    {
        #region Properties in DB
        public int MikeSourceStartEndID { get; set; }
        public int MikeSourceID { get; set; }
        public DateTime StartDateAndTime_Local { get; set; }
        public DateTime EndDateAndTime_Local { get; set; }
        public float SourceFlowStart_m3_day { get; set; }
        public float SourceFlowEnd_m3_day { get; set; }
        public int SourcePollutionStart_MPN_100ml { get; set; }
        public int SourcePollutionEnd_MPN_100ml { get; set; }
        public float SourceTemperatureStart_C { get; set; }
        public float SourceTemperatureEnd_C { get; set; }
        public float SourceSalinityStart_PSU { get; set; }
        public float SourceSalinityEnd_PSU { get; set; }
        public DateTime LastUpdateDate_UTC { get; set; }
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
