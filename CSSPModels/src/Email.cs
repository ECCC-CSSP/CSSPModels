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
    public partial class Email : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "Email ID")]
        [CSSPDisplayFR(DisplayFR = "Email ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the Emails table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table Emails")]
        public int EmailID { get; set; }
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "7")]
        [CSSPDisplayEN(DisplayEN = "Email")]
        [CSSPDisplayFR(DisplayFR = "Courriel")]
        [CSSPDescriptionEN(DescriptionEN = @"Link to the TVItems table representing the email")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien à la table TVItems représentant la courriel")]
        public int EmailTVItemID { get; set; }
        [StringLength(255)]
        [DataType(DataType.EmailAddress)]
        [CSSPDisplayEN(DisplayEN = "Email address")]
        [CSSPDisplayFR(DisplayFR = "Adresse courriel")]
        [CSSPDescriptionEN(DescriptionEN = @"Email address")]
        [CSSPDescriptionFR(DescriptionFR = @"Adresse courriel")]
        public string EmailAddress { get; set; }
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Email type")]
        [CSSPDisplayFR(DisplayFR = "Type de courriel")]
        [CSSPDescriptionEN(DescriptionEN = @"Email type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de courriel")]
        public EmailTypeEnum EmailType { get; set; }
        #endregion Properties in DB

        #region Constructors
        public Email() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailExtraA : Email
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "EmailTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage EmailTVItemLanguage { get; set; }
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        [CSSPEnumTypeText(EnumTypeName = "EmailTypeEnum", EnumType = "EmailType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Email type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type de courriel")]
        [CSSPDescriptionEN(DescriptionEN = @"Email type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type de courriel")]
        public string EmailTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public EmailExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailExtraB : EmailExtraA
    {
        #region Properties
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string EmailReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public EmailExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
