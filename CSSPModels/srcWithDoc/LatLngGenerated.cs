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
    /// > <para>**Other properties** : [Lat](CSSPModels.LatLng.html#CSSPModels_LatLng_Lat), [Lng](CSSPModels.LatLng.html#CSSPModels_LatLng_Lng), [HasErrors](CSSPModels.LatLng.html#CSSPModels_LatLng_HasErrors), [ValidationResults](CSSPModels.LatLng.html#CSSPModels_LatLng_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [LatLngService](CSSPServices.LatLngService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    [NotMapped]
    public partial class LatLng : Error
    {
        #region Properties in DB
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Lat")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Lat")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Lat")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lat")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Lat
        /// 
        /// **Display (fr)** --- Lat
        /// 
        /// **Description (en)** --- Lat
        /// 
        /// **Description (fr)** --- Lat
        /// </returns>
        [Range(-180.0D, 180.0D)]
        [CSSPDisplayEN(DisplayEN = "Lat")]
        [CSSPDisplayFR(DisplayFR = "Lat")]
        [CSSPDescriptionEN(DescriptionEN = @"Lat")]
        [CSSPDescriptionFR(DescriptionFR = @"Lat")]
        public double Lat { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Lng")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Lng")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Lng")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lng")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Lng
        /// 
        /// **Display (fr)** --- Lng
        /// 
        /// **Description (en)** --- Lng
        /// 
        /// **Description (fr)** --- Lng
        /// </returns>
        [Range(-90.0D, 90.0D)]
        [CSSPDisplayEN(DisplayEN = "Lng")]
        [CSSPDisplayFR(DisplayFR = "Lng")]
        [CSSPDescriptionEN(DescriptionEN = @"Lng")]
        [CSSPDescriptionFR(DescriptionFR = @"Lng")]
        public double Lng { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public LatLng() : base()
        {
        }
        #endregion Constructors
    }
}
