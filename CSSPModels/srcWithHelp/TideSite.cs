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
    /// > <para>**DB properties for table TideSites** : [TideSiteID](CSSPModels.TideSite.html#CSSPModels_TideSite_TideSiteID), [TideSiteTVItemID](CSSPModels.TideSite.html#CSSPModels_TideSite_TideSiteTVItemID), [WebTideModel](CSSPModels.TideSite.html#CSSPModels_TideSite_WebTideModel), [WebTideDatum_m](CSSPModels.TideSite.html#CSSPModels_TideSite_WebTideDatum_m), [LastUpdateDate_UTC](CSSPModels.TideSite.html#CSSPModels_TideSite_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.TideSite.html#CSSPModels_TideSite_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [TideSiteWeb](CSSPModels.TideSite.html#CSSPModels_TideSite_TideSiteWeb), [TideSiteReport](CSSPModels.TideSite.html#CSSPModels_TideSite_TideSiteReport), [HasErrors](CSSPModels.TideSite.html#CSSPModels_TideSite_HasErrors), [ValidationResults](CSSPModels.TideSite.html#CSSPModels_TideSite_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TideSiteService](CSSPServices.TideSiteService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class TideSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TideSite ID")]
        [CSSPDisplayFR(DisplayFR = "TideSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TideSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau TideSites")]
        public int TideSiteID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>22 == TideSite</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "22")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "22")]
        public int TideSiteTVItemID { get; set; }
        [StringLength(100)]
        public string WebTideModel { get; set; }
        [Range(-100.0D, 100.0D)]
        public double WebTideDatum_m { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public TideSiteWeb TideSiteWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public TideSiteReport TideSiteReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TideSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideSiteWeb
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TideSiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TideSiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string TideSiteTVText { get; set; }
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
        public TideSiteWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TideSiteReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string TideSiteReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public TideSiteReport()
        {
        }
        #endregion Constructors
    }
}
