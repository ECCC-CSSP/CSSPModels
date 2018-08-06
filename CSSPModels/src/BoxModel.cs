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
    public partial class BoxModel : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "BoxModel ID")]
        [CSSPDisplayFR(DisplayFR = "BoxModel ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the BoxModels table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table BoxModels")]
        public int BoxModelID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "10")]
        public int InfrastructureTVItemID { get; set; }
        [Range(0.0D, 10000.0D)]
        public double Flow_m3_day { get; set; }
        [Range(0.0D, 1000.0D)]
        public double Depth_m { get; set; }
        [Range(-15.0D, 40.0D)]
        public double Temperature_C { get; set; }
        [Range(0, 10000000)]
        public int Dilution { get; set; }
        [Range(0.0D, 100.0D)]
        public double DecayRate_per_day { get; set; }
        [Range(0, 10000000)]
        public int FCUntreated_MPN_100ml { get; set; }
        [Range(0, 10000000)]
        public int FCPreDisinfection_MPN_100ml { get; set; }
        [Range(0, 10000000)]
        public int Concentration_MPN_100ml { get; set; }
        [Range(0.0D, -1.0D)]
        public double T90_hour { get; set; }
        [Range(0.0D, 24.0D)]
        public double FlowDuration_hour { get; set; }
        #endregion Properties in DB

        #region Constructors
        public BoxModel() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class BoxModelWeb : BoxModel
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "InfrastructureTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage InfrastructureTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public BoxModelWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class BoxModelReport : BoxModelWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string BoxModelReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public BoxModelReport() : base()
        {
        }
        #endregion Constructors
    }
}
