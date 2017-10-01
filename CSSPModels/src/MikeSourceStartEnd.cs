using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class MikeSourceStartEnd : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int MikeSourceStartEndID { get; set; }
        [CSSPExist(ExistTypeName = "MikeSource", ExistPlurial = "s", ExistFieldID = "MikeSourceID")]
        public int MikeSourceID { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime StartDateAndTime_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDateAndTime_Local")]
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
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public MikeSourceStartEndWeb MikeSourceStartEndWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public MikeSourceStartEndReport MikeSourceStartEndReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MikeSourceStartEnd() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeSourceStartEndWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MikeSourceStartEndWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeSourceStartEndReport
    {
        #region Properties for report information
        public string MikeSourceStartEndReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MikeSourceStartEndReport()
        {
        }
        #endregion Constructors
    }
}
