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
    /// > <para>**DB properties for table EmailDistributionListLanguages** : [EmailDistributionListLanguageID](CSSPModels.EmailDistributionListLanguage.html#CSSPModels_EmailDistributionListLanguage_EmailDistributionListLanguageID), [EmailDistributionListID](CSSPModels.EmailDistributionListLanguage.html#CSSPModels_EmailDistributionListLanguage_EmailDistributionListID), [Language](CSSPModels.EmailDistributionListLanguage.html#CSSPModels_EmailDistributionListLanguage_Language), [RegionName](CSSPModels.EmailDistributionListLanguage.html#CSSPModels_EmailDistributionListLanguage_RegionName), [TranslationStatus](CSSPModels.EmailDistributionListLanguage.html#CSSPModels_EmailDistributionListLanguage_TranslationStatus), [LastUpdateDate_UTC](CSSPModels.EmailDistributionListLanguage.html#CSSPModels_EmailDistributionListLanguage_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.EmailDistributionListLanguage.html#CSSPModels_EmailDistributionListLanguage_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [EmailDistributionListLanguageWeb](CSSPModels.EmailDistributionListLanguage.html#CSSPModels_EmailDistributionListLanguage_EmailDistributionListLanguageWeb), [EmailDistributionListLanguageReport](CSSPModels.EmailDistributionListLanguage.html#CSSPModels_EmailDistributionListLanguage_EmailDistributionListLanguageReport), [HasErrors](CSSPModels.EmailDistributionListLanguage.html#CSSPModels_EmailDistributionListLanguage_HasErrors), [ValidationResults](CSSPModels.EmailDistributionListLanguage.html#CSSPModels_EmailDistributionListLanguage_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [EmailDistributionListLanguageService](CSSPServices.EmailDistributionListLanguageService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [LanguageEnum](CSSPEnums.LanguageEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class EmailDistributionListLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "EmailDistributionListLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "EmailDistributionListLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the EmailDistributionListLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau EmailDistributionListLanguages")]
        public int EmailDistributionListLanguageID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "EmailDistributionList", ExistPlurial = "s", ExistFieldID = "EmailDistributionListID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "EmailDistributionList", ExistPlurial = "s", ExistFieldID = "EmailDistributionListID")]
        public int EmailDistributionListID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string RegionName { get; set; }
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
        public EmailDistributionListLanguageWeb EmailDistributionListLanguageWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public EmailDistributionListLanguageReport EmailDistributionListLanguageReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public EmailDistributionListLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailDistributionListLanguageWeb
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
        public EmailDistributionListLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class EmailDistributionListLanguageReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string EmailDistributionListLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public EmailDistributionListLanguageReport()
        {
        }
        #endregion Constructors
    }
}