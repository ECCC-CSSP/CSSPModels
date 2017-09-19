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
    /// > <para>**DB properties for table UseOfSites** : [UseOfSiteID](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_UseOfSiteID), [SiteTVItemID](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_SiteTVItemID), [SubsectorTVItemID](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_SubsectorTVItemID), [SiteType](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_SiteType), [Ordinal](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_Ordinal), [StartYear](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_StartYear), [EndYear](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_EndYear), [UseWeight](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_UseWeight), [Weight_perc](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_Weight_perc), [UseEquation](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_UseEquation), [Param1](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_Param1), [Param2](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_Param2), [Param3](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_Param3), [Param4](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_Param4), [LastUpdateDate_UTC](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [SiteTVText](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_SiteTVText), [SubsectorTVText](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_SubsectorTVText), [LastUpdateContactTVText](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_LastUpdateContactTVText), [SiteTypeText](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_SiteTypeText), [HasErrors](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_HasErrors), [ValidationResults](CSSPModels.UseOfSite.html#CSSPModels_UseOfSite_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [UseOfSiteService](CSSPServices.UseOfSiteService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [SiteTypeEnum](CSSPEnums.SiteTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class UseOfSite
    {
        #region Properties in DB
        [Key]
        public int UseOfSiteID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>4 == ClimateSite, 9 == HydrometricSite, 22 == TideSite</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "4,9,22")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "4,9,22")]
        public int SiteTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>20 == Subsector</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "20")]
        public int SubsectorTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public SiteTypeEnum SiteType { get; set; }
        [Range(0, 1000)]
        public int Ordinal { get; set; }
        [Range(1980, 2050)]
        public int StartYear { get; set; }
        [Range(1980, 2050)]
        public int? EndYear { get; set; }
        public bool? UseWeight { get; set; }
        [Range(0.0D, 100.0D)]
        public double? Weight_perc { get; set; }
        public bool? UseEquation { get; set; }
        [Range(0.0D, 100.0D)]
        public double? Param1 { get; set; }
        [Range(0.0D, 100.0D)]
        public double? Param2 { get; set; }
        [Range(0.0D, 100.0D)]
        public double? Param3 { get; set; }
        [Range(0.0D, 100.0D)]
        public double? Param4 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime LastUpdateDate_UTC { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>5 == Contact</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int LastUpdateContactTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// </summary>
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SiteTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string SiteTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SubsectorTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// </summary>
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "SubsectorTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string SubsectorTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// </summary>
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string LastUpdateContactTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "SiteTypeEnum", EnumType = "SiteType")]</para>
        /// </summary>
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "SiteTypeEnum", EnumType = "SiteType")]
        public string SiteTypeText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will be set to true if an error occurs during CRUD (Creating, Reading, Updating or Deleting) of [UseOfSite](CSSPModels.UseOfSite)</para>
        /// </summary>
        [NotMapped]
        public bool HasErrors { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will hold all errors which were detected prior or during CRUD (Creating, Reading, Updating or Deleting) of [UseOfSite](CSSPModels.UseOfSite)</para>
        /// </summary>
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public UseOfSite()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
