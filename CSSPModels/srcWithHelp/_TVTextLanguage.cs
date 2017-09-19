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
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [TVText](CSSPModels.TVTextLanguage.html#CSSPModels_TVTextLanguage_TVText), [Language](CSSPModels.TVTextLanguage.html#CSSPModels_TVTextLanguage_Language), [LanguageText](CSSPModels.TVTextLanguage.html#CSSPModels_TVTextLanguage_LanguageText), [HasErrors](CSSPModels.TVTextLanguage.html#CSSPModels_TVTextLanguage_HasErrors), [ValidationResults](CSSPModels.TVTextLanguage.html#CSSPModels_TVTextLanguage_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TVTextLanguageService](CSSPServices.TVTextLanguageService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [LanguageEnum](CSSPEnums.LanguageEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class TVTextLanguage
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        public string TVText { get; set; }
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "LanguageEnum", EnumType = "Language")]</para>
        /// </summary>
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "LanguageEnum", EnumType = "Language")]
        public string LanguageText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will be set to true if an error occurs during CRUD (Creating, Reading, Updating or Deleting) of [TVTextLanguage](CSSPModels.TVTextLanguage)</para>
        /// </summary>
        public bool HasErrors { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will hold all errors which were detected prior or during CRUD (Creating, Reading, Updating or Deleting) of [TVTextLanguage](CSSPModels.TVTextLanguage)</para>
        /// </summary>
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVTextLanguage()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
