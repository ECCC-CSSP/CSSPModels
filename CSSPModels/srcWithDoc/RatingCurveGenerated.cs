/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
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
    /// > <para>**DB properties for table RatingCurves** : [RatingCurveID](CSSPModels.RatingCurve.html#CSSPModels_RatingCurve_RatingCurveID), [HydrometricSiteID](CSSPModels.RatingCurve.html#CSSPModels_RatingCurve_HydrometricSiteID), [RatingCurveNumber](CSSPModels.RatingCurve.html#CSSPModels_RatingCurve_RatingCurveNumber), [LastUpdateDate_UTC](CSSPModels.RatingCurve.html#CSSPModels_RatingCurve_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.RatingCurve.html#CSSPModels_RatingCurve_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.RatingCurve.html#CSSPModels_RatingCurve_HasErrors), [ValidationResults](CSSPModels.RatingCurve.html#CSSPModels_RatingCurve_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [RatingCurveService](CSSPServices.RatingCurveService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class RatingCurve : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "RatingCurve ID")]
        [CSSPDisplayFR(DisplayFR = "RatingCurve ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the RatingCurves table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau RatingCurves")]
        public int RatingCurveID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "HydrometricSite", ExistPlurial = "s", ExistFieldID = "HydrometricSiteID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "HydrometricSite", ExistPlurial = "s", ExistFieldID = "HydrometricSiteID")]
        public int HydrometricSiteID { get; set; }
        [StringLength(50)]
        public string RatingCurveNumber { get; set; }
        #endregion Properties in DB

        #region Constructors
        public RatingCurve() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class RatingCurveWeb : RatingCurve
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public RatingCurveWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class RatingCurveReport : RatingCurveWeb
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string RatingCurveReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public RatingCurveReport() : base()
        {
        }
        #endregion Constructors
    }
}
