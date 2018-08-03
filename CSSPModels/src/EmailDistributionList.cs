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
    public partial class EmailDistributionList : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "EmailDistributionList ID")]
        [CSSPDisplayFR(DisplayFR = "EmailDistributionList ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the EmailDistributionLists table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau EmailDistributionLists")]
        public int EmailDistributionListID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "6")]
        public int CountryTVItemID { get; set; }
        [Range(0, 1000)]
        public int Ordinal { get; set; }
        #endregion Properties in DB

        #region Constructors
        public EmailDistributionList() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailDistributionListWeb : EmailDistributionList
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "CountryTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage CountryTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public EmailDistributionListWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailDistributionListReport : EmailDistributionListWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string EmailDistributionListReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public EmailDistributionListReport() : base()
        {
        }
        #endregion Constructors
    }
}
