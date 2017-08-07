using CSSPEnums;
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
        [CSSPExist(ExistTypeName = "MikeSource", ExistPlurial = "s", ExistFieldID = "MikeSourceID")]
        public int MikeSourceID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime StartDateAndTime_Local { get; set; }
        [CSSPBigger(OtherField = "StartDateAndTime_Local")]
        [CSSPAfter(Year = 1980)]
        public DateTime EndDateAndTime_Local { get; set; }
        [Range(0.0D, 1000000.0D)]
        public double SourceFlowStart_m3_day { get; set; }
        [Range(0.0D, 1000000.0D)]
        public double SourceFlowEnd_m3_day { get; set; }
        [Range(0, 10000000)]
        public int SourcePollutionStart_MPN_100ml { get; set; }
        [Range(0, 10000000)]
        public int SourcePollutionEnd_MPN_100ml { get; set; }
        [Range(-10.0D, 40.0D)]
        public double SourceTemperatureStart_C { get; set; }
        [Range(-10.0D, 40.0D)]
        public double SourceTemperatureEnd_C { get; set; }
        [Range(0.0D, 40.0D)]
        public double SourceSalinityStart_PSU { get; set; }
        [Range(0.0D, 40.0D)]
        public double SourceSalinityEnd_PSU { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
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
