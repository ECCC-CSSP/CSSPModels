/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 August 01 05:00
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
    /// > <para>**DB properties for table ReportSectionLanguages** : [ReportSectionLanguageID](CSSPModels.ReportSectionLanguage.html#CSSPModels_ReportSectionLanguage_ReportSectionLanguageID), [ReportSectionID](CSSPModels.ReportSectionLanguage.html#CSSPModels_ReportSectionLanguage_ReportSectionID), [Language](CSSPModels.ReportSectionLanguage.html#CSSPModels_ReportSectionLanguage_Language), [ReportSectionName](CSSPModels.ReportSectionLanguage.html#CSSPModels_ReportSectionLanguage_ReportSectionName), [TranslationStatusReportSectionName](CSSPModels.ReportSectionLanguage.html#CSSPModels_ReportSectionLanguage_TranslationStatusReportSectionName), [ReportSectionText](CSSPModels.ReportSectionLanguage.html#CSSPModels_ReportSectionLanguage_ReportSectionText), [TranslationStatusReportSectionText](CSSPModels.ReportSectionLanguage.html#CSSPModels_ReportSectionLanguage_TranslationStatusReportSectionText), [LastUpdateDate_UTC](CSSPModels.ReportSectionLanguage.html#CSSPModels_ReportSectionLanguage_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.ReportSectionLanguage.html#CSSPModels_ReportSectionLanguage_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [ReportSectionLanguageWeb](CSSPModels.ReportSectionLanguage.html#CSSPModels_ReportSectionLanguage_ReportSectionLanguageWeb), [ReportSectionLanguageReport](CSSPModels.ReportSectionLanguage.html#CSSPModels_ReportSectionLanguage_ReportSectionLanguageReport), [HasErrors](CSSPModels.ReportSectionLanguage.html#CSSPModels_ReportSectionLanguage_HasErrors), [ValidationResults](CSSPModels.ReportSectionLanguage.html#CSSPModels_ReportSectionLanguage_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [ReportSectionLanguageService](CSSPServices.ReportSectionLanguageService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [LanguageEnum](CSSPEnums.LanguageEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class ReportSectionLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ReportSectionLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "ReportSectionLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ReportSectionLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau ReportSectionLanguages")]
        public int ReportSectionLanguageID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "ReportSection", ExistPlurial = "s", ExistFieldID = "ReportSectionID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "ReportSection", ExistPlurial = "s", ExistFieldID = "ReportSectionID")]
        public int ReportSectionID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(100)]
        public string ReportSectionName { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatusReportSectionName { get; set; }
        [StringLength(10000)]
        public string ReportSectionText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatusReportSectionText { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public ReportSectionLanguageWeb ReportSectionLanguageWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public ReportSectionLanguageReport ReportSectionLanguageReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public ReportSectionLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportSectionLanguageWeb
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusReportSectionName")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusReportSectionName")]
        [CSSPAllowNull]
        public string TranslationStatusReportSectionNameText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusReportSectionText")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusReportSectionText")]
        [CSSPAllowNull]
        public string TranslationStatusReportSectionNameTextText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ReportSectionLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportSectionLanguageReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string ReportSectionLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ReportSectionLanguageReport()
        {
        }
        #endregion Constructors
    }
}
