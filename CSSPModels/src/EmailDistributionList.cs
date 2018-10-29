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
    public partial class EmailDistributionList : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "EmailDistributionList ID")]
        [CSSPDisplayFR(DisplayFR = "EmailDistributionList ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the EmailDistributionLists table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table EmailDistributionLists")]
        public int EmailDistributionListID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "6")]
        [CSSPDisplayEN(DisplayEN = "Country")]
        [CSSPDisplayFR(DisplayFR = "Pays")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the country")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant la pays")]
        public int CountryTVItemID { get; set; }
        [Range(0, 1000)]
        [CSSPDisplayEN(DisplayEN = "Ordinal")]
        [CSSPDisplayFR(DisplayFR = "Ordre")]
        [CSSPDescriptionEN(DescriptionEN = @"Ordinal")]
        [CSSPDescriptionFR(DescriptionFR = @"Ordre")]
        public int Ordinal { get; set; }
        #endregion Properties in DB

        #region Constructors
        public EmailDistributionList() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailDistributionListExtraA : EmailDistributionList
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "CountryTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Country name")]
        [CSSPDisplayFR(DisplayFR = "Nom du pays")]
        [CSSPDescriptionEN(DescriptionEN = @"Country name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du pays")]
        public string CountryText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact name")]
        [CSSPDisplayFR(DisplayFR = "Nom du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact name")]
        [CSSPDescriptionFR(DescriptionFR = @"Nom du contact ayant fait le dernière changement")]
        public string LastUpdateContactText { get; set; }
        #endregion Properties

        #region Constructors
        public EmailDistributionListExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailDistributionListExtraB : EmailDistributionListExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string EmailDistributionListReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public EmailDistributionListExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
