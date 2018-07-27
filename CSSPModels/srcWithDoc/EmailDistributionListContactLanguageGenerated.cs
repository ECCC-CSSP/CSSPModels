/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 27 04:56
 * by leblancc on WMON01DTCHLEBL2 machine
 *
 */ 
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSSPModels
{
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**DB properties for table EmailDistributionListContactLanguages** : [EmailDistributionListContactLanguageID](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_EmailDistributionListContactLanguageID), [EmailDistributionListContactID](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_EmailDistributionListContactID), [Language](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_Language), [Agency](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_Agency), [TranslationStatus](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_TranslationStatus), [LastUpdateDate_UTC](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [EmailDistributionListContactLanguageWeb](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_EmailDistributionListContactLanguageWeb), [EmailDistributionListContactLanguageReport](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_EmailDistributionListContactLanguageReport), [HasErrors](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_HasErrors), [ValidationResults](CSSPModels.EmailDistributionListContactLanguage.html#CSSPModels_EmailDistributionListContactLanguage_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [EmailDistributionListContactLanguageService](CSSPServices.EmailDistributionListContactLanguageService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [LanguageEnum](CSSPEnums.LanguageEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class EmailDistributionListContactLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "EmailDistributionListContactLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "EmailDistributionListContactLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the EmailDistributionListContactLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau EmailDistributionListContactLanguages")]
        public int EmailDistributionListContactLanguageID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "EmailDistributionListContact", ExistPlurial = "s", ExistFieldID = "EmailDistributionListContactID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "EmailDistributionListContact", ExistPlurial = "s", ExistFieldID = "EmailDistributionListContactID")]
        public int EmailDistributionListContactID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string Agency { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public EmailDistributionListContactLanguageWeb EmailDistributionListContactLanguageWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public EmailDistributionListContactLanguageReport EmailDistributionListContactLanguageReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public EmailDistributionListContactLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailDistributionListContactLanguageWeb
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "LanguageEnum", EnumType = "Language")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        [CSSPAllowNull]
        public string LanguageText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatus")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatus")]
        [CSSPAllowNull]
        public string TranslationStatusText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public EmailDistributionListContactLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailDistributionListContactLanguageReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string EmailDistributionListContactLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public EmailDistributionListContactLanguageReport()
        {
        }
        #endregion Constructors
    }
}