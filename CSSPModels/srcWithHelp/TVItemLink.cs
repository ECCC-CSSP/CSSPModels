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
    /// > <para>**DB properties for table TVItemLinks** : [TVItemLinkID](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_TVItemLinkID), [FromTVItemID](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_FromTVItemID), [ToTVItemID](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_ToTVItemID), [FromTVType](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_FromTVType), [ToTVType](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_ToTVType), [StartDateTime_Local](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_StartDateTime_Local), [EndDateTime_Local](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_EndDateTime_Local), [Ordinal](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_Ordinal), [TVLevel](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_TVLevel), [TVPath](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_TVPath), [ParentTVItemLinkID](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_ParentTVItemLinkID), [LastUpdateDate_UTC](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [TVItemLinkWeb](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_TVItemLinkWeb), [TVItemLinkReport](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_TVItemLinkReport), [HasErrors](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_HasErrors), [ValidationResults](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TVItemLinkService](CSSPServices.TVItemLinkService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [TVTypeEnum](CSSPEnums.TVTypeEnum.html), [TVTypeEnum](CSSPEnums.TVTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class TVItemLink : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int TVItemLinkID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>1 == Root, 6 == Country, 18 == Province, 3 == Area, 19 == Sector, 20 == Subsector, 4 == ClimateSite, 8 == File, 9 == HydrometricSite, 10 == Infrastructure, 12 == MikeBoundaryConditionMesh, 11 == MikeBoundaryConditionWebTide, 13 == MikeScenario, 14 == MikeSource, 15 == Municipality, 31 == MWQMRun, 16 == MWQMSite, 23 == MWQMSiteSample, 17 == PolSourceSite, 40 == SamplingPlan, 26 == Spill, 22 == TideSite</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22")]
        public int FromTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>1 == Root, 6 == Country, 18 == Province, 3 == Area, 19 == Sector, 20 == Subsector, 4 == ClimateSite, 8 == File, 9 == HydrometricSite, 10 == Infrastructure, 12 == MikeBoundaryConditionMesh, 11 == MikeBoundaryConditionWebTide, 13 == MikeScenario, 14 == MikeSource, 15 == Municipality, 31 == MWQMRun, 16 == MWQMSite, 23 == MWQMSiteSample, 17 == PolSourceSite, 40 == SamplingPlan, 26 == Spill, 22 == TideSite</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22")]
        public int ToTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public TVTypeEnum FromTVType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public TVTypeEnum ToTVType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        public DateTime? StartDateTime_Local { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAfter](CSSPModels.CSSPAfterAttribute.html)(Year = 1980)]</para>
        /// > <para>[[CSSPBigger](CSSPModels.CSSPBiggerAttribute.html)(OtherField = "StartDateTime_Local")]</para>
        /// </summary>
        [CSSPAfter(Year = 1980)]
        [CSSPBigger(OtherField = "StartDateTime_Local")]
        public DateTime? EndDateTime_Local { get; set; }
        [Range(0, 100)]
        public int Ordinal { get; set; }
        [Range(0, 100)]
        public int TVLevel { get; set; }
        [StringLength(250)]
        public string TVPath { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItemLink", ExistPlurial = "s", ExistFieldID = "TVItemLinkID")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItemLink", ExistPlurial = "s", ExistFieldID = "TVItemLinkID")]
        public int? ParentTVItemLinkID { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public TVItemLinkWeb TVItemLinkWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public TVItemLinkReport TVItemLinkReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVItemLink() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemLinkWeb
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "FromTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "FromTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string FromTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ToTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ToTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string ToTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string LastUpdateContactTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TVTypeEnum", EnumType = "FromTVType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "FromTVType")]
        [CSSPAllowNull]
        public string FromTVTypeText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TVTypeEnum", EnumType = "ToTVType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "ToTVType")]
        [CSSPAllowNull]
        public string ToTVTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public TVItemLinkWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemLinkReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string TVItemLinkReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public TVItemLinkReport()
        {
        }
        #endregion Constructors
    }
}
