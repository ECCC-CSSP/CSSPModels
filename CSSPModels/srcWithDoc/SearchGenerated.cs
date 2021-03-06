/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
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
    /// > <para>**Other properties** : [value](CSSPModels.Search.html#CSSPModels_Search_value), [id](CSSPModels.Search.html#CSSPModels_Search_id), [CSSPError.HasErrors](CSSPModels.CSSPError.html#CSSPModels_CSSPError_HasErrors), [CSSPError.ValidationResults](CSSPModels.CSSPError.html#CSSPModels_CSSPError_ValidationResults)</para>
    /// > 
    /// > <para>**Inherits [CSSPError](CSSPModels.CSSPError.html)**</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class Search : CSSPError
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Value")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Valeur")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Value")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Valeur")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Value
        /// 
        /// **Display (fr)** --- Valeur
        /// 
        /// **Description (en)** --- Value
        /// 
        /// **Description (fr)** --- Valeur
        /// </returns>
        [StringLength(255, MinimumLength = 1)]
        [CSSPDisplayEN(DisplayEN = "Value")]
        [CSSPDisplayFR(DisplayFR = "Valeur")]
        [CSSPDescriptionEN(DescriptionEN = @"Value")]
        [CSSPDescriptionFR(DescriptionFR = @"Valeur")]
        public string value { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "ID")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "ID")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- ID
        /// 
        /// **Display (fr)** --- ID
        /// 
        /// **Description (en)** --- ID
        /// 
        /// **Description (fr)** --- ID
        /// </returns>
        [Range(1, -1)]
        [CSSPDisplayEN(DisplayEN = "ID")]
        [CSSPDisplayFR(DisplayFR = "ID")]
        [CSSPDescriptionEN(DescriptionEN = @"ID")]
        [CSSPDescriptionFR(DescriptionFR = @"ID")]
        public int id { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public Search() : base()
        {
        }
        #endregion Constructors
    }
}
