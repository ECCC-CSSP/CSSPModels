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
    public partial class ContactPreference : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ContactPreference ID")]
        [CSSPDisplayFR(DisplayFR = "ContactPreference ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ContactPreferences table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau ContactPreferences")]
        public int ContactPreferenceID { get; set; }
        [CSSPExist(ExistTypeName = "Contact", ExistPlurial = "s", ExistFieldID = "ContactID")]
        public int ContactID { get; set; }
        [CSSPEnumType]
        public TVTypeEnum TVType { get; set; }
        [Range(1, 1000)]
        public int MarkerSize { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public ContactPreferenceWeb ContactPreferenceWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public ContactPreferenceReport ContactPreferenceReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ContactPreference() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ContactPreferenceWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
        public string TVTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ContactPreferenceWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ContactPreferenceReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string ContactPreferenceReportText { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ContactPreferenceReport()
        {
        }
        #endregion Constructors
    }
}
