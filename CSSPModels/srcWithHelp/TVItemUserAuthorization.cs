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
    /// > <para>**DB properties for table TVItemUserAuthorizations** : [TVItemUserAuthorizationID](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_TVItemUserAuthorizationID), [ContactTVItemID](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_ContactTVItemID), [TVItemID1](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_TVItemID1), [TVItemID2](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_TVItemID2), [TVItemID3](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_TVItemID3), [TVItemID4](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_TVItemID4), [TVAuth](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_TVAuth), [LastUpdateDate_UTC](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [ContactTVText](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_ContactTVText), [TVText1](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_TVText1), [TVText2](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_TVText2), [TVText3](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_TVText3), [TVText4](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_TVText4), [LastUpdateContactTVText](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_LastUpdateContactTVText), [TVAuthText](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_TVAuthText), [HasErrors](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_HasErrors), [ValidationResults](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TVItemUserAuthorizationService](CSSPServices.TVItemUserAuthorizationService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [TVAuthEnum](CSSPEnums.TVAuthEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class TVItemUserAuthorization
    {
        #region Properties in DB
        [Key]
        public int TVItemUserAuthorizationID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>5 == Contact</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "5")]
        public int ContactTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>1 == Root, 6 == Country, 18 == Province, 3 == Area, 19 == Sector, 20 == Subsector, 4 == ClimateSite, 8 == File, 9 == HydrometricSite, 10 == Infrastructure, 12 == MikeBoundaryConditionMesh, 11 == MikeBoundaryConditionWebTide, 13 == MikeScenario, 14 == MikeSource, 15 == Municipality, 31 == MWQMRun, 16 == MWQMSite, 23 == MWQMSiteSample, 17 == PolSourceSite, 40 == SamplingPlan, 26 == Spill, 22 == TideSite</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22")]
        public int TVItemID1 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>1 == Root, 6 == Country, 18 == Province, 3 == Area, 19 == Sector, 20 == Subsector, 4 == ClimateSite, 8 == File, 9 == HydrometricSite, 10 == Infrastructure, 12 == MikeBoundaryConditionMesh, 11 == MikeBoundaryConditionWebTide, 13 == MikeScenario, 14 == MikeSource, 15 == Municipality, 31 == MWQMRun, 16 == MWQMSite, 23 == MWQMSiteSample, 17 == PolSourceSite, 40 == SamplingPlan, 26 == Spill, 22 == TideSite</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22")]
        public int? TVItemID2 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>1 == Root, 6 == Country, 18 == Province, 3 == Area, 19 == Sector, 20 == Subsector, 4 == ClimateSite, 8 == File, 9 == HydrometricSite, 10 == Infrastructure, 12 == MikeBoundaryConditionMesh, 11 == MikeBoundaryConditionWebTide, 13 == MikeScenario, 14 == MikeSource, 15 == Municipality, 31 == MWQMRun, 16 == MWQMSite, 23 == MWQMSiteSample, 17 == PolSourceSite, 40 == SamplingPlan, 26 == Spill, 22 == TideSite</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22")]
        public int? TVItemID3 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>1 == Root, 6 == Country, 18 == Province, 3 == Area, 19 == Sector, 20 == Subsector, 4 == ClimateSite, 8 == File, 9 == HydrometricSite, 10 == Infrastructure, 12 == MikeBoundaryConditionMesh, 11 == MikeBoundaryConditionWebTide, 13 == MikeScenario, 14 == MikeSource, 15 == Municipality, 31 == MWQMRun, 16 == MWQMSite, 23 == MWQMSiteSample, 17 == PolSourceSite, 40 == SamplingPlan, 26 == Spill, 22 == TideSite</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,6,18,3,19,20,4,8,9,10,12,11,13,14,15,31,16,23,17,40,26,22")]
        public int? TVItemID4 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public TVAuthEnum TVAuth { get; set; }
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
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// </summary>
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string ContactTVText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID1", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// </summary>
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID1", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string TVText1 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID2", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// </summary>
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID2", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string TVText2 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID3", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// </summary>
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID3", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string TVText3 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID4", FillReturnField = "TVText", FillNeedLanguage = true)]</para>
        /// </summary>
        [NotMapped]
        [StringLength(200)]
        [CSSPAllowNull]
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID4", FillReturnField = "TVText", FillNeedLanguage = true)]
        public string TVText4 { get; set; }
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
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TVAuthEnum", EnumType = "TVAuth")]</para>
        /// </summary>
        [NotMapped]
        [StringLength(100)]
        [CSSPAllowNull]
        [CSSPEnumTypeText(EnumTypeName = "TVAuthEnum", EnumType = "TVAuth")]
        public string TVAuthText { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will be set to true if an error occurs during CRUD (Creating, Reading, Updating or Deleting) of [TVItemUserAuthorization](CSSPModels.TVItemUserAuthorization)</para>
        /// </summary>
        [NotMapped]
        public bool HasErrors { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>Will hold all errors which were detected prior or during CRUD (Creating, Reading, Updating or Deleting) of [TVItemUserAuthorization](CSSPModels.TVItemUserAuthorization)</para>
        /// </summary>
        [NotMapped]
        public IEnumerable<ValidationResult> ValidationResults { get; set; }
        #endregion Properties not in DB

        #region Constructors
        public TVItemUserAuthorization()
        {
            ValidationResults = new List<ValidationResult>();
        }
        #endregion Constructors
    }
}
