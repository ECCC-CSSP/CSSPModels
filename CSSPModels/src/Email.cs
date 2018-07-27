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
    public partial class Email : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "Email ID")]
        [CSSPDisplayFR(DisplayFR = "Email ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the Emails table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau Emails")]
        public int EmailID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "7")]
        public int EmailTVItemID { get; set; }
        [StringLength(255)]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [CSSPEnumType]
        public EmailTypeEnum EmailType { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public EmailWeb EmailWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public EmailReport EmailReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Email() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailWeb
    {
        #region Properties for web information
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "EmailTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string EmailTVText { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "EmailTypeEnum", EnumType = "EmailType")]
        [CSSPAllowNull]
        public string EmailTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public EmailWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailReport
    {
        #region Properties for report information
        [CSSPAllowNull]
        public string EmailReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public EmailReport()
        {
        }
        #endregion Constructors
    }
}
