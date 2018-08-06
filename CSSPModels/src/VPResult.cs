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
    public partial class VPResult : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "VPResult ID")]
        [CSSPDisplayFR(DisplayFR = "VPResult ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the VPResults table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table VPResults")]
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

        #region Constructors
        public VPResult() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPResultWeb : VPResult
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public VPResultWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class VPResultReport : VPResultWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string VPResultReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public VPResultReport() : base()
        {
        }
        #endregion Constructors
    }
}
