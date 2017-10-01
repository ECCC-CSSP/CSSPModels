using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    public partial class VPAmbient : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int VPAmbientID { get; set; }
        [CSSPExist(ExistTypeName = "VPScenario", ExistPlurial = "s", ExistFieldID = "VPScenarioID")]
        public int VPScenarioID { get; set; }
        [Range(0, 10)]
        public int Row { get; set; }
        [Range(0.0D, 1000.0D)]
        public double MeasurementDepth_m { get; set; }
        [Range(0.0D, 10.0D)]
        public double CurrentSpeed_m_s { get; set; }
        [Range(-180.0D, 180.0D)]
        public double CurrentDirection_deg { get; set; }
        [Range(0.0D, 40.0D)]
        public double AmbientSalinity_PSU { get; set; }
        [Range(-10.0D, 40.0D)]
        public double AmbientTemperature_C { get; set; }
        [Range(0, 10000000)]
        public int BackgroundConcentration_MPN_100ml { get; set; }
        [Range(0.0D, 100.0D)]
        public double PollutantDecayRate_per_day { get; set; }
        [Range(0.0D, 10.0D)]
        public double FarFieldCurrentSpeed_m_s { get; set; }
        [Range(-180.0D, 180.0D)]
        public double FarFieldCurrentDirection_deg { get; set; }
        [Range(0.0D, 1.0D)]
        public double FarFieldDiffusionCoefficient { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public VPAmbientWeb VPAmbientWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public VPAmbientReport VPAmbientReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPAmbient() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPAmbientWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public VPAmbientWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPAmbientReport
    {
        #region Properties for report information
        public string VPAmbientReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public VPAmbientReport()
        {
        }
        #endregion Constructors
    }
}
