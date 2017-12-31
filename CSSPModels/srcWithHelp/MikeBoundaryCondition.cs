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
    /// > <para>**DB properties for table MikeBoundaryConditions** : [MikeBoundaryConditionID](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_MikeBoundaryConditionID), [MikeBoundaryConditionTVItemID](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_MikeBoundaryConditionTVItemID), [MikeBoundaryConditionCode](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_MikeBoundaryConditionCode), [MikeBoundaryConditionName](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_MikeBoundaryConditionName), [MikeBoundaryConditionLength_m](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_MikeBoundaryConditionLength_m), [MikeBoundaryConditionFormat](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_MikeBoundaryConditionFormat), [MikeBoundaryConditionLevelOrVelocity](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_MikeBoundaryConditionLevelOrVelocity), [WebTideDataSet](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_WebTideDataSet), [NumberOfWebTideNodes](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_NumberOfWebTideNodes), [WebTideDataFromStartToEndDate](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_WebTideDataFromStartToEndDate), [TVType](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_TVType), [LastUpdateDate_UTC](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [MikeBoundaryConditionWeb](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_MikeBoundaryConditionWeb), [MikeBoundaryConditionReport](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_MikeBoundaryConditionReport), [HasErrors](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_HasErrors), [ValidationResults](CSSPModels.MikeBoundaryCondition.html#CSSPModels_MikeBoundaryCondition_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [MikeBoundaryConditionService](CSSPServices.MikeBoundaryConditionService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [MikeBoundaryConditionLevelOrVelocityEnum](CSSPEnums.MikeBoundaryConditionLevelOrVelocityEnum.html), [WebTideDataSetEnum](CSSPEnums.WebTideDataSetEnum.html), [TVTypeEnum](CSSPEnums.TVTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class MikeBoundaryCondition : LastUpdate
    {
        #region Properties in DB
        [Key]
        public int MikeBoundaryConditionID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>12 == MikeBoundaryConditionMesh, 11 == MikeBoundaryConditionWebTide</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "12,11")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "12,11")]
        public int MikeBoundaryConditionTVItemID { get; set; }
        [StringLength(100)]
        public string MikeBoundaryConditionCode { get; set; }
        [StringLength(100)]
        public string MikeBoundaryConditionName { get; set; }
        [Range(1.0D, 100000.0D)]
        public double MikeBoundaryConditionLength_m { get; set; }
        [StringLength(100)]
        public string MikeBoundaryConditionFormat { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public MikeBoundaryConditionLevelOrVelocityEnum MikeBoundaryConditionLevelOrVelocity { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public WebTideDataSetEnum WebTideDataSet { get; set; }
        [Range(0, 1000)]
        public int NumberOfWebTideNodes { get; set; }
        public string WebTideDataFromStartToEndDate { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public TVTypeEnum TVType { get; set; }
        #endregion Properties in DB

        #region Properties not in DB
        [NotMapped]
        [CSSPAllowNull]
        public MikeBoundaryConditionWeb MikeBoundaryConditionWeb { get; set; }
        [NotMapped]
        [CSSPAllowNull]
        public MikeBoundaryConditionReport MikeBoundaryConditionReport { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public MikeBoundaryCondition() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeBoundaryConditionWeb
    {
        #region Properties for web information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MikeBoundaryConditionTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "MikeBoundaryConditionTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        [CSSPAllowNull]
        public string MikeBoundaryConditionTVText { get; set; }
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "MikeBoundaryConditionLevelOrVelocityEnum", EnumType = "MikeBoundaryConditionLevelOrVelocity")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "MikeBoundaryConditionLevelOrVelocityEnum", EnumType = "MikeBoundaryConditionLevelOrVelocity")]
        [CSSPAllowNull]
        public string MikeBoundaryConditionLevelOrVelocityText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "WebTideDataSetEnum", EnumType = "WebTideDataSet")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "WebTideDataSetEnum", EnumType = "WebTideDataSet")]
        [CSSPAllowNull]
        public string WebTideDataSetText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "TVTypeEnum", EnumType = "TVType")]
        [CSSPAllowNull]
        public string TVTypeText { get; set; }
        #endregion Properties for web information

        #region Constructors
        public MikeBoundaryConditionWeb()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class MikeBoundaryConditionReport
    {
        #region Properties for report information
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPAllowNull]
        public string MikeBoundaryConditionReportTest { get; set; }
        #endregion Properties for report information

        #region Constructors
        public MikeBoundaryConditionReport()
        {
        }
        #endregion Constructors
    }
}
