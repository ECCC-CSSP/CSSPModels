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
    /// > <para>**DB properties for table TVFileLanguages** : [TVFileLanguageID](CSSPModels.TVFileLanguage.html#CSSPModels_TVFileLanguage_TVFileLanguageID), [TVFileID](CSSPModels.TVFileLanguage.html#CSSPModels_TVFileLanguage_TVFileID), [Language](CSSPModels.TVFileLanguage.html#CSSPModels_TVFileLanguage_Language), [FileDescription](CSSPModels.TVFileLanguage.html#CSSPModels_TVFileLanguage_FileDescription), [TranslationStatus](CSSPModels.TVFileLanguage.html#CSSPModels_TVFileLanguage_TranslationStatus), [LastUpdateDate_UTC](CSSPModels.TVFileLanguage.html#CSSPModels_TVFileLanguage_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.TVFileLanguage.html#CSSPModels_TVFileLanguage_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [LastUpdateContactTVText](CSSPModels.TVFileLanguage.html#CSSPModels_TVFileLanguage_LastUpdateContactTVText), [LanguageText](CSSPModels.TVFileLanguage.html#CSSPModels_TVFileLanguage_LanguageText), [TranslationStatusText](CSSPModels.TVFileLanguage.html#CSSPModels_TVFileLanguage_TranslationStatusText), [HasErrors](CSSPModels.TVFileLanguage.html#CSSPModels_TVFileLanguage_HasErrors), [ValidationResults](CSSPModels.TVFileLanguage.html#CSSPModels_TVFileLanguage_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TVFileLanguageService](CSSPServices.TVFileLanguageService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [LanguageEnum](CSSPEnums.LanguageEnum.html), [TranslationStatusEnum](CSSPEnums.TranslationStatusEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class TVFileLanguage
    {
        #region Properties in DB
        [Key]
        public int TVFileLanguageID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVFile", ExistPlurial = "s", ExistFieldID = "TVFileID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVFile", ExistPlurial = "s", ExistFieldID = "TVFileID")]
        public int TVFileID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public LanguageEnum Language { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string FileDescription { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public TranslationStatusEnum TranslationStatus { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>5 == Contact</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// </summary>
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "LanguageEnum", EnumType = "Language")]</para>
        /// </summary>
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        public string LanguageText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatus")]</para>
        /// </summary>
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "TranslationStatusEnum", EnumType = "TranslationStatus")]
        public string TranslationStatusText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will be set to true if an error occurs during CRUD (Creating, Reading, Updating or Deleting) of [TVFileLanguage](CSSPModels.TVFileLanguage)</para>
        /// </summary>
        [NotMapped]
        public bool HasErrors { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will hold all errors which were detected prior or during CRUD (Creating, Reading, Updating or Deleting) of [TVFileLanguage](CSSPModels.TVFileLanguage)</para>
        /// </summary>
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVFileLanguage()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
