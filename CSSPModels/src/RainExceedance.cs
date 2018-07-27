/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class RainExceedance : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "RainExceedance ID")]
        [CSSPDisplayFR(DisplayFR = "RainExceedance ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the RainExceedances table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau RainExceedances")]
        public int RainExceedanceID { get; set; }
        public bool YearRound { get; set; }
        [CSSPAfter(Year = 1980)]
        public DateTime? StartDate_Local { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDate_Local")]
        public DateTime? EndDate_Local { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainMaximum_mm { get; set; }
        [Range(0.0D, 300.0D)]
        public double? RainExtreme_mm { get; set; }
        [Range(0, 30)]
        public int DaysPriorToStart { get; set; }
        public bool RepeatEveryYear { get; set; }
        [StringLength(250)]
        public string ProvinceTVItemIDs { get; set; }
        [StringLength(250)]
        public string SubsectorTVItemIDs { get; set; }
        [StringLength(250)]
        public string ClimateSiteTVItemIDs { get; set; }
        [StringLength(250)]
        public string EmailDistributionListIDs { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public RainExceedanceWeb RainExceedanceWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public RainExceedanceReport RainExceedanceReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public RainExceedance() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class RainExceedanceWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public RainExceedanceWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class RainExceedanceReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string RainExceedanceReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public RainExceedanceReport()
        {
        }
        #endregion Constructors
    }
}
