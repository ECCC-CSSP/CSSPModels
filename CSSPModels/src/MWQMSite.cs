﻿/*
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
    public partial class MWQMSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMSite ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table MWQMSites")]
        public int MWQMSiteID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]
        public int MWQMSiteTVItemID { get; set; }
        [StringLength(8)]
        public string MWQMSiteNumber { get; set; }
        [StringLength(200)]
        public string MWQMSiteDescription { get; set; }
        [CSSPEnumType]
        public MWQMSiteLatestClassificationEnum MWQMSiteLatestClassification { get; set; }
        [Range(0, 1000)]
        public int Ordinal { get; set; }
        #endregion Properties in DB

        #region Constructors
        public MWQMSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSite_A : MWQMSite
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage MWQMSiteTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "MWQMSiteLatestClassificationEnum", EnumType = "MWQMSiteLatestClassification")]
        [CSSPAllowNull]
        public string MWQMSiteLatestClassificationText { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSite_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSite_B : MWQMSite_A
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string MWQMSiteReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMSite_B() : base()
        {
        }
        #endregion Constructors
    }
}
