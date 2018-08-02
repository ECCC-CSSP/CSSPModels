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
    public partial class TVTypeUserAuthorization : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TVTypeUserAuthorization ID")]
        [CSSPDisplayFR(DisplayFR = "TVTypeUserAuthorization ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TVTypeUserAuthorizations table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau TVTypeUserAuthorizations")]
        public int TVTypeUserAuthorizationID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int ContactTVItemID { get; set; }
        [CSSPEnumType]
        public TVTypeEnum TVType { get; set; }
        [CSSPEnumType]
        public TVAuthEnum TVAuth { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public TVTypeUserAuthorizationWeb TVTypeUserAuthorizationWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public TVTypeUserAuthorizationReport TVTypeUserAuthorizationReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVTypeUserAuthorization() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVTypeUserAuthorizationWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage ContactTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
        public string TVTypeText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVAuthEnum", EnumType = "TVAuth")]
        [CSSPAllowNull]
        public string TVAuthText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public TVTypeUserAuthorizationWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVTypeUserAuthorizationReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string TVTypeUserAuthorizationReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public TVTypeUserAuthorizationReport()
        {
        }
        #endregion Constructors
    }
}
