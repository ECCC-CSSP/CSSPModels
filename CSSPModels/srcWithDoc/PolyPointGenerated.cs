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

namespace CSSPModels
{
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**No DB properties** :</para>
    /// > <para>**Other properties** : [XCoord](CSSPModels.PolyPoint.html#CSSPModels_PolyPoint_XCoord), [YCoord](CSSPModels.PolyPoint.html#CSSPModels_PolyPoint_YCoord), [Z](CSSPModels.PolyPoint.html#CSSPModels_PolyPoint_Z), [HasErrors](CSSPModels.PolyPoint.html#CSSPModels_PolyPoint_HasErrors), [ValidationResults](CSSPModels.PolyPoint.html#CSSPModels_PolyPoint_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [PolyPointService](CSSPServices.PolyPointService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class PolyPoint : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        [Range(-180,0D, 180,0D)]
        public double XCoord { get; set; }
        [Range(-90,0D, 90,0D)]
        public double YCoord { get; set; }
        public double Z { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public PolyPoint() : base()
        {
        }
        #endregion Constructors
    }
}
