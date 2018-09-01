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
    /// > <para>**Other properties** : [Conc](CSSPModels.VPResValues.html#CSSPModels_VPResValues_Conc), [Dilu](CSSPModels.VPResValues.html#CSSPModels_VPResValues_Dilu), [FarfieldWidth](CSSPModels.VPResValues.html#CSSPModels_VPResValues_FarfieldWidth), [Distance](CSSPModels.VPResValues.html#CSSPModels_VPResValues_Distance), [TheTime](CSSPModels.VPResValues.html#CSSPModels_VPResValues_TheTime), [Decay](CSSPModels.VPResValues.html#CSSPModels_VPResValues_Decay), [HasErrors](CSSPModels.VPResValues.html#CSSPModels_VPResValues_HasErrors), [ValidationResults](CSSPModels.VPResValues.html#CSSPModels_VPResValues_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [VPResValuesService](CSSPServices.VPResValuesService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class VPResValues : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(0, -1)]
        public int Conc { get; set; }
        public double Dilu { get; set; }
        public double FarfieldWidth { get; set; }
        public double Distance { get; set; }
        public double TheTime { get; set; }
        public double Decay { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public VPResValues() : base()
        {
        }
        #endregion Constructors
    }
}
