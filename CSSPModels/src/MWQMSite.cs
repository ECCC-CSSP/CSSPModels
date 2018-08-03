﻿/*
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
    public partial class MWQMSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "MWQMSite ID")]
        [CSSPDisplayFR(DisplayFR = "MWQMSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the MWQMSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau MWQMSites")]
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
    public partial class MWQMSiteWeb : MWQMSite
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage MWQMSiteTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "MWQMSiteLatestClassificationEnum", EnumType = "MWQMSiteLatestClassification")]
        [CSSPAllowNull]
        public string MWQMSiteLatestClassificationText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MWQMSiteWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSiteReport : MWQMSiteWeb
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string MWQMSiteReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MWQMSiteReport() : base()
        {
        }
        #endregion Constructors
    }
}
