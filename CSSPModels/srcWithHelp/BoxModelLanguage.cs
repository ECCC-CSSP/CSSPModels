/*
 * Auto generated from the CSSPModelsGenerateCode.proj by clicking on the [Generate Models With Help] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles LeBlanc
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
    /// > <para>**DB properties for table BoxModelLanguages** : [BoxModelLanguageID](CSSPModels.BoxModelLanguage.html#CSSPModels_BoxModelLanguage_BoxModelLanguageID), [BoxModelID](CSSPModels.BoxModelLanguage.html#CSSPModels_BoxModelLanguage_BoxModelID), [Language](CSSPModels.BoxModelLanguage.html#CSSPModels_BoxModelLanguage_Language), [ScenarioName](CSSPModels.BoxModelLanguage.html#CSSPModels_BoxModelLanguage_ScenarioName), [TranslationStatus](CSSPModels.BoxModelLanguage.html#CSSPModels_BoxModelLanguage_TranslationStatus), [LastUpdateDate_UTC](CSSPModels.BoxModelLanguage.html#CSSPModels_BoxModelLanguage_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.BoxModelLanguage.html#CSSPModels_BoxModelLanguage_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [BoxModelLanguageWeb](CSSPModels.BoxModelLanguage.html#CSSPModels_BoxModelLanguage_BoxModelLanguageWeb), [BoxModelLanguageReport](CSSPModels.BoxModelLanguage.html#CSSPModels_BoxModelLanguage_BoxModelLanguageReport), [HasErrors](CSSPModels.BoxModelLanguage.html#CSSPModels_BoxModelLanguage_HasErrors), [ValidationResults](CSSPModels.BoxModelLanguage.html#CSSPModels_BoxModelLanguage_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [BoxModelLanguageService](CSSPServices.BoxModelLanguageService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [LanguageEnum](CSSPEnums.LanguageEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class BoxModelLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int BoxModelLanguageID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "BoxModel", ExistPlurial = "s", ExistFieldID = "BoxModelID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "BoxModel", ExistPlurial = "s", ExistFieldID = "BoxModelID")]
        public int BoxModelID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(250)]
        public string ScenarioName { get; set; }
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
        public BoxModelLanguageWeb BoxModelLanguageWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public BoxModelLanguageReport BoxModelLanguageReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public BoxModelLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class BoxModelLanguageWeb
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
        public BoxModelLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class BoxModelLanguageReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string BoxModelLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public BoxModelLanguageReport()
        {
        }
        #endregion Constructors
    }
}
