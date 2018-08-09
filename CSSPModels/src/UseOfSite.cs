/*
 * Manually edited by Charles LeBlanc 
 * 
 */
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CSSPModels
{
    public partial class UseOfSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "UseOfSite ID")]
        [CSSPDisplayFR(DisplayFR = "UseOfSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the UseOfSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table UseOfSites")]
        public int UseOfSiteID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "4,9,22")]
        public int SiteTVItemID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
        public int SubsectorTVItemID { get; set; }
        [CSSPEnumType]
        public SiteTypeEnum SiteType { get; set; }
        [Range(0, 1000)]
        public int Ordinal { get; set; }
        [Range(1980, 2050)]
        public int StartYear { get; set; }
        [Range(1980, 2050)]
        public int? EndYear { get; set; }
        public bool? UseWeight { get; set; }
        [Range(0.0D, 100.0D)]
        public double? Weight_perc { get; set; }
        public bool? UseEquation { get; set; }
        [Range(0.0D, 100.0D)]
        public double? Param1 { get; set; }
        [Range(0.0D, 100.0D)]
        public double? Param2 { get; set; }
        [Range(0.0D, 100.0D)]
        public double? Param3 { get; set; }
        [Range(0.0D, 100.0D)]
        public double? Param4 { get; set; }
        #endregion Properties in DB

        #region Constructors
        public UseOfSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class UseOfSite_A : UseOfSite
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SiteTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage SiteTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SubsectorTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage SubsectorTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "SiteTypeEnum", EnumType = "SiteType")]
        [CSSPAllowNull]
        public string SiteTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public UseOfSite_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class UseOfSite_B : UseOfSite_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string UseOfSiteReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public UseOfSite_B() : base()
        {
        }
        #endregion Constructors
    }
}
