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
    /// > <para>**DB properties for table SamplingPlanSubsectorSites** : [SamplingPlanSubsectorSiteID](CSSPModels.SamplingPlanSubsectorSite.html#CSSPModels_SamplingPlanSubsectorSite_SamplingPlanSubsectorSiteID), [SamplingPlanSubsectorID](CSSPModels.SamplingPlanSubsectorSite.html#CSSPModels_SamplingPlanSubsectorSite_SamplingPlanSubsectorID), [MWQMSiteTVItemID](CSSPModels.SamplingPlanSubsectorSite.html#CSSPModels_SamplingPlanSubsectorSite_MWQMSiteTVItemID), [IsDuplicate](CSSPModels.SamplingPlanSubsectorSite.html#CSSPModels_SamplingPlanSubsectorSite_IsDuplicate), [LastUpdateDate_UTC](CSSPModels.SamplingPlanSubsectorSite.html#CSSPModels_SamplingPlanSubsectorSite_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.SamplingPlanSubsectorSite.html#CSSPModels_SamplingPlanSubsectorSite_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.SamplingPlanSubsectorSite.html#CSSPModels_SamplingPlanSubsectorSite_HasErrors), [ValidationResults](CSSPModels.SamplingPlanSubsectorSite.html#CSSPModels_SamplingPlanSubsectorSite_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [SamplingPlanSubsectorSiteService](CSSPServices.SamplingPlanSubsectorSiteService.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class SamplingPlanSubsectorSite : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "SamplingPlanSubsectorSite ID")]
        [CSSPDisplayFR(DisplayFR = "SamplingPlanSubsectorSite ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the SamplingPlanSubsectorSites table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne du tableau SamplingPlanSubsectorSites")]
        public int SamplingPlanSubsectorSiteID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "SamplingPlanSubsector", ExistPlurial = "s", ExistFieldID = "SamplingPlanSubsectorID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "SamplingPlanSubsector", ExistPlurial = "s", ExistFieldID = "SamplingPlanSubsectorID")]
        public int SamplingPlanSubsectorID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>16 == MWQMSite</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "16")]
        public int MWQMSiteTVItemID { get; set; }
        public bool IsDuplicate { get; set; }
        #endregion Properties in DB

        #region Constructors
        public SamplingPlanSubsectorSite() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SamplingPlanSubsectorSiteWeb : SamplingPlanSubsectorSite
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "", FillNeedLanguage = true)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MWQMSiteTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage MWQMSiteTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true)]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        #endregion Properties for web information

        #region Constructors
        public SamplingPlanSubsectorSiteWeb() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class SamplingPlanSubsectorSiteReport : SamplingPlanSubsectorSiteWeb
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string SamplingPlanSubsectorSiteReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public SamplingPlanSubsectorSiteReport() : base()
        {
        }
        #endregion Constructors
    }
}
