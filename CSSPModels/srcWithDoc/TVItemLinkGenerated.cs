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
    /// > <para>**DB properties for table TVItemLinks** : [TVItemLinkID](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_TVItemLinkID), [FromTVItemID](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_FromTVItemID), [ToTVItemID](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_ToTVItemID), [FromTVType](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_FromTVType), [ToTVType](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_ToTVType), [StartDateTime_Local](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_StartDateTime_Local), [EndDateTime_Local](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_EndDateTime_Local), [Ordinal](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_Ordinal), [TVLevel](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_TVLevel), [TVPath](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_TVPath), [ParentTVItemLinkID](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_ParentTVItemLinkID), [LastUpdateDate_UTC](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_HasErrors), [ValidationResults](CSSPModels.TVItemLink.html#CSSPModels_TVItemLink_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [TVItemLinkService](CSSPServices.TVItemLinkService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [TVTypeEnum](CSSPEnums.TVTypeEnum.html), [TVTypeEnum](CSSPEnums.TVTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class TVItemLink : LastUpdate
    {
        #region Properties in DB
        [Key]
        [CSSPDisplayEN(DisplayEN = "TVItemLink ID")]
        [CSSPDisplayFR(DisplayFR = "TVItemLink ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the TVItemLinks table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table TVItemLinks")]
        public int TVItemLinkID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>1 == Root, 2 == Address, 3 == Area, 4 == ClimateSite, 5 == Contact, 6 == Country, 7 == Email, 8 == File, 9 == HydrometricSite, 10 == Infrastructure, 13 == MikeScenario, 14 == MikeSource, 15 == Municipality, 16 == MWQMSite, 17 == PolSourceSite, 18 == Province, 19 == Sector, 20 == Subsector, 21 == Tel, 22 == TideSite, 24 == WasteWaterTreatmentPlant, 25 == LiftStation, 26 == Spill, 27 == BoxModel, 28 == VisualPlumesScenario, 30 == OtherInfrastructure, 31 == MWQMRun, 38 == MeshNode, 39 == WebTideNode, 40 == SamplingPlan, 41 == SeeOther, 42 == LineOverflow, 52 == MapInfo, 53 == MapInfoPoint</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]
        public int FromTVItemID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>**AllowableTVTypeList is of type [CSSPEnums.TVTypeEnum](CSSPEnums.TVTypeEnum.html)**</para>
        /// > <para>1 == Root, 2 == Address, 3 == Area, 4 == ClimateSite, 5 == Contact, 6 == Country, 7 == Email, 8 == File, 9 == HydrometricSite, 10 == Infrastructure, 13 == MikeScenario, 14 == MikeSource, 15 == Municipality, 16 == MWQMSite, 17 == PolSourceSite, 18 == Province, 19 == Sector, 20 == Subsector, 21 == Tel, 22 == TideSite, 24 == WasteWaterTreatmentPlant, 25 == LiftStation, 26 == Spill, 27 == BoxModel, 28 == VisualPlumesScenario, 30 == OtherInfrastructure, 31 == MWQMRun, 38 == MeshNode, 39 == WebTideNode, 40 == SamplingPlan, 41 == SeeOther, 42 == LineOverflow, 52 == MapInfo, 53 == MapInfoPoint</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]</para>
        /// </summary>
        [CSSPExist(ExistTypeName = "TVItem", ExistPlurial = "s", ExistFieldID = "TVItemID", AllowableTVTypeList = "1,2,3,4,5,6,7,8,9,10,13,14,15,16,17,18,19,20,21,22,24,25,26,27,28,30,31,38,39,40,41,42,52,53")]
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

        #region Constructors
        public TVItemLink() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemLink_A : TVItemLink
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "FromTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "FromTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage FromTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ToTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// </summary>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "ToTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        public TVItemLanguage ToTVItemLanguage { get; set; }
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
        #endregion Properties

        #region Constructors
        public TVItemLink_A() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class TVItemLink_B : TVItemLink_A
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
        public string TVItemLinkReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public TVItemLink_B() : base()
        {
        }
        #endregion Constructors
    }
}
