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
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "X coord")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Coordonnée X")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "X coordinate")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Coordonnée X")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- X coord
        /// 
        /// **Display (fr)** --- Coordonnée X
        /// 
        /// **Description (en)** --- X coordinate
        /// 
        /// **Description (fr)** --- Coordonnée X
        /// </returns>
        [Range(-180.0D, 180.0D)]
        [CSSPDisplayEN(DisplayEN = "X coord")]
        [CSSPDisplayFR(DisplayFR = "Coordonnée X")]
        [CSSPDescriptionEN(DescriptionEN = @"X coordinate")]
        [CSSPDescriptionFR(DescriptionFR = @"Coordonnée X")]
        public double XCoord { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Y coord")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Coordonnée Y")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Y coordinate")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Coordonnée Y")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Y coord
        /// 
        /// **Display (fr)** --- Coordonnée Y
        /// 
        /// **Description (en)** --- Y coordinate
        /// 
        /// **Description (fr)** --- Coordonnée Y
        /// </returns>
        [Range(-90.0D, 90.0D)]
        [CSSPDisplayEN(DisplayEN = "Y coord")]
        [CSSPDisplayFR(DisplayFR = "Coordonnée Y")]
        [CSSPDescriptionEN(DescriptionEN = @"Y coordinate")]
        [CSSPDescriptionFR(DescriptionFR = @"Coordonnée Y")]
        public double YCoord { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Z coord")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Coordonnée Z")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Z coordinate")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Coordonnée Z")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Z coord
        /// 
        /// **Display (fr)** --- Coordonnée Z
        /// 
        /// **Description (en)** --- Z coordinate
        /// 
        /// **Description (fr)** --- Coordonnée Z
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Z coord")]
        [CSSPDisplayFR(DisplayFR = "Coordonnée Z")]
        [CSSPDescriptionEN(DescriptionEN = @"Z coordinate")]
        [CSSPDescriptionFR(DescriptionFR = @"Coordonnée Z")]
        public double Z { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public PolyPoint() : base()
        {
        }
        #endregion Constructors
    }
}
