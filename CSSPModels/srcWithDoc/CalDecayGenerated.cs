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
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [Error](CSSPModels.CalDecay.html#CSSPModels_CalDecay_Error), [Decay](CSSPModels.CalDecay.html#CSSPModels_CalDecay_Decay), [HasErrors](CSSPModels.CalDecay.html#CSSPModels_CalDecay_HasErrors), [ValidationResults](CSSPModels.CalDecay.html#CSSPModels_CalDecay_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [CalDecayService](CSSPServices.CalDecayService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class CalDecay : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(255)]
        [CSSPAllowNull]
        public string Error { get; set; }
        [Range(0.0D, -1.0D)]
        public double Decay { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public CalDecay() : base()
        {
            Error = "";
        }
        #endregion Constructors
    }
}
