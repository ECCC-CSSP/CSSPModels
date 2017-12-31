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
    /// > <para>**DB properties for table MWQMSubsectorLanguages** : [MWQMSubsectorLanguageID](CSSPModels.MWQMSubsectorLanguage.html#CSSPModels_MWQMSubsectorLanguage_MWQMSubsectorLanguageID), [MWQMSubsectorID](CSSPModels.MWQMSubsectorLanguage.html#CSSPModels_MWQMSubsectorLanguage_MWQMSubsectorID), [Language](CSSPModels.MWQMSubsectorLanguage.html#CSSPModels_MWQMSubsectorLanguage_Language), [SubsectorDesc](CSSPModels.MWQMSubsectorLanguage.html#CSSPModels_MWQMSubsectorLanguage_SubsectorDesc), [TranslationStatusSubsectorDesc](CSSPModels.MWQMSubsectorLanguage.html#CSSPModels_MWQMSubsectorLanguage_TranslationStatusSubsectorDesc), [LogBook](CSSPModels.MWQMSubsectorLanguage.html#CSSPModels_MWQMSubsectorLanguage_LogBook), [TranslationStatusLogBook](CSSPModels.MWQMSubsectorLanguage.html#CSSPModels_MWQMSubsectorLanguage_TranslationStatusLogBook), [LastUpdateDate_UTC](CSSPModels.MWQMSubsectorLanguage.html#CSSPModels_MWQMSubsectorLanguage_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.MWQMSubsectorLanguage.html#CSSPModels_MWQMSubsectorLanguage_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [MWQMSubsectorLanguageWeb](CSSPModels.MWQMSubsectorLanguage.html#CSSPModels_MWQMSubsectorLanguage_MWQMSubsectorLanguageWeb), [MWQMSubsectorLanguageReport](CSSPModels.MWQMSubsectorLanguage.html#CSSPModels_MWQMSubsectorLanguage_MWQMSubsectorLanguageReport), [HasErrors](CSSPModels.MWQMSubsectorLanguage.html#CSSPModels_MWQMSubsectorLanguage_HasErrors), [ValidationResults](CSSPModels.MWQMSubsectorLanguage.html#CSSPModels_MWQMSubsectorLanguage_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MWQMSubsectorLanguageService](CSSPServices.MWQMSubsectorLanguageService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [LanguageEnum](CSSPEnums.LanguageEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class MWQMSubsectorLanguage : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int MWQMSubsectorLanguageID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "MWQMSubsector", ExistPlurial = "s", ExistFieldID = "MWQMSubsectorID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "MWQMSubsector", ExistPlurial = "s", ExistFieldID = "MWQMSubsectorID")]
        public int MWQMSubsectorID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        [StringLength(250)]
        public string SubsectorDesc { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatusSubsectorDesc { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string LogBook { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        [CSSPAllowNull]
        public TranslationStatusEnum? TranslationStatusLogBook { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public MWQMSubsectorLanguageWeb MWQMSubsectorLanguageWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public MWQMSubsectorLanguageReport MWQMSubsectorLanguageReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MWQMSubsectorLanguage() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSubsectorLanguageWeb
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusSubsectorDesc")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusSubsectorDesc")]
        [CSSPAllowNull]
        public string TranslationStatusSubsectorDescText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusLogBook")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatusLogBook")]
        [CSSPAllowNull]
        public string TranslationStatusLogBookText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MWQMSubsectorLanguageWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MWQMSubsectorLanguageReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string MWQMSubsectorLanguageReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MWQMSubsectorLanguageReport()
        {
        }
        #endregion Constructors
    }
}
