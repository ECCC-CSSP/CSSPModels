using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class VPResult : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "VPResult ID")]
        [CSSPDisplayFR(DisplayFR = "VPResult ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the VPResults table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau VPResults")]
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
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public VPResultWeb VPResultWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public VPResultReport VPResultReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPResult() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPResultWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public VPResultWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPResultReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string VPResultReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public VPResultReport()
        {
        }
        #endregion Constructors
    }
}
