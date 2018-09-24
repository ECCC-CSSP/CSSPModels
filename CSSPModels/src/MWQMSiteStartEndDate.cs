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
    public partial class MWQMSiteStartEndDate : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMSiteStartEndDate ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMSiteStartEndDate ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMSiteStartEndDates table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MWQMSiteStartEndDates")]
        public int MWQMSiteStartEndDateID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]
        [CSSPDisplayEN(DisplayEN = "MWQM site TVItemID")]
        [CSSPDisplayFR(DisplayFR = "Site MWQM TVItemID (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing MWQM site")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant le site MWQM (fr)")]
        public int MWQMSiteTVItemID { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]
        [CSSPDisplayEN(DisplayEN = "Start date")]
        [CSSPDisplayFR(DisplayFR = "Date de début")]
        [CSSPDescriptionEN(DescriptionEN = @"Start date")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de début")]
        public DateTime StartDate { get; set; }
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDate")]
        [CSSPDisplayEN(DisplayEN = "End date")]
        [CSSPDisplayFR(DisplayFR = "Date de fin")]
        [CSSPDescriptionEN(DescriptionEN = @"End date")]
        [CSSPDescriptionFR(DescriptionFR = @"Date de fin")]
        public DateTime? EndDate { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMSiteStartEndDate() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSiteStartEndDate_A : MWQMSiteStartEndDate
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "MWQM site TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du site MWQM (fr)")]
        [CSSPDescriptionEN(DescriptionEN = @"MWQM site TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du site MWQM (fr)")]
        public TVItemLanguage MWQMSiteTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSiteStartEndDate_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSiteStartEndDate_B : MWQMSiteStartEndDate_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string MWQMSiteStartEndDateReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSiteStartEndDate_B() : base()
        {
        }
        #endregion Constructors
    }
}
