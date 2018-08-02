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
    /// > <para>**DB properties for table PolSourceSites** : [PolSourceSiteID](CSSPModels.PolSourceSite.html#CSSPModels_PolSourceSite_PolSourceSiteID), [PolSourceSiteTVItemID](CSSPModels.PolSourceSite.html#CSSPModels_PolSourceSite_PolSourceSiteTVItemID), [Temp_Locator_CanDelete](CSSPModels.PolSourceSite.html#CSSPModels_PolSourceSite_Temp_Locator_CanDelete), [Oldsiteid](CSSPModels.PolSourceSite.html#CSSPModels_PolSourceSite_Oldsiteid), [Site](CSSPModels.PolSourceSite.html#CSSPModels_PolSourceSite_Site), [SiteID](CSSPModels.PolSourceSite.html#CSSPModels_PolSourceSite_SiteID), [IsPointSource](CSSPModels.PolSourceSite.html#CSSPModels_PolSourceSite_IsPointSource), [InactiveReason](CSSPModels.PolSourceSite.html#CSSPModels_PolSourceSite_InactiveReason), [CivicAddressTVItemID](CSSPModels.PolSourceSite.html#CSSPModels_PolSourceSite_CivicAddressTVItemID), [LastUpdateDate_UTC](CSSPModels.PolSourceSite.html#CSSPModels_PolSourceSite_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.PolSourceSite.html#CSSPModels_PolSourceSite_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [PolSourceSiteWeb](CSSPModels.PolSourceSite.html#CSSPModels_PolSourceSite_PolSourceSiteWeb), [PolSourceSiteReport](CSSPModels.PolSourceSite.html#CSSPModels_PolSourceSite_PolSourceSiteReport), [HasErrors](CSSPModels.PolSourceSite.html#CSSPModels_PolSourceSite_HasErrors), [ValidationResults](CSSPModels.PolSourceSite.html#CSSPModels_PolSourceSite_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [PolSourceSiteService](CSSPServices.PolSourceSiteService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [PolSourceInactiveReasonEnum](CSSPEnums.PolSourceInactiveReasonEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class PolSourceSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "PolSourceSite ID")]
        [CSSPDisplayFR(DisplayFR = "PolSourceSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the PolSourceSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau PolSourceSites")]
        public int PolSourceSiteID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>17 == PolSourceSite</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "17")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "17")]
        public int PolSourceSiteTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [StringLength(50)]
        [CSSPAllowNull]
        public string Temp_Locator_CanDelete { get; set; }
        [Range(0, 1000)]
        public int? Oldsiteid { get; set; }
        [Range(0, 1000)]
        public int? Site { get; set; }
        [Range(0, 1000)]
        public int? SiteID { get; set; }
        public bool IsPointSource { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        [CSSPAllowNull]
        public PolSourceInactiveReasonEnum? InactiveReason { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>2 == Address</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "2")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "2")]
        public int? CivicAddressTVItemID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public PolSourceSiteWeb PolSourceSiteWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public PolSourceSiteReport PolSourceSiteReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public PolSourceSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class PolSourceSiteWeb
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "PolSourceSiteTVItemID", FillReturnField = "", FillNeedLanguage = true)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "PolSourceSiteTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage PolSourceSiteTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "PolSourceInactiveReasonEnum", EnumType = "InactiveReason")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "PolSourceInactiveReasonEnum", EnumType = "InactiveReason")]
        [CSSPAllowNull]
        public string InactiveReasonText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public PolSourceSiteWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class PolSourceSiteReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string PolSourceSiteReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public PolSourceSiteReport()
        {
        }
        #endregion Constructors
    }
}
