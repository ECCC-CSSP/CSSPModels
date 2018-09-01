/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles on CHARLES-PC machine
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
    public partial class SearchTagAndTerms : Error
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "SearchTagEnum", EnumType = "SearchTag")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(100)]
        [CSSPEnumTypeText(EnumTypeName = "SearchTagEnum", EnumType = "SearchTag")]
        [CSSPAllowNull]
        public string SearchTagText { get; set; }
        public List<string> SearchTermList { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public SearchTagAndTerms() : base()
        {
            SearchTermList = new List<string>();
        }
        #endregion Constructors
    }
}
