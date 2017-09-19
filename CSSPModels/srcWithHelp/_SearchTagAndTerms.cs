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
    /// > <para>**Other properties** : [SearchTag](CSSPModels.SearchTagAndTerms.html#CSSPModels_SearchTagAndTerms_SearchTag), [SearchTagText](CSSPModels.SearchTagAndTerms.html#CSSPModels_SearchTagAndTerms_SearchTagText), [SearchTermList](CSSPModels.SearchTagAndTerms.html#CSSPModels_SearchTagAndTerms_SearchTermList), [HasErrors](CSSPModels.SearchTagAndTerms.html#CSSPModels_SearchTagAndTerms_HasErrors), [ValidationResults](CSSPModels.SearchTagAndTerms.html#CSSPModels_SearchTagAndTerms_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [SearchTagAndTermsService](CSSPServices.SearchTagAndTermsService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [SearchTagEnum](CSSPEnums.SearchTagEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class SearchTagAndTerms
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public SearchTagEnum SearchTag { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "SearchTagEnum", EnumType = "SearchTag")]</para>
        /// </summary>
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "SearchTagEnum", EnumType = "SearchTag")]
        public string SearchTagText { get; set; }
        public virtual List<string> SearchTermList { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will be set to true if an error occurs during CRUD (Creating, Reading, Updating or Deleting) of [SearchTagAndTerms](CSSPModels.SearchTagAndTerms)</para>
        /// </summary>
        public bool HasErrors { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will hold all errors which were detected prior or during CRUD (Creating, Reading, Updating or Deleting) of [SearchTagAndTerms](CSSPModels.SearchTagAndTerms)</para>
        /// </summary>
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public SearchTagAndTerms()
        {
            SearchTermList = new List<string>();
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
