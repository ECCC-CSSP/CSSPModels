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
    /// > <para>**DB properties for table RatingCurveValues** : [RatingCurveValueID](CSSPModels.RatingCurveValue.html#CSSPModels_RatingCurveValue_RatingCurveValueID), [RatingCurveID](CSSPModels.RatingCurveValue.html#CSSPModels_RatingCurveValue_RatingCurveID), [StageValue_m](CSSPModels.RatingCurveValue.html#CSSPModels_RatingCurveValue_StageValue_m), [DischargeValue_m3_s](CSSPModels.RatingCurveValue.html#CSSPModels_RatingCurveValue_DischargeValue_m3_s), [LastUpdateDate_UTC](CSSPModels.RatingCurveValue.html#CSSPModels_RatingCurveValue_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.RatingCurveValue.html#CSSPModels_RatingCurveValue_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [RatingCurveValueWeb](CSSPModels.RatingCurveValue.html#CSSPModels_RatingCurveValue_RatingCurveValueWeb), [RatingCurveValueReport](CSSPModels.RatingCurveValue.html#CSSPModels_RatingCurveValue_RatingCurveValueReport), [HasErrors](CSSPModels.RatingCurveValue.html#CSSPModels_RatingCurveValue_HasErrors), [ValidationResults](CSSPModels.RatingCurveValue.html#CSSPModels_RatingCurveValue_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [RatingCurveValueService](CSSPServices.RatingCurveValueService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class RatingCurveValue : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int RatingCurveValueID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "RatingCurve", ExistPlurial = "s", ExistFieldID = "RatingCurveID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "RatingCurve", ExistPlurial = "s", ExistFieldID = "RatingCurveID")]
        public int RatingCurveID { get; set; }
        [Range(0.0D, 1000.0D)]
        public double StageValue_m { get; set; }
        [Range(0.0D, 1000000.0D)]
        public double DischargeValue_m3_s { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public RatingCurveValueWeb RatingCurveValueWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public RatingCurveValueReport RatingCurveValueReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public RatingCurveValue() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class RatingCurveValueWeb
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public RatingCurveValueWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class RatingCurveValueReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string RatingCurveValueReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public RatingCurveValueReport()
        {
        }
        #endregion Constructors
    }
}
