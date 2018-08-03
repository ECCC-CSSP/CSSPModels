/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
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
    /// > <para>**DB properties for table ReportTypeLanguages** : [ReportTypeLanguageID](CSSPModels.ReportTypeLanguage.html#CSSPModels_ReportTypeLanguage_ReportTypeLanguageID), [ReportTypeID](CSSPModels.ReportTypeLanguage.html#CSSPModels_ReportTypeLanguage_ReportTypeID), [Language](CSSPModels.ReportTypeLanguage.html#CSSPModels_ReportTypeLanguage_Language), [Name](CSSPModels.ReportTypeLanguage.html#CSSPModels_ReportTypeLanguage_Name), [TranslationStatusName](CSSPModels.ReportTypeLanguage.html#CSSPModels_ReportTypeLanguage_TranslationStatusName), [Description](CSSPModels.ReportTypeLanguage.html#CSSPModels_ReportTypeLanguage_Description), [TranslationStatusDescription](CSSPModels.ReportTypeLanguage.html#CSSPModels_ReportTypeLanguage_TranslationStatusDescription), [StartOfFileName](CSSPModels.ReportTypeLanguage.html#CSSPModels_ReportTypeLanguage_StartOfFileName), [TranslationStatusStartOfFileName](CSSPModels.ReportTypeLanguage.html#CSSPModels_ReportTypeLanguage_TranslationStatusStartOfFileName), [LastUpdateDate_UTC](CSSPModels.ReportTypeLanguage.html#CSSPModels_ReportTypeLanguage_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.ReportTypeLanguage.html#CSSPModels_ReportTypeLanguage_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.ReportTypeLanguage.html#CSSPModels_ReportTypeLanguage_HasErrors), [ValidationResults](CSSPModels.ReportTypeLanguage.html#CSSPModels_ReportTypeLanguage_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [ReportTypeLanguageService](CSSPServices.ReportTypeLanguageService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [LanguageEnum](CSSPEnums.LanguageEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class ReportTypeLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "ReportTypeLanguage ID")]
        [CSSPDisplayFR(DisplayFR = "ReportTypeLanguage ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the ReportTypeLanguages table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau ReportTypeLanguages")]
        public int ReportTypeLanguageID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "ReportType", ExistPlurial = "s", ExistFieldID = "ReportTypeID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "ReportType", ExistPlurial = "s", ExistFieldID = "ReportTypeID")]
        public int ReportTypeID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatusName { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatusDescription { get; set; }
        [StringLength(100)]
        public string StartOfFileName { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatusStartOfFileName { get; set; }
        #endregion Properties in DB

        #region Constructors
        public ReportTypeLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportTypeLanguageWeb : ReportTypeLanguage
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusName")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusName")]
        [CSSPAllowNull]
        public string TranslationStatusNameText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusDescription")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusDescription")]
        [CSSPAllowNull]
        public string TranslationStatusDescriptionText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusStartOfFileName")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusStartOfFileName")]
        [CSSPAllowNull]
        public string TranslationStatusStartOfFileNameText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public ReportTypeLanguageWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class ReportTypeLanguageReport : ReportTypeLanguageWeb
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string ReportTypeLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public ReportTypeLanguageReport() : base()
        {
        }
        #endregion Constructors
    }
}
