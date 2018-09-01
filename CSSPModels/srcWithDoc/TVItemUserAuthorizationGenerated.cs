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
    /// > <para>**DB properties for table TVItemUserAuthorizations** : [TVItemUserAuthorizationID](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_TVItemUserAuthorizationID), [ContactTVItemID](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_ContactTVItemID), [TVItemID1](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_TVItemID1), [TVItemID2](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_TVItemID2), [TVItemID3](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_TVItemID3), [TVItemID4](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_TVItemID4), [TVAuth](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_TVAuth), [LastUpdateDate_UTC](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_HasErrors), [ValidationResults](CSSPModels.TVItemUserAuthorization.html#CSSPModels_TVItemUserAuthorization_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TVItemUserAuthorizationService](CSSPServices.TVItemUserAuthorizationService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [TVAuthEnum](CSSPEnums.TVAuthEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class TVItemUserAuthorization : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TVItemUserAuthorization ID")]
        [CSSPDisplayFR(DisplayFR = "TVItemUserAuthorization ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TVItemUserAuthorizations table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table TVItemUserAuthorizations")]
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
        /// > <para>1 == Root, 2 == Address, 3 == Area, 4 == ClimateSite, 5 == Contact, 6 == Country, 7 == Email, 8 == File, 9 == HydrometricSite, 10 == Infrastructure, 13 == MikeScenario, 14 == MikeSource, 15 == Municipality, 16 == MWQMSite, 17 == PolSourceSite, 18 == Province, 19 == Sector, 20 == Subsector, 21 == Tel, 22 == TideSite, 24 == WasteWaterTreatmentPlant, 25 == LiftStation, 26 == Spill, 27 == BoxModel, 28 == VisualPlumesScenario, 30 == OtherInfrastructure, 31 == MWQMRun, 38 == MeshNode, 39 == WebTideNode, 40 == SamplingPlan, 41 == SeeOther, 42 == LineOverflow, 52 == MapInfo, 53 == MapInfoPoint</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]
        public int TVItemID1 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>1 == Root, 2 == Address, 3 == Area, 4 == ClimateSite, 5 == Contact, 6 == Country, 7 == Email, 8 == File, 9 == HydrometricSite, 10 == Infrastructure, 13 == MikeScenario, 14 == MikeSource, 15 == Municipality, 16 == MWQMSite, 17 == PolSourceSite, 18 == Province, 19 == Sector, 20 == Subsector, 21 == Tel, 22 == TideSite, 24 == WasteWaterTreatmentPlant, 25 == LiftStation, 26 == Spill, 27 == BoxModel, 28 == VisualPlumesScenario, 30 == OtherInfrastructure, 31 == MWQMRun, 38 == MeshNode, 39 == WebTideNode, 40 == SamplingPlan, 41 == SeeOther, 42 == LineOverflow, 52 == MapInfo, 53 == MapInfoPoint</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]
        public int? TVItemID2 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>1 == Root, 2 == Address, 3 == Area, 4 == ClimateSite, 5 == Contact, 6 == Country, 7 == Email, 8 == File, 9 == HydrometricSite, 10 == Infrastructure, 13 == MikeScenario, 14 == MikeSource, 15 == Municipality, 16 == MWQMSite, 17 == PolSourceSite, 18 == Province, 19 == Sector, 20 == Subsector, 21 == Tel, 22 == TideSite, 24 == WasteWaterTreatmentPlant, 25 == LiftStation, 26 == Spill, 27 == BoxModel, 28 == VisualPlumesScenario, 30 == OtherInfrastructure, 31 == MWQMRun, 38 == MeshNode, 39 == WebTideNode, 40 == SamplingPlan, 41 == SeeOther, 42 == LineOverflow, 52 == MapInfo, 53 == MapInfoPoint</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]
        public int? TVItemID3 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>1 == Root, 2 == Address, 3 == Area, 4 == ClimateSite, 5 == Contact, 6 == Country, 7 == Email, 8 == File, 9 == HydrometricSite, 10 == Infrastructure, 13 == MikeScenario, 14 == MikeSource, 15 == Municipality, 16 == MWQMSite, 17 == PolSourceSite, 18 == Province, 19 == Sector, 20 == Subsector, 21 == Tel, 22 == TideSite, 24 == WasteWaterTreatmentPlant, 25 == LiftStation, 26 == Spill, 27 == BoxModel, 28 == VisualPlumesScenario, 30 == OtherInfrastructure, 31 == MWQMRun, 38 == MeshNode, 39 == WebTideNode, 40 == SamplingPlan, 41 == SeeOther, 42 == LineOverflow, 52 == MapInfo, 53 == MapInfoPoint</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]
        public int? TVItemID4 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// </summary>
        [CSSPEnumType]
        public TVAuthEnum TVAuth { get; set; }
        #endregion Properties in DB

        #region Constructors
        public TVItemUserAuthorization() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemUserAuthorization_A : TVItemUserAuthorization
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage ContactTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID1", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID1", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage TVItemLanguage1 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID2", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID2", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        public TVItemLanguage TVItemLanguage2 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID3", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID3", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        public TVItemLanguage TVItemLanguage3 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID4", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "TVItemID4", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        public TVItemLanguage TVItemLanguage4 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "TVAuthEnum", EnumType = "TVAuth")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPEnumTypeText(EnumTypeName = "TVAuthEnum", EnumType = "TVAuth")]
        [CSSPAllowNull]
        public string TVAuthText { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemUserAuthorization_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemUserAuthorization_B : TVItemUserAuthorization_A
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string TVItemUserAuthorizationReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemUserAuthorization_B() : base()
        {
        }
        #endregion Constructors
    }
}
